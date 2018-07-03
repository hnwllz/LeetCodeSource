
/**
爬楼梯问题
动态规划有三个要素：最优子结构，边界和状态转移方程
爬楼的的最优子结构是爬到阶梯n时的方法为从爬上阶梯n-1和爬上阶梯n-2方法之和，即f(n) = f(n-1)+f(n-2);
边界是n=1时只有1中方法,n=2时有两种方法
状态转移方程
        | 1 n==1
f（n）= | 2  n==2
        | f(n-1)+f(n-2) n>2
        
实现方法有三种：
方法一：
普通的递归方式，实时计算每个节点的值
public class Solution{
    public int ClimbStairs(int n){
        if(n<=1){
            return 1;
        }
        if(n == 2){
            return 2;
        }
        
        return ClimbStairs(n-1) + ClimbStairs(n-2);
    }
}
但是这种方法计算过程是一个二叉树，每个树节点都需要计算。所以时间复杂度O(2^n),空间复杂度O（1）。
所以时间总是会超过限制。

方法二：
在方法一的基础上增加一个对已经计算过的结果进行缓存，减少计算。

public class Solution {
    private int[] _stairs;
    public int ClimbStairs(int n) {
        _stairs = new int[n+1];
        return Climb(n);
    }
    
    private int Climb(int n){
       if(n==0||n==1){
           return 1;
       }
       if(n==2){
           return n;
       }
        
        if(_stairs[n]>0){
            return _stairs[n];
        }
        
        _stairs[n] = Climb(n-1)+Climb(n-2);
        return _stairs[n];
    }

}

时间复杂度O(n),空间复杂度也是O(n)

方法三
通过观察可以看到，状态转移方程实际上是一个菲波那切数列公式，变量n的结果只和上一个n-1和n-2的结果有关，可以对这个两个结果进行保存，以减少空间的开销
**/
public class Solution {
    public int ClimbStairs(int n) {
        if(n<=1)
        {
            return 1;
        }
        if(n==2){
            return 2;
        }
        
        int a=1;
        int b=2;
        for(int i=3;i<=n;i++){
            int tmp = a+b;
            a=b;
            b=tmp;
        }
        
        return b;
    }
}


