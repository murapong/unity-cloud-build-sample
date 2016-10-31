using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class SampleTest
{

    [Test]
    public void EditorTest()
    {
        //Arrange
        var gameObject = new GameObject();

        //Act
        //Try to rename the GameObject
        var newGameObjectName = "My game object";
        gameObject.name = newGameObjectName;

        //Assert
        //The object has a new name
        Assert.AreEqual(newGameObjectName, gameObject.name);
    }

    [Test]
    public void SumTest()
    {
        int x = 1;
        int y = 2;

        int sum = x + y;

        Assert.AreEqual(sum, 3);
    }
}
