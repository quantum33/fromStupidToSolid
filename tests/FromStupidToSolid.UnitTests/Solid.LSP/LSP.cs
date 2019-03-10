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
            Square square = new Square { Side = 10 };

            Assert.AreEqual(100, square.GetArea());
        }

        [TestMethod]
        public void Rectangle_SetHeightTo14AndWidthWithTo10_HeightIs14AndWidthIs10()
        {
            Rectangle rectangle = new Rectangle
            {
                Height = 10,
                Width = 14
            };

            Assert.AreEqual(140, rectangle.GetArea());
        }

        [TestMethod]
        public void SubstituteFormBaseWithSquare_Success()
        {
            // Simply "replace" a "FormBase" to another "FormBase"
            Square square = new Square { Side = 10 };
            FormBase formBaseSquare = new Square { Side = 10 };

            Assert.AreEqual(square.GetArea(), formBaseSquare.GetArea());
        }

        [TestMethod]
        public void SubstituteFormBaseWithRectangle_Success()
        {
            // Simply "replace" a "FormBase" to another "FormBase"
            Rectangle rectangle = new Rectangle { Height = 10, Width = 14 };
            FormBase formBaseSquare = new Rectangle { Height = 10, Width = 14 };

            Assert.AreEqual(rectangle.GetArea(), formBaseSquare.GetArea());
        }
    }
}