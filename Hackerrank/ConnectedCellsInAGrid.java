/*
https://www.hackerrank.com/challenges/connected-cell-in-a-grid/problem
*/

import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    static boolean outOfBounds(int[][] matrix, int r, int c) {
        return r < 0 || c < 0 || r >= matrix.length || c >= matrix[0].length;
    }

    // marks region as visited
    // returns number of filled cells in the given position
    static int exploreRegion(int[][] matrix, int r, int c) {
        if(outOfBounds(matrix, r, c) || matrix[r][c] == 0) return 0;
        
        matrix[r][c] = 0;
        return 1 + exploreRegion(matrix, r+1, c)
                + exploreRegion(matrix, r-1, c)
                + exploreRegion(matrix, r, c+1)
                + exploreRegion(matrix, r, c-1)
                + exploreRegion(matrix, r+1, c+1)
                + exploreRegion(matrix, r-1, c-1)
                + exploreRegion(matrix, r+1, c-1)
                + exploreRegion(matrix, r-1, c+1);
    }

    // Complete the connectedCell function below.
    static int connectedCell(int[][] matrix) {

        if(matrix.length == 0)
            return 0;

        int largestRegion = 0;
        for(int r=0; r<matrix.length; r++) {
            for(int c=0; c<matrix[0].length; c++) {
                if(matrix[r][c] == 0) continue;
                largestRegion = Math.max(largestRegion, exploreRegion(matrix, r, c));
            }
        }
        return largestRegion;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int m = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int[][] matrix = new int[n][m];

        for (int i = 0; i < n; i++) {
            String[] matrixRowItems = scanner.nextLine().split(" ");
            scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

            for (int j = 0; j < m; j++) {
                int matrixItem = Integer.parseInt(matrixRowItems[j]);
                matrix[i][j] = matrixItem;
            }
        }

        int result = connectedCell(matrix);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
