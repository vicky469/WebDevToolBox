namespace LeetCode.Net;

public class LearnDataTypes: TestBase
{
    private static void AnonymousType()
    {
        // Q: What are anonymous types used for in C#?
        // 1. They are typically are used in the select clause of a query expression
        //    to return a subset of the properties from each object in the source sequence.
        var products = new List<Product>
        {
            new Product() { Color = "blue", Price = 3.2M },
            new Product() { Color = "blue", Price = 1.2M }
        };
        Console.WriteLine("Order by price asc");
        var productQuery =
            from prod in products
            orderby prod.Price ascending
            select new { prod.Color, prod.Price };
        
        foreach (var v in productQuery)
        {
            Console.WriteLine("Color={0}, Price={1}", v.Color, v.Price);
        }
        Console.WriteLine("====================================");
        // Q: How to create one?
        // 2. Anonymous Types are created using the new operator and an object initializer.
        var apple = new { Item = "apples", Price = 1.35 };
        var onSale = apple with { Price = 0.79 };
        Console.WriteLine(apple);
        Console.WriteLine(onSale);
        Console.WriteLine("====================================");
        
        // 2.2: It is also possible to define a field by object of another type: class, struct or even another anonymous type.
        var product = new Product();
        var bonus = new { note = "You won!" };
        var shipment = new { address = "Nowhere St.", product };
        var shipmentWithBonus = new { address = "Somewhere St.", product, bonus };
        
        // Q: How are anonymous types different from other types in C#?
        // 3. Anonymous types are class types that derive directly from object and cannot be cast to any type except object.
        // They have a generated name that is not accessible in the application code.

    }
    
    private static (int primitiveInt, int[] array) PrimitiveAndReferenceTypes_ModifyInSameMethod(int primitiveInt, int[] array)
    {
        // Copy the primitive value to another variable
        int primitiveInt2 = primitiveInt;
        primitiveInt2 = 20; // Changing primitiveInt2 doesn't affect primitiveInt
        
        // Copy the reference value to another variable
        int[] array2 = array; 
        array2[0] = 10; // Changing array2 also changes array

        return (primitiveInt, array);
    }
    
    private static (int primitiveInt, int[] array) PrimitiveAndReferenceTypes_ModifyInDifferentMethods(int primitiveInt, int[] array)
    {
        ModifyPrimitive(primitiveInt);
        ModifyArray(array);
        return (primitiveInt,array);
    }
    
    static void ModifyPrimitive(int value)
    {
        value = 100; // Modifying the parameter doesn't affect the original variable
    }
    
    static void ModifyArray(int[] array)
    {
        array[0] = 10; // Modifying the array element affects the original array
    }
    
    [Theory]
    [InlineData]
    private void Test()
    {
        AnonymousType();
    }
    
    
    [Theory]
    [InlineData(10, new int[]{1,2,3}, 10, new int[]{10,2,3})]
    private void Test_SameMethod(int primitiveInt, int[]  array, int expectedInt, int[] expectedArray)
    {
        var result = PrimitiveAndReferenceTypes_ModifyInSameMethod(primitiveInt, array);
        Assert.Equal(expectedInt, result.primitiveInt);
        Assert.Equal(expectedArray, result.array);
    }
    
    [Theory]
    [InlineData(10, new int[]{1,2,3}, 10, new int[]{10,2,3})]
    private void Test_ModifyInAnotherMethod(int primitiveInt, int[]  array, int expectedInt, int[] expectedArray)
    {
        var result = PrimitiveAndReferenceTypes_ModifyInDifferentMethods(primitiveInt, array);
        Assert.Equal(expectedInt, result.primitiveInt);
        Assert.Equal(expectedArray, result.array);
    }

    public LearnDataTypes(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
    {
    }
}

internal class Product
{
    public string Color { get; set; }
    public decimal Price { get; set; }
}