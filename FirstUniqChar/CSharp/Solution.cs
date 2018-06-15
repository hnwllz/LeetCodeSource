 public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> charCount = new Dictionary<char,int>();
        Dictionary<char,int> charIndex = new  Dictionary<char,int>();
        
        for(int i=0;i<s.Length;i++){
            if(!charIndex.ContainsKey(s[i])){
                charCount.Add(s[i],0);
                charIndex.Add(s[i],i);
            }
            
            charCount[s[i]]++;
        }
        
        foreach(char k in charCount.Keys){
            if(charCount[k] == 1){
                return charIndex[k];
            }
        }
        
        return -1;
    }
} 
