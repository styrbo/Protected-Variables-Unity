using NUnit.Framework;
using Sarteck.ProtectedVariables;
using Sarteck.ProtectedVariables.Sarteck.ProtectedVariables;
using Sarteck.ProtectedVariables.Sarteck.ProtectedVariables.Sarteck.ProtectedVariables;

public class ValuesEquality
{
    [Test]
    public static void Int32()
    {
        var value = 100;
        IntProtected protectedValue = value;
        int result = protectedValue.Value;

        Assert.AreEqual(value, result);
    }
    
    [Test]
    public static void UInt32()
    {
        uint value = 100;
        UIntProtected protectedValue = value;
        uint result = protectedValue.Value;

        Assert.AreEqual(value, result);
    }
    
    [Test]
    public static void Int64()
    {
        long value = 100;
        LongProtected protectedValue = value;
        long result = protectedValue.Value;

        Assert.AreEqual(value, result);
    }
    
    [Test]
    public static void UInt64()
    {
        ulong value = 100;
        ULongProtected protectedValue = value;
        ulong result = protectedValue.Value;

        Assert.AreEqual(value, result);
    }

    [Test] 
    public static void Single()
    {
        float value = 100.1f;
        FloatProtected protectedValue = value;
        float result = protectedValue.Value;

        Assert.AreEqual(value, result);
    }
    
    [Test] 
    public static void String()
    {
        string value = "i love my mom so much";
        StringProtected protectedValue = value;
        string result = protectedValue.Value;

        Assert.AreEqual(value, result);
    }
}
