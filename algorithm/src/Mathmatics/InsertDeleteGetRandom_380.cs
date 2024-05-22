namespace LeetCode;

// TODO: come back later
public class RandomizedSet {
    HashSet<int> set;
    public RandomizedSet() {
        set = new HashSet<int>();
    }
    
    public bool Insert(int val) => set.Add(val);
    
    public bool Remove(int val) => set.Remove(val);
    
    public int GetRandom() {
        return set.FirstOrDefault();
    }
}