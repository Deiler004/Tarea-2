using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CustomLinkedListTests
{
    [TestMethod]
    public void TestReverse_ListWithElements()
    {
        CustomLinkedList list = new CustomLinkedList();
        list.Add(7,12,3,45,9,28,5,34,1,77);

        list.Reverse();

        Assert.AreEqual("77,1,34,5,28,9,45,3,12,7", list.ToString());
    }

    [TestMethod]
    public void TestReverse_EmptyList()
    {
        CustomLinkedList list = new CustomLinkedList();

        Assert.ThrowsException<InvalidOperationException>(() => list.Reverse());
        Assert.AreEqual("vacia", list.ToString());
    }

    [TestMethod]
    public void TestToString_EmptyList()
    {
        CustomLinkedList list = new CustomLinkedList();

        Assert.AreEqual("vacia", list.ToString());
    }
}





[TestClass]
public class OrderedLinkedListTests
{
    [TestMethod]
    public void TestInsertInOrder_SingleElement()
    {
        OrderedLinkedList list = new OrderedLinkedList();
        list.InsertInOrder(5);
        Assert.AreEqual(5, list.GetMiddle());
    }

    [TestMethod]
    public void TestInsertInOrder_MultipleElements_OddCount()//cantidad impar de elementos
    {
        OrderedLinkedList list = new OrderedLinkedList();
        list.InsertInOrder(1, 3, 2, 5);

        Assert.AreEqual(2, list.GetMiddle());

        
    }

    [TestMethod]
    public void TestInsertInOrder_MultipleElements_EvenCount()//cantidar par de elementos
    {
        OrderedLinkedList list = new OrderedLinkedList();
        list.InsertInOrder(12, 7, 15, 3, 9, 21, 5, 8, 19, 1);

        Assert.AreEqual(21, list.GetMiddle());

        
    }

    [TestMethod]
    public void TestGetMiddle_EmptyList()
    {
        OrderedLinkedList list = new OrderedLinkedList();

        Assert.ThrowsException<InvalidOperationException>(() => list.GetMiddle());
    }
}




