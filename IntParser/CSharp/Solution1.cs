public class Solution {
    public int MyAtoi(string str) {
        int result = 0;
        int negative = 1;
        
        int i = 0;
        //过滤掉字符串前面的空格符号
        while(i < str.Length && str[i] == ' '){
            i++;
            continue;
        }
        
        //处理数字前表示数字正和负的符号
        //需要注意的是：只能判断一个位置上的符号，多余的符号算非数字字符错误
        if( i < str.Length && (str[i] == '-' || str[i] == '+')){
            if(str[i] == '-'){
                negative = -1;
            }
            i++;
        }
       
        //依次判断数字字符，并转化成数字叠加到结果上
        //判断的方式是判断已经叠加的数字是否已经比同高位的最大值大，如果相同则比较末位的数字
        //在这需要注意，避免溢出问题的出现，应该用result > int.MaxValue/10的方式代替result*10>int.MaxValue;
        while(i<str.Length && str[i] >= '0' && str[i] <='9'){
            if(result > int.MaxValue/10 || (result == int.MaxValue/10 && (str[i] - '0') > int.MaxValue%10)){
                return negative>-1?int.MaxValue:int.MinValue;
            }
            
            result = result*10 + str[i] - '0';
            i++;
        }
        
        return result * negative;
    }
}
