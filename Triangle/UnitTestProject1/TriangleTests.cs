using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace UnitTestProject1
{
    [TestClass]
    public class Ttriangle_Tests
    {
        Triangle.Triangle triangle = new Triangle.Triangle();
        [TestMethod]
        public void A_Is_Negative()
        {
            Assert.IsFalse(triangle.CheckIsPossibleToCreate(-4,6,7));
        }
        [TestMethod]
        public void B_Is_Negative()
        {
            Assert.IsFalse(triangle.CheckIsPossibleToCreate(4, -6, 7));
        }
        [TestMethod]
        public void C_Is_Negative()
        {
            Assert.IsFalse(triangle.CheckIsPossibleToCreate(4, 6, -7));
        }
        [TestMethod]
        public void A_Is_less()
        {
            Assert.IsFalse(triangle.CheckIsPossibleToCreate(8, 16, 33));
        }
        [TestMethod]
        public void B_Is_less()
        {
            Assert.IsFalse(triangle.CheckIsPossibleToCreate(16, 8, 33));
        }
        [TestMethod]
        public void C_Is_less()
        {
            Assert.IsFalse(triangle.CheckIsPossibleToCreate(16, 33, 8));
        }
        [TestMethod]
        public void A_Is_null()
        {
            Assert.IsFalse(triangle.CheckIsPossibleToCreate(0, 33, 8));
        }
        [TestMethod]
        public void B_Is_null()
        {
            Assert.IsFalse(triangle.CheckIsPossibleToCreate(16, 0, 8));
        }
        [TestMethod]
        public void C_Is_null()
        {
            Assert.IsFalse(triangle.CheckIsPossibleToCreate(16, 8, 0));
        }
        [TestMethod]
        public void Egyptian_True()
        {
            Assert.IsTrue(triangle.CheckIsPossibleToCreate(3, 4, 5));
        }
    }
}
