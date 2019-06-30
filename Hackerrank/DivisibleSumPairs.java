/*
    https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
*/

import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar) {

        for(int i=0; i<ar.length; i++)
            ar[i] %= k;

        HashMap<Integer, Integer> map = new HashMap<>();
        int result = 0;
        
        for(int i=0; i<ar.length; i++) {
            int cur = ar[i];
            int target = k-ar[i];
            if(map.containsKey(target))
                result += map.get(target);

            if(cur == 0 && map.containsKey(0))
                result += map.get(0);

            if(map.containsKey(cur))
                map.put(cur, map.get(cur)+1);
            else
                map.put(cur, 1);
        }

        return result;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] nk = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nk[0]);

        int k = Integer.parseInt(nk[1]);

        int[] ar = new int[n];

        String[] arItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int arItem = Integer.parseInt(arItems[i]);
            ar[i] = arItem;
        }

        int result = divisibleSumPairs(n, k, ar);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
