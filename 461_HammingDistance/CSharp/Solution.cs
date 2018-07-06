
/**
汉明距离
常规方式，就是逐位比较x和y对应的位信息，如果不一致计数加一。
**/
public class Solution {
    public int HammingDistance(int x, int y) {
        int count=0;
        while(x > 0 ||y > 0){
            if((x&1)!=(y&1)){
                count++;
            }
            
            x >>= 1;
            y >>= 1;
        }
        
        return count;
    }
}

/**第二种方式，先通过位运算计算两个数之间的差异，再计算汉明重量来统计汉明距离
 有个很有意思的地方，再对n进行判断是n>0比n!=0慢了好多。

public class Solution {
    public int HammingDistance(int x, int y) {
        int n = x^y;
        int count =0;
        while(n != 0){
            count++;
            n=(n&(n-1));
        }
        
        return count;
    }
}
**/
