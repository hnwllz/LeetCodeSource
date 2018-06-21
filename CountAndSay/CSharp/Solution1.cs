/*
解决方案二，原理和解决方案一类似，不同在于当前解决方案不用递归的方式而是用循环的方式来实现。
*/

public class Solution {

    public string CountAndSay(int n) {
        string str = "1";
        //不管哪个项都是需要从1开始统计n次
        while(n-- > 1){
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
            str = builder.Append(count.ToString()+cur).ToString();
        }
        
        return str;
    }    
}
