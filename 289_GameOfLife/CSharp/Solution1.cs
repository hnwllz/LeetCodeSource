/**
方法一，非原地算法
借助一个m*n矩阵用来记录下一个状态。
**/
public class Solution {
    public void GameOfLife(int[][] board) {
        int r = board.Length;
        int c = board[0].Length;
        int[,] board1 = new int[r,c];
        
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[i].Length;j++){
                int alives = GetAlives(board,i,j);
                if(board[i][j]==1){
                    if(alives<2 || alives>3){
                        board1[i,j]=0;
                    }
                    else{
                        board1[i,j]=1;
                    }
                }          
                else{
                    if(alives==3){
                        board1[i,j]=1;
                    }
                    else{
                        board1[i,j]=0;
                    }
                }
            }
        }
        
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                board[i][j]=board1[i,j];
            }
        }
    }
    
    private int GetAlives(int[][] board,int i,int j){
        int count =0;
        int r = board.Length;
        int c = board[0].Length;
        
        if(i-1>=0){            
            count+=board[i-1][j];
            
            if(j-1>=0){
                count+=board[i-1][j-1];
            }
            if(j+1<c){
                count+=board[i-1][j+1];
            }
        }
        
        if(i+1<r){
            count+=board[i+1][j];
            
            if(j-1>=0){
                count+=board[i+1][j-1];
            }
            if(j+1<c){
                count+=board[i+1][j+1];
            }
        }
        
        if(j-1>=0){
            count+=board[i][j-1];
        }
        if(j+1<c){
            count+=board[i][j+1];
        }
        
        return count;
    }
}
