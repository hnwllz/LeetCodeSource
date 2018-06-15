/*
方案二
方案二本质和方案一是没有区别的，只不过在特定指定只有小写字母的情况下，只需要26长度的数组即可
*/
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s==null || t==null || s.Length != t.Length){
            return false;
        }
        
        int[] sCount = new int[26];
        int[] tCount = new int[26];
        
        for(int i=0;i<s.Length;i++){
            sCount[s[i]-'a']++;
            tCount[t[i]-'a']++;
        }
        
        for(int i= 0 ;i<sCount.Length;i++){
            if(sCount[i] != tCount[i]){
                return false;
            }
        }
        
        return true;
    }

}
