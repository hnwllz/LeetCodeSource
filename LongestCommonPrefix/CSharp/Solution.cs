
/*
最长前缀的判断还是比较简单的，
只需要逐一比对数组中字符串的同索引位置的字符，如果一致则该字符是最长前缀一部分。例如：
0 1 2 3 4 5
f l o w e r
f l o w
f l i g h t
*/
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length==0){
            return "";
        }
        
        if(strs.Length == 1){
            return strs[0];
        }
        
        int minlen = int.MaxValue;
        for(int i=0;i<strs.Length;i++){
            if(minlen > strs[i].Length){
                minlen = strs[i].Length;
            }
        }
        
        if(minlen == 0){
            return "";
        }
        
        int n=-1;
        StringBuilder builder = new StringBuilder();
        while ((++n) < minlen){
            char c = strs[0][n];
            for(int i=1;i<strs.Length;i++){
                if(strs[i][n] != c){
                    return builder.ToString();
                }
            }
            
            builder.Append(c);
        }
        
        return builder.ToString();
    }
}
