global using NUnit.Framework;
namespace First.Test;


public class Tests
{
    
    [SetUp]
    public void Setup()
    {

    }


    [Test]
    [TestCase(9, 9)]
    [TestCase(4, 4)]
    [TestCase(8, 8)]
    [TestCase(1, 1)]
    [TestCase(5, 5)]
    [TestCase(8, 8)]
    [TestCase(64, 64)]
    [TestCase(10, 10)]
    [TestCase(27, 72)]
    [TestCase(27, 72)]
    [TestCase(17, 71)]
    [TestCase(97, 97)]
    [TestCase(193, 931)]
    [TestCase(483, 843)]
    [TestCase(762, 762)]
    [TestCase(7416, 7641)]
    [TestCase(8530, 8530)]
    [TestCase(39035, 95330)]
    [TestCase(75626, 76652)]
    [TestCase(90783, 98730)]
    public static void FirstProgram_MaxIntegerByDigitsNum_ReturnInt(int in_num, int out_result)
    {
        int result = FirstProgram.MaxIntegerByDigitsNum(in_num);
        Assert.That(out_result, Is.EqualTo(result));
    }
}
