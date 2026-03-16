using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTreeIntroduction.Lib; 

[TestClass]
public class BinaryTreeTests
{
    [TestMethod]
    public void TestToString()
    {
        var tree = new BinaryTree(3);
        tree.Insert(1);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(5);

        string result = tree.ToString();
        string expected = "1, 2, 3, 4, 5";
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestSum()
    {
        var tree = new BinaryTree(3);
        tree.Insert(1);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(5);

        int result = tree.Sum();
        int expected = 15;
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestDupes()
    {
        var tree = new BinaryTree(3);
        tree.Insert(1);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(5);
        tree.Insert(3);

        bool result = tree.HasDupes();
        Assert.IsTrue(result);
    }
}
