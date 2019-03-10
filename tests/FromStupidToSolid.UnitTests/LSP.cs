using Microsoft.VisualStudio.TestTools.UnitTesting;
using FromStupidToSolid;
using System;

namespace FromStupidToSolid.UnitTests
{
    [TestClass]
    public class LSP
    {
        [TestMethod]
        public void Square_SetHeight_HeightAndWidthAreEqual()
        {
            var square = new Square();
            square.SetHeight(14);

            Assert.AreEqual(14, square.GetHeight());
            Assert.AreEqual(square.GetHeight(), square.GetWidth());
        }

        [TestMethod]
        public void Rectangle_SetHeightTo14AndWidthWithTo10_HeightIs14AndWidthIs10()
        {
            var rectangle = new Rectangle();
            rectangle.SetHeight(14);
            rectangle.SetWidth(10);

            Assert.AreEqual(14, rectangle.GetHeight());
            Assert.AreEqual(10, rectangle.GetWidth());
        }

        [TestMethod]
        public void SubstituteRectangleWithSquare_Success()
        {
            // Simply "replace" Rectangle from the "Rectangle_SetHeightTo14AndWidthWithTo10_HeightIs14AndWidthIs10" method
            // and see what's happening
            var rectangle = new Square();
            rectangle.SetHeight(14);
            rectangle.SetWidth(10);

            Assert.AreEqual(14, rectangle.GetHeight()); // BREAK!
            Assert.AreEqual(10, rectangle.GetWidth());
        }
    }
}