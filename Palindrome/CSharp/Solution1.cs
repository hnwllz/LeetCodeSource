/*
方案二
回文串：是一个正读和反读都一样的字符串，比如“level”或者“noon”等等就是回文串
分别用一个索引指向字符串的首尾。然后 ，分别向中间移动，比较首尾索引位置的字符，
如果不是字母字符和数字字符，继续移动。否则进行比较
*/
public class Solution {
    public bool IsPalindrome(string s) {
        //过滤空字符串
        if(s == null || s.Length == 0){
            return true;
        }
        
        int i = 0,e = s.Length - 1;
        while(i < e){
            if(!(IsLowerChar(s[i])||IsUpperChar(s[i])||IsNum(s[i]))){
                i++;
                continue;
            }
            if(!(IsLowerChar(s[e])||IsUpperChar(s[e])||IsNum(s[e]))){
                e--;
                continue;
            }
            
            if(s[i] != s[e]){
                
                if(IsNum(s[i])||IsNum(s[e]))
                {
                    return false;
                }
                else if((Math.Min(s[i],s[e]) != Math.Max(s[i],s[e])-'a'+'A')){
                   return false; 
                }
            }
               
            i++;
            e--;
        }
        
        return true;
    }

    
    private  bool IsLowerChar(char c){
        return ('a'<=c && 'z'>=c);
    }
    
    private  bool IsUpperChar(char c){
        return ('A'<=c && 'Z'>=c);
    }
    
    private bool IsNum(char c){
        return '0'<=c && '9'>=c;
    }
}
