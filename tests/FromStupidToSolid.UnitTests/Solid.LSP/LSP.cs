using FromStupidToSolid.Solid.LSP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FromStupidToSolid.UnitTests.Solid.LSP
{
    [TestClass]
    public class LSP
    {
        [TestMethod]
        public void Square_SetHeight_HeightAndWidthAreEqual()
        {
            Square square = _createSquare();

            Assert.AreEqual(100, square.GetArea());
        }

        [TestMethod]
        public void Rectangle_SetHeightTo14AndWidthWithTo10_HeightIs14AndWidthIs10()
        {
            var rectangle = _createRectangle();

            Assert.AreEqual(140, rectangle.GetArea());
        }

        [TestMethod]
        public void SubstituteFormBaseWithSquare_Success()
        {
            // Simply "replace" a "FormBase" to another "FormBase"
            Square square = _createSquare();
            FormBase formBaseSquare = square;
            Assert.AreEqual(square.GetArea(), formBaseSquare.GetArea());
        }

        [TestMethod]
        public void SubstituteFormBaseWithRectangle_Success()
        {
            // Simply "replace" a "FormBase" to another "FormBase"
            Rectangle rectangle = _createRectangle();
            FormBase formBaseSquare = rectangle;
            Assert.AreEqual(rectangle.GetArea(), formBaseSquare.GetArea());
        }

        private readonly Func<Square> _createSquare = new Func<Square>(() =>
        {
            var square = new Square();
            square.Side = 10;
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