using FromStupidToSolid.Stupid.LSP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FromStupidToSolid.UnitTests.Stupid.LSP
{
    [TestClass]
    public class LSP
    {
        [TestMethod]
        public void Square_SetHeight_HeightAndWidthAreEqual()
        {
            Square square = new Square { Height = 10 };

            Assert.AreEqual(10, square.Height);
            Assert.AreEqual(square.Height, square.Width);

            Assert.AreEqual(100, square.GetArea());
        }

        [TestMethod]
        public void Rectangle_HeightIsSetTo14AndWidthTo10_GetAreaIs140()
        {
            var rectangle = new Rectangle
            {
                Height = 10,
                Width = 14
            };

            Assert.AreEqual(140, rectangle.GetArea());
        }

        [TestMethod]
        public void Square_SetHeightTo14AndWidthWithTo10_GetAreaIs140()
        {
            // This method is a copy/paste of the "Rectangle_HeightIsSetTo14AndWidthTo10_GetAreaIs140" method
            // Simply "replace" Rectangle with Square
            var rectangle = new Square // new Rectangle
            {
                Height = 10,
                Width = 14
            };
            Assert.AreEqual(140, rectangle.GetArea()); // SHOULD FAIL!
        }
    }
}