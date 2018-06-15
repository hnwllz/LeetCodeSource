/*
方案一
回文串：是一个正读和反读都一样的字符串，比如“level”或者“noon”等等就是回文串
先用整数数组将字符串字符存储，存储过程中对字符进行过滤和转换（将大写转换成小写对应的ascii码）
然后，首尾递增递减的进行比对，如果都一致则是回文串，否则不是
*/
public class Solution {
    public bool IsPalindrome(string s) {
        //过滤空字符串
        if(s == null || s.Length == 0){
            return true;
        }
        
        //统计字符串中的字符，过滤掉非字母和数字字符。并且将大写字母字符转换成小写字母字符
        int index = 0;
        int[] array = new int[s.Length];
        for(int i=0;i<s.Length;i++){
            if(IsLowerChar(s[i])||IsNum(s[i])){
                array[index++] = (int)s[i];                
            }
            if(IsUpperChar(s[i])){
                array[index++] = s[i] - 'A' + 'a';
            }
        }
        
        //通过首尾比对校验是否是回文串
        for(int i=0;i<index/2;i++){
            if(array[i] != array[index - i -1] 
               && (Math.Abs(array[i] - array[index - i -1]) != Math.Abs('A' - 'a'))){
                return false;
            }
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
