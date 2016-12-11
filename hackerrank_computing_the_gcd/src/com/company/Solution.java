package com.company;
import java.io.*;

public class Solution {

    public static void main(String[] args) throws IOException {
        BufferedReader br =new BufferedReader(new InputStreamReader(System.in));
        String[] input = br.readLine().split(" ");
        int x = Integer.parseInt(input[0]);
        int y = Integer.parseInt(input[1]);
        System.out.println(gcd(x, y));
    }

    static int gcd(int x, int y) {

        if(x == y)
            return x;
        return (x > y) ? gcd(x-y, y) : gcd(y-x, x);
    }
}