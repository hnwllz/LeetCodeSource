/**
方法二，原地算法
利用原来的矩阵存储改变后的状态，但是又不能对相邻的格子造成影响，所以可以通过位运算来进行细胞的状态保存，
矩阵中的值可以使用两位来记录信息00，第一位记录更新后状态，最后一位记录原来的信息。计算格子的状态使用 board[i][j]&1==1
**/
public class Solution {
    public void GameOfLife(int[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                int alives = GetAlives(board,i,j);
                if(board[i][j]==1&& alives<=3&&alives>=2){
                    board[i][j]=3;//二进制：11,表示原来状态1，更新后状态1
                }          
                if(board[i][j]==0&& alives==3){
                    board[i][j]=2;//二进制：10,表示原来状态0，更新后状态1
                }
            }
        }
        
        //通过移位操作重置状态到更新后的状态。
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                board[i][j]>>=1;
            }
        }
    }
    
    //获取格子周围八宫格的状态为1的数量
    private int GetAlives(int[][] board,int i,int j){
        int count =0;
        int m = board.Length;
        int n = board[0].Length;
        
        for(int r=Math.Max(0,i-1);r<=Math.Min(m-1,i+1);r++){
            for(int c=Math.Max(0,j-1);c<=Math.Min(n-1,j+1);c++){
                count += board[r][c]&1;
            }
        }
        
        //注意统计是需要把自己排除
        count -= board[i][j]&1;
        
        return count;
    }
}
