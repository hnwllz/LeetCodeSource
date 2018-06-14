public class Solution {
    public int Reverse(int x) {
        
        if(x ==  -Math.Pow(2,31)){
            return 0;
        }
        
        int i = 1;
        if(x<0){
            i = -1;
        }
        string str = ReverseString(Math.Abs(x).ToString());
        long result = long.Parse(str) * i;
        if(result > Math.Pow(2,31)-1 || result < -Math.Pow(2,31)){
            return 0;
        }
        
        return (int)result;
    }
    
    private string ReverseString(string s){
        if (s.Length == 0 || s.Length == 1) return s;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = s.Length-1; i >=0; i--)
            {
                strBuilder.Append(s[i]);
            }
            return strBuilder.ToString();
    }
}
