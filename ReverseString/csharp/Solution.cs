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
   
};
