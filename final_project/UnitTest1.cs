using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace final_v4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAss_add_BirthYear()
        {
            //arrange
            Ass ass;
            int expected = 1976;
            //act
            ass = new Ass("ass_Bill", 1976, "xxx", 1.33);

            int result = ass.Birth_Year;
            //assert
            Assert.AreEqual(expected, result);
        }

    }
}
