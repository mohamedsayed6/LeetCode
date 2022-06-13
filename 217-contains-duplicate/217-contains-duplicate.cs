public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        
        var numsValues=new Dictionary<int, int>();



foreach (var num in nums)
{
    if(numsValues.ContainsKey(num))
        numsValues[num]++;
    else
        numsValues.Add(num, 1);

}

foreach (var value in numsValues)
{
    if(value.Value>=2)
        return true;
}
        
        
       return false; 
        
        
    }
}