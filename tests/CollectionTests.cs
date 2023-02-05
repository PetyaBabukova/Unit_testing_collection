
using Collections;


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

    }
}