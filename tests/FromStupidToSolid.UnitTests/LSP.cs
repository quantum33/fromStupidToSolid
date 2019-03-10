using FromStupidToSolid.Stupid.LSP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FromStupidToSolid.UnitTests
{
    [TestClass]
    public class LSP
    {
        [TestMethod]
        public void Square_SetHeight_HeightAndWidthAreEqual()
        {
            Square square = _createSquare();

            Assert.AreEqual(10, square.Height);
            Assert.AreEqual(square.Height, square.Width);

            Assert.AreEqual(100, square.GetArea());
        }

        [TestMethod]
        public void Rectangle_SetHeightTo14AndWidthWithTo10_HeightIs14AndWidthIs10()
        {
            Rectangle rectangle = _createRectangle();

            Assert.AreEqual(140, rectangle.GetArea());
        }

        [TestMethod]
        public void SubstituteRectangleWithSquare_Success()
        {
            // Simply "replace" Rectangle from the "Rectangle_SetHeightTo14AndWidthWithTo10_HeightIs14AndWidthIs10" method
            // and see what's happening
            Rectangle rectangle = _createSquare();
            Assert.AreEqual(140, rectangle.GetArea()); // BREAK!!!
        }

        private readonly Func<Square> _createSquare = new Func<Square>(() =>
        {
            var square = new Square();
            square.Height = 10;
            return square;
        });

        private readonly Func<Rectangle> _createRectangle = new Func<Rectangle>(() =>
        {
            var rectangle = new Rectangle();
            rectangle.Height = 10;
            rectangle.Width = 14;
            return rectangle;
        });
    }
}