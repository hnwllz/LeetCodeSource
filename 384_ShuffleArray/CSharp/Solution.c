

/**
打乱数组
这类问题类似于 扑克洗牌 的问题。
打乱数组即对数组中的元素进行重新寻找位置放置，目标位置是随机的。
步骤：
从数组的最后一个位置开始，随机寻找从0到最后位置last的上的数，然后进行交换；交换后，最后位置向前移动，重新随机选取和交换，直到最后一个元素。
PS：在这个题目中，需要注意的是Radmon这个伪随机数生成器，如果要生成不重复的数，Radom的对象要用同一个，不要在使用的时候去创建
**/
public class Solution {

    private int[] _nums;
    private  Random r;
    public Solution(int[] nums) {
        _nums = nums;
        r = new Random();
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] Reset() {
        return _nums;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] Shuffle() {
        if(this._nums==null){
            return null;
        }
        
        int count = this._nums.Length;
        int[] copy=new int[count];
        Array.Copy(this._nums, copy, count);
       
        while(count>1){             
            int i = r.Next(0,count);
            
            int tmp = copy[i];
            copy[i] = copy[count-1];
            copy[count-1]=tmp;
            
            count--;
        }
        
        return copy;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
