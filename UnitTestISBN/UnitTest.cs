using MathGeometry.ClassMathArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestISBN
{
    [TestClass]
    class UnitTest
    {
        [TestMethod]  //ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetArea_WidthFourHeightFive_TEN()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Triangle triange = new Triangle(4, 5);
           
            //Act
            var result = triange.GetArea();
            //Assert
            Assert.AreEqual(10, result);
        }
    }
}
