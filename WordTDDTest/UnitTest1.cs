using WordTDD;

namespace WordTDDTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPalindrome()
        {
            string testWord = "ni talar bra latin";
            bool expected = true;


            Worder myWorder = new Worder(testWord);

            bool actual = myWorder.IsPalindrome();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEmpty()
        {
            string testWord = "";
            bool expected = true;


            Worder myWorder = new Worder(testWord);

            bool actual = myWorder.IsEmpty();

            Assert.AreEqual(expected, actual);

        }

    }
}