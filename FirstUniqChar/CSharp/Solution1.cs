/*
方案二
利用一个256的数组保存对应字符在字符串中出现的次数统计，
利用另一个256的数组保存对应字符第一次出现位置的索引值。
统计完字符数量后，从索引数组中找出出现次数为1并且索引值最小的索引值即可。
*/
public class Solution {
    public int FirstUniqChar(string s) {
        int[] charCount = new int[256];
        int[] charIndex = new int[256];
        for(int i=0;i<charIndex.Length;i++){
            charIndex[i] = -1;
        }
        
        for(int i=0;i<s.Length;i++){
            charCount[(int)s[i]]++;
            if(charIndex[(int)s[i]] == -1){
                charIndex[(int)s[i]] = i;
            }
        }
        
        int result = -1;
        for(int i=0;i<charCount.Length;i++){
            if(charCount[i] == 1){
                if(result == -1){
                    result = charIndex[i];
                }
                else if(result > charIndex[i]){
                    result = charIndex[i];
                }
            }
        }
        
        return result;
    }
}
