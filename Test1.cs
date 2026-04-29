using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleApp;

namespace RectangleTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Area_CorrectValues()
        {
            Rectangle r = new Rectangle();
            r.Init(4, 5);
            Assert.AreEqual(20, r.Area());
        }

        [TestMethod]
        public void Init_InvalidValues_DefaultSet()
        {
            Rectangle r = new Rectangle();
            r.Init(-1, 5);
            Assert.AreEqual(2, r.Area());
        }

        [TestMethod]
        public void PropertyHeight_ValidChange()
        {
            Rectangle r = new Rectangle();
            r.Init(4, 5);
            r.Height = 6;
            Assert.AreEqual(24, r.Area());
        }

        [TestMethod]
        public void PropertyHeight_InvalidChange()
        {
            Rectangle r = new Rectangle();
            r.Init(4, 5);
            r.Height = -10;
            Assert.AreEqual(4, r.Area());
        }

        [TestMethod]
        public void Add_TwoRectangles()
        {
            Rectangle r1 = new Rectangle();
            r1.Init(4, 5);

            Rectangle r2 = new Rectangle();
            r2.Init(6, 3);

            Rectangle result = Rectangle.Add(r1, r2);
            Assert.AreEqual(80, result.Area());
        }

        [TestMethod]
        public void Add_ResultNotNull()
        {
            Rectangle r1 = new Rectangle();
            r1.Init(2, 3);

            Rectangle r2 = new Rectangle();
            r2.Init(4, 5);

            Assert.IsNotNull(Rectangle.Add(r1, r2));
        }

        [TestMethod]
        public void Init_NegativeValues()
        {
            Rectangle r = new Rectangle();
            r.Init(-5, -1);
            Assert.AreEqual(2, r.Area());
        }

        [TestMethod]
        public void Area_PositiveCheck()
        {
            Rectangle r = new Rectangle();
            r.Init(3, 7);
            Assert.IsTrue(r.Area() > 0);
        }

        [TestMethod]
        public void Multiple_Add()
        {
            Rectangle r1 = new Rectangle();
            r1.Init(2, 3);

            Rectangle r2 = new Rectangle();
            r2.Init(4, 5);

            Rectangle r3 = Rectangle.Add(r1, r2);
            Rectangle r4 = Rectangle.Add(r3, r1);

            Assert.IsNotNull(r4);
        }

        [TestMethod]
        public void Height_SetZero_Invalid()
        {
            Rectangle r = new Rectangle();
            r.Init(5, 5);
            r.Height = 0;
            Assert.AreEqual(5, r.Area());
        }
    }
}