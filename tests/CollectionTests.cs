
using Collections;
using System.ComponentModel.DataAnnotations;

namespace tests
{
    public class CollectionTests


    {

        [Test]
        public void Test_Collection_EmptyConstructor()
        {

            //Arrange and Act       
            var coll = new Collection<int>();


            //Assert
            Assert.AreEqual(coll.ToString(), "[]");
        }

        [Test]
        public void Test_Collection_ConstructorSingleItem() { 
        
            var coll = new Collection<int>(5);

            var actual = coll.ToString();
            var expected = "[5]";

            //Assert
            //Assert.AreEqual(coll.ToString(), "[5]");

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems() { 
            
            //Arrange
            var coll = new Collection<int>(1, 2, 3);
        
            //Act
            var actual = coll.ToString();
            var expected = "[1, 2, 3]";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Collection_Capacity() {

            //Arrange
            var coll = new Collection<int>(5 , 6);

            //Act
            Assert.That(coll.Capacity, Is.GreaterThan(coll.Count), "Check for Capacity: ");

        }

        [Test]
        public void Test_Collection_Count()
        {

            //Arrange
            var coll = new Collection<int>(5, 6);

            //Act
            Assert.AreEqual(coll.Count, 2, "Check for Count: ");

        }

        [Test]
        public void Test_Collection_Add() {

            //Arrange
            var coll = new Collection<string>("Petya, Stefan");

            coll.Add("Poly");

            //Assert
            Assert.AreEqual(coll.ToString(), "[Petya, Stefan, Poly]");

            Console.WriteLine(coll.ToString());
        
        }







    }
}