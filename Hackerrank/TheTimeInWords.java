import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

        static String[] numbers = { "zero", "one",        "two",        "three",        "four",        "five",
        "six",
        "seven",
        "eight",
        "nine",
        "ten",
        "eleven",
        "twelve",
        "thirteen",
        "fourteen",
        "quarter",
        "sixteen",
        "seventeen",
        "eighteen",
        "nineteen",
        "twenty",
        "twenty one",
        "twenty two",
        "twenty three",
        "twenty four",
        "twenty five",
        "twenty six",
        "twenty seven",
        "twenty eight",
        "twenty nine",
        "half"
    };

    // Complete the timeInWords function below.
    static String timeInWords(int h, int m) {

        if(m == 0)
            return numbers[h] + " o' clock";
        
        int mmod = (m > 30) ? 60-m : m;
        String minutesAsString = (mmod == 15 || mmod == 30) ? numbers[mmod] : numbers[mmod] + " minute";
        if(mmod > 1 && mmod != 15 && mmod != 30)
            minutesAsString += "s";

        if(m <= 30)
            return minutesAsString + " past " + numbers[h];

        h %= 12;
        
        return minutesAsString + " to " + numbers[h+1];
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int h = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int m = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        String result = timeInWords(h, m);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
