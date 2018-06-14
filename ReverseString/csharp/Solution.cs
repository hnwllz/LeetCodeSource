//方法一、
//字符串类型的实例是不可以修改，所以可以先将字符串转换成字符数组，然后将字符数组进行倒置交换位置，第一个字符和最后一个字符，第二个和倒数第二个字符交互，一次类推。
class Solution {
public  string ReverseString(string s) {
   
        char[]  a = s.ToCharArray();
        for(int i=0;i<(int)(s.Length/2);i++){
            char c =a[i];
            a[i] = a[s.Length - i -1];
            a[s.Length - i -1] = c;
        }
    
        return new string(a);
    }

//方法二，同方法一类似，不同的是直接用数组反向存储字符串的字符即可
public  string ReverseString1(string s) {
        if(s == null || s.Length < 2) return s;
    
        char[] array = new char[s.Length];
        for(int i= s.Length - 1;i> -1;i--){
            array[s.Length - i - 1] = s[i]; 
        }
    
        return new string(array);
    }
   
};
//方法三、同方法二，用c#中已有的StringBuilder代替字符数组来构建字符串。这种方法比方法二简洁高效。
public  string ReverseString(string s) {
        if(s == null || s.Length < 2) return s;
    
        StringBuilder appender = new StringBuilder();
        for(int i= s.Length - 1;i> -1;i--){
            appender.Append(s[i]); 
        }
    
        return appender.ToString();
    }
