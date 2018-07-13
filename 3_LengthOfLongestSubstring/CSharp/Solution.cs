/**
看到题目的第一想法就是暴力解决的方式，对每个字符串中的字符都向前进行比对，如果存在则认为是从上个字符到现在最长的子串
这种方式最好时间复杂度是所有字符都是一样的，那么复杂度为O(2n),最坏时间复杂度是都不重复O(n^2)
进一步优化，利用一个256长度的数组记录每个子串出现过的字符，这样比对的时间复杂度O(1)
**/
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s==null || s.Length==0){
            return 0;
        }        
        
        int index=0;//子串开始位置
        int maxLen = 0;
        int[] a=new int[256];
       
        for(int i=0;i<s.Length;i++){
            char ch =s[i];
            if(a[ch]>0){
                
                //和以前的子串比较，如果比之前的都长，则记录
                if(i-index>maxLen){
                    maxLen = i-index;
                }
                /**
                //重置数组记录下一组子串
                index = a[ch];//从重复字符的下一个位置开始
                i = index-1;
                ResetArray(a,0);     
                **/
                //取消重复字符及其之前字符的标志
                for(int j=index;j<a[ch]-1;j++){
                    a[s[j]]=0;
                }
                
                index = a[ch];//重新设置子串的开始位置
                a[ch] = i+1;
            }
            else{
                a[ch]= i+1;
            }
        }
        
        if(s.Length-index>maxLen){
            maxLen = s.Length-index;
        }
        
        return maxLen;
    }
    
    private void ResetArray(int[] a,int v){
        for(int i=0;i<a.Length;i++){
            a[i]=v;
        }
    }
}
