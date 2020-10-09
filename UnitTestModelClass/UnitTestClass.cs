using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelClass;

namespace UnitTestModelClass
{
    [TestClass]
    public class UnitTestClass
    {
        FanOutput fanOutput = new FanOutput();

        [TestMethod]
        public void TestNameGreaterThanCharacters()
        {
            //ARRANGE
            try
            {
                //ACT
                fanOutput.Name = "H";
                Assert.Fail();
            }
            catch (Exception e)
            {
                //ASSERT
                Assert.AreEqual("Name length can't less than two characters", e.Message);
            }
        }

        [TestMethod]
        public void TestTempCantBeLessThanFifteen()
        {
            //ARRANGE
            try
            {
                fanOutput.Temp = 14;
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual("The temperature cant be less than 15 or greater than 25", e.Message);
            }
        }

        [TestMethod]
        public void TestTempCantBeGreaterThanTwentyfive()
        {
            //ARRANGE
            try
            {
                //ACT
                fanOutput.Temp = 26;
                Assert.Fail();
            }
            catch (Exception e)
            {
                //ASSERT
                Assert.AreEqual("The temperature cant be less than 15 or greater than 25", e.Message);
            }
        }

        [TestMethod]
        public void MoistureCantBeLessThanThirty()
        {
            //ARRANGE
            try
            {
                //ACT
                fanOutput.Moisture = 29;
                Assert.Fail();
            }
            catch (Exception e)
            {
                //ASSERT
                Assert.AreEqual("Moisture not correct", e.Message);
            }
        }

        [TestMethod]
        public void MoistureCantBeGreaterThanEighty()
        {
            //ARRANGE
            try
            {
                //ACT
                fanOutput.Moisture = 81;
                Assert.Fail();
            }
            catch (Exception e)
            {
                //ASSERT
                Assert.AreEqual("Moisture not correct", e.Message);
            }
        }

        [TestMethod]
        public void TestOutPutOfName()
        {
            try
            {
                fanOutput.Name = "FanOne";
                Assert.AreEqual("FanOne", fanOutput.Name);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestOutPutOfTemp()
        {
            try
            {
                fanOutput.Temp = 20;
                Assert.AreEqual(20, fanOutput.Temp);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestOuputOfMoisture()
        {
            try
            {
                fanOutput.Moisture = 45;
                Assert.AreEqual(45, fanOutput.Moisture);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestOfOutPutOfId()
        {
            try
            {
                fanOutput.Id = 1;
                Assert.AreEqual(1, fanOutput.Id);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

    }
}
