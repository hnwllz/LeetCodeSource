
/*
方法一：
这道求岛屿数量的题的本质是求矩阵中连续区域的个数，很容易想到需要用深度优先搜索DFS来解
我们用一个visited数组来存储访问过的位置
时间复杂度O(m*n),
空间复杂度：O(m*n)
方法二
同方法一，只不过不借助额外空间，直接将访问过的岛屿'1'的位置设置为0.

public class Solution {
    public int NumIslands(char[,] grid) {
        int count = 0;        
        int row = grid.GetLength(0);
        int col = grid.GetLength(1);
        bool[,] visited = new bool[row,col]; 
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
               visited[i,j]=false;
            }
        }
        
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                if('1'== grid[i,j]&&!visited[i,j]){
                   NumIslandsDFS(grid,visited,i,j);
                   count++;
                }
            }
        }
        
        return count;
    }
    
    private void NumIslandsDFS(char[,] grid,bool[,] visited,int i,int j){
        int row = grid.GetLength(0);
        int col = grid.GetLength(1);
        if(i<0||j<0||i>=row||j>=col){
            return;
        }
        
        if(grid[i,j]=='1'&&!visited[i,j]){
            visited[i,j] = true;
            
            NumIslandsDFS(grid,visited,i-1,j);
            NumIslandsDFS(grid,visited,i+1,j);
            NumIslandsDFS(grid,visited,i,j-1);
            NumIslandsDFS(grid,visited,i,j+1);
        }
    }
}*/
public class Solution {
    public int NumIslands(char[,] grid) {
        int count = 0;        
        int row = grid.GetLength(0);
        int col = grid.GetLength(1);
        
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                if('1'== grid[i,j]){
                   NumIslandsDFS(ref grid,i,j,0);
                   count++;
                }
            }
        }
        
        return count;
    }
     private void NumIslandsDFS(ref char[,] grid,int i,int j,int dir){
        int row = grid.GetLength(0);
        int col = grid.GetLength(1);
        if(i<0||j<0||i>=row||j>=col){
            return;
        }
        
        if(grid[i,j]=='1'){
            grid[i,j] = '0';
            
            if(dir!=3){
                NumIslandsDFS(ref grid,i-1,j,1);
            }
            if(dir!=1){
                NumIslandsDFS(ref grid,i+1,j,3);
            }
            if(dir!=4){
                NumIslandsDFS(ref grid,i,j-1,2);
            }
            if(dir!=2){
                NumIslandsDFS(ref grid,i,j+1,4);
            }
        }
    }
}
