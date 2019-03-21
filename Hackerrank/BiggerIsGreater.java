import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the biggerIsGreater function below.
    static String biggerIsGreater(String w) {

        int start = -1;

        for(int i=0; i<w.length()-1; i++) {
            if(w.charAt(i) < w.charAt(i+1))
                start = i;
        }

        // no answer is available if no increasing sequence found
        if(start == -1)
            return "no answer";

        // end is last char greater than start
        int end = start+1;
        for(int i=start+1; i<w.length(); i++)
            if(w.charAt(start) < w.charAt(i))
                end = i;

        StringBuilder builder = new StringBuilder();

        // add chars before starting index
        for(int i=0; i<start; i++)
            builder.append(w.charAt(i));

        // add end char
        builder.append(w.charAt(end));

        // sort remaining chars
        PriorityQueue<Character> priorityQueue = new PriorityQueue<>();
        for(int i=start; i<w.length(); i++) {
            if(i != end)
                priorityQueue.add(w.charAt(i));
        }
        while(priorityQueue.size() > 0)
            builder.append(priorityQueue.poll());

        return builder.toString();
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int T = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int TItr = 0; TItr < T; TItr++) {
            String w = scanner.nextLine();

            String result = biggerIsGreater(w);

            bufferedWriter.write(result);
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
