public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle == null || needle.Length == 0){
            return 0;
        }
        
        if(haystack.Length < needle.Length){
            return -1;
        }
        
        for(int index = 0;index <haystack.Length - needle.Length +1;index++){
            int i = index;
            while(i < haystack.Length && (i-index) < needle.Length && haystack[i] == needle[i-index]){
                i++;
            }
            
            if((i-index) == needle.Length){
                return index;
            }
        }
        
        return -1;
    }
}
