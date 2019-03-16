import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

enum Direction {up, down, left, right, upright, upleft, downright, downleft }

class Pair{
    int a;
    int b;
    Pair(int p,int q){
        a=p;
        b=q;
    }
    public boolean equals(Object o) {
        if (o instanceof Pair) {
            Pair p = (Pair)o;
            return p.a == a && p.b == b;
        }
        return false;
    }
    public int hashCode() {
        return new Integer(a).hashCode() * 31 + new Integer(b).hashCode();
    }
}

class QueenIterator {
    int row, col, size;
    Direction direction;

    public QueenIterator(int size, int row, int col, Direction direction) {
        this.row = row;
        this.col = col;
        this.size = size;
        this.direction = direction;
    }

    int getRow() {
        return row;
    }

    int getColumn() {
        return col;
    }

    boolean inBounds() {
        return row >=0 && col >= 0 && row < size && col < size;
    }

    void next() {
        switch(direction) {
            case up:
                row--;
                break;
            case down:
                row++;
                break;
            case left:
                col--;
                break;
            case right:
                col++;
                break;
            case upleft:
                row--;
                col--;
                break;
            case upright:
                row--;
                col++;
                break;
            case downleft:
                row++;
                col--;
                break;
            case downright:
                row++;
                col++;
                break;
        }
    }
}

public class Solution {

    // Complete the queensAttack function below.
    static int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles) {

        // zero based indexes
        r_q--; c_q--;

        ArrayList<QueenIterator> iterators = new ArrayList<>();

        iterators.add(new QueenIterator(n, r_q, c_q, Direction.up));
        iterators.add(new QueenIterator(n, r_q, c_q, Direction.down));
        iterators.add(new QueenIterator(n, r_q, c_q, Direction.left));
        iterators.add(new QueenIterator(n, r_q, c_q, Direction.right));
        iterators.add(new QueenIterator(n, r_q, c_q, Direction.upleft));
        iterators.add(new QueenIterator(n, r_q, c_q, Direction.upright));
        iterators.add(new QueenIterator(n, r_q, c_q, Direction.downleft));
        iterators.add(new QueenIterator(n, r_q, c_q, Direction.downright));

        HashSet<Pair> set = new HashSet<>();
        for(int i=0; i<obstacles.length; i++)
            set.add(new Pair(obstacles[i][0]-1, obstacles[i][1]-1));

        int result = 0;
        for(int i=0; i<iterators.size(); i++) {
            QueenIterator iterator = iterators.get(i);
            iterator.next();
            while(iterator.inBounds()) {
                if(set.contains(new Pair(iterator.getRow(), iterator.getColumn())))
                    break;
                result++;
                iterator.next();
            }
        }
        return result;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] nk = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nk[0]);

        int k = Integer.parseInt(nk[1]);

        String[] r_qC_q = scanner.nextLine().split(" ");

        int r_q = Integer.parseInt(r_qC_q[0]);

        int c_q = Integer.parseInt(r_qC_q[1]);

        int[][] obstacles = new int[k][2];

        for (int i = 0; i < k; i++) {
            String[] obstaclesRowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < 2; j++) {
                int obstaclesItem = Integer.parseInt(obstaclesRowItems[j]);
                obstacles[i][j] = obstaclesItem;
            }
        }

        int result = queensAttack(n, k, r_q, c_q, obstacles);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
