/*
方案一
分别利用两个256长度的整数数组sCount和tCount记录字符串s和t中字符的数量。
统计完后，分别校对字符在s和t中出现的次数，如果不一致，则说明s和t不是异位词，反之，则是。
*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s==null || t==null || s.Length != t.Length){
            return false;
        }
        
        int[] sCount = new int[256];
        int[] tCount = new int[256];
        
        for(int i=0;i<s.Length;i++){
            sCount[(int)s[i]]++;
            tCount[(int)t[i]]++;
        }
        
        for(int i= 0 ;i<sCount.Length;i++){
            if(sCount[i] != tCount[i]){
                return false;
            }
        }
        
        return true;
    }

}
