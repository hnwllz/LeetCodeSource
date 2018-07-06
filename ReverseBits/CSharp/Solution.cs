/**
利用栈的原理，将原来的值向左移动出栈，将栈顶的位入栈到新值中。
**/

public class Solution {
    public uint reverseBits(uint n) {
         uint v = 0;
        for(int i=0;i<32;i++)
        {
            v <<= 1; //移动新值空出低位
            v |= (n&1); //将旧值低位的值复制到新值中
            n >>= 1;//移动旧值
        }
        
        return v;
    }
}
