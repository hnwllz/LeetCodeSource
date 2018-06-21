/*
在数数并说的问题中，所有的项n都是基于上一项n-1的结果来统计计算的，所以有一下公式
f(n) = g(f(n-1)); n>1;
f(n) = 1;  n=1;
其中：f函数代表统计和返回项n的字符串，g函数是计算f函数返回的字符串的解析统计过程。
*/

public class Solution {
    //代表函数f
    public string CountAndSay(int n) {
        if(n==1){
            return "1";
        }
        
        return CountAndStr(CountAndSay(n-1));
    }
    //代表函数g
    private string CountAndStr(string str){
        StringBuilder builder = new StringBuilder();
        
        int count = 1;
        char cur = str[0];
        for(int i=1;i<str.Length;i++){
            char c = str[i];
            if(cur != c){
                builder.Append(count.ToString()+cur);
                cur = c;
                count = 1;
            }
            else{
                count++;
            }
        }
        
        //统计最后的字符
        builder.Append(count.ToString()+cur);
        return builder.ToString();        
    }
}
