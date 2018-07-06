/**
方法一：
解题思路是将括号对按照自己的设计赋给一个对应的有效值，括号对中左括号值是偶数，右括号是相邻大一的奇数
然后在解析字符串时，遇到偶数值就将值压入栈中，奇数的话就弹出栈顶的值并进行对比，如果是正确的括号对，则表示有效。
这种方法有点在于灵活，能够在以后增加不同的符号对时也能兼容正常运行。缺点就是效率不高，多了一个计算括号值得过程。
public class Solution {
    public bool IsValid(string s) {        
        Stack<int> sta = new Stack<int>();
        for(int i=0;i<s.Length;i++){
            int v = GetValue(s[i]);
            if(v%2==0){
                sta.Push(v);
            }
            else{
                if(sta.Count==0 || (sta.Pop()+1)!= v){
                    return false;
                }
            }
        }
         return sta.Count==0;
    }
    
    private int GetValue(char c){
        char[] syms=new char[]{'(',')','[',']','{','}'};
        for(int i=0;i<syms.Length;i++){
            if(c==syms[i]){
                return i;
            }
        }
        
        return -1;
    }
}
**/
/**
方法二：

**/
public class Solution {
    public bool IsValid(string s) { 
        Stack<char> sta = new Stack<char>();
        for(int i=0;i<s.Length;i++){
            switch(s[i]){
                case '(':
                    sta.Push(')');
                    break;
                case '[':
                    sta.Push(']');
                    break;
                case '{':
                    sta.Push('}');
                    break;
                default:
                    if(sta.Count==0 || sta.Pop()!=s[i]){
                        return false;
                    }                    
                    break;
            }
        }
        
        return 
    }
}
