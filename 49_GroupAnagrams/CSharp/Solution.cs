/**
暴力解法
遍历字符串数组中的所有数组，逐个向后进行比对是否是字母异构词

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> result = new List<IList<string>>();
        int[] a=new int[strs.Length];
        
        for(int i=0;i<strs.Length;i++){
            if(a[i]==0){
                List<string> lst = new List<string>();
                lst.Add(strs[i]);
                for(int j=i+1;j<strs.Length;j++){
                    if(a[j]==0&&IsAnagrams(strs[i],strs[j])){
                        lst.Add(strs[j]);
                        a[j]=1;
                    }
                }
                
                a[i]=1;
                result.Add(lst);
            }
        }
        
        return result;
    }
    
    private bool IsAnagrams(string s,string t){
         if(s==null || t==null || s.Length != t.Length){
            return false;
        }
        
        int[] sCount = new int[26];
        int[] tCount = new int[26];
        
        for(int i=0;i<s.Length;i++){
            sCount[s[i]-'a']++;
            tCount[t[i]-'a']++;
        }
        
        for(int i= 0 ;i<sCount.Length;i++){
            if(sCount[i] != tCount[i]){
                return false;
            }
        }
        
        return true;
    }
}**/
/**
第二种方法，比较实用的方式
将字母异构词通过重新排序后计算其哈希值，如果哈希值相同则表示是同一分组，可以借助Dictionary或hashmap来完成
**/
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> result = new List<IList<string>>();
        Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();
        for(int i=0;i<strs.Length;i++){
            char[] chars = strs[i].ToArray();
            Array.Sort(chars);
            string sortedStr = new string(chars);
            if(!dic.ContainsKey(sortedStr)){
                dic.Add(sortedStr,new List<string>());
            }
            
            dic[sortedStr].Add(strs[i]);
        }
        
        foreach(string key in dic.Keys){
            result.Add(dic[key]);
        }
        
        return result;
    }
}
