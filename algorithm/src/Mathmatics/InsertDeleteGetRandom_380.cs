namespace LeetCode;

public class RandomizedSet {
    HashSet<int> set;
    private Random random;
    public RandomizedSet() {
        set = new HashSet<int>();
        random = new Random();
    }
    
    public bool Insert(int val) => set.Add(val);
    
    public bool Remove(int val) => set.Remove(val);
    
    // return the value from the random index
    public int GetRandom() => set.ElementAt(random.Next(set.Count));
    //                                      ^^ generate to get a random index
}