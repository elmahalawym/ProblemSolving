// https://leetcode.com/problems/find-right-interval/#/description

/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public int[] FindRightInterval(Interval[] intervals) {
        
        Tuple<int, int>[] startToIndex = new Tuple<int, int>[intervals.Length];
        
        for(int i=0; i<intervals.Length; i++)
            startToIndex[i] = new Tuple<int, int>(intervals[i].start, i);
        
        Array.Sort(startToIndex, (x, y) => x.Item1 - y.Item1);
        
        int[] res = new int[intervals.Length];
        
        for(int i=0; i<intervals.Length; i++) {
            res[i] = Search(startToIndex, intervals[i].end);
        }
        return res;
    }
    
    private int Search(Tuple<int, int>[] intervals, int position) {
        
        int start = 0, end = intervals.Length-1;
        while(start <= end) {
            int mid = (start + end) / 2;

            if(intervals[mid].Item1 >= position) {
                if(mid == 0 || intervals[mid-1].Item1 < position)
                    return intervals[mid].Item2;
                end = mid-1;
            }
            else if(intervals[mid].Item1 < position) {
                start = mid+1;
            }
        }
        return -1;
    }
}