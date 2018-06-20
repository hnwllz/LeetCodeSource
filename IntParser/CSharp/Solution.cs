public class Solution {
    public int MyAtoi(string str) {
        int result = 0;
        int negative = 1;
        
        int i = 0;
        while(i < str.Length && str[i] == ' '){
            i++;
            continue;
        }
        
        if( i < str.Length && (str[i] == '-' || str[i] == '+')){
            if(str[i] == '-'){
                negative = -1;
            }
            i++;
        }
       
        
        while(i<str.Length && str[i] >= '0' && str[i] <='9'){
            checked
            {
                try{
                    result =result * 10 + (str[i] - '0');   
                    i++;
                }
                catch(OverflowException ex){
                    return negative>-1?int.MaxValue:int.MinValue;
                }
            }
        }
        
        return result * negative;
    }
}
