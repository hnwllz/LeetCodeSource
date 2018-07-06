/**
汉明重量
方式1：
逐位比较，对低位进行比较
public class Solution {
     public int HammingWeight(uint n) {
        int count =0 ;
        while(n>0){
            if((n&1)==1){
                count++;
            }
            
            n >>= 1;
        }
        
        return count;
    }
}

方式2

**/

public class Solution {
     public int HammingWeight(uint n) {
        int count =0 ;
        while(n>0){
            count++;
            n &= (n-1);
        }
        
        return count;
    }
}
