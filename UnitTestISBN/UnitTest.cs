using MathGeometry.ClassMathArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestISBN
{
    [TestClass]
    public class UnitTest
    {
        // ############################ 1.GetAreaTriangle ############################
        // 
        [TestMethod]  //ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaTriangle_WidthFourHeightFive_TEN()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Triangle triange = new Triangle(4, 5);
           
            //Act
            var result = triange.GetArea();

            //Assert
            Assert.AreEqual(10, result);
        }

        // ############################ 2.GetPerimetorTriangle ############################
        // 
        [TestMethod]  //ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetPerimetorTriangle_SqrtWidthThreeHeightFour_Twelve()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Triangle triange = new Triangle(3, 4);

            //Act
            var result = triange.GetPerimetor();

            //Assert
            Assert.AreEqual(12, result);
        }


        // ############################ 3.GetAreaRectangle ############################
        // 
        [TestMethod]  //Height * Wigth - สี่เหลี่ยมผืนผ้า ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaRectangle_WidthFiveMultiplyHeightFive_Twentyfive()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Rectangle rectangle = new Rectangle(5, 5);

            //Act
            var result = rectangle.GetArea();

            //Assert
            Assert.AreEqual(25, result);
        }

        // ############################ 4.GetPerimetorRectangle ############################
        // 
        [TestMethod]  //2*Height + 2*Wigth - สามเหลี่ยม ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetPerimetorRectangle_TwoMultiplyWidthTenAddTwoMultiplyHeightSix_Thirtytwo() 
            //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Rectangle rectangle = new Rectangle(10, 6);

            //Act
            var result = rectangle.GetPerimetor();

            //Assert
            Assert.AreEqual(32, result);
        }


        // ############################ 5.GetAreaSquare ############################
        // 
        [TestMethod]  // ด้าน*ด้าน(Height * Wigth;)   ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaSquare_WidthTenMultiplyHeightTen_Onehundred()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Rectangle rectangle = new Square(10);

            //Act
            var result = rectangle.GetArea();

            //Assert
            Assert.AreEqual(100, result);
        }

        // ############################ 6.GetPerimetorSquare ############################
        // 
        [TestMethod]  //2*Height + 2*Wigth;    ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetPerimetorSquare_TwoMultiplyWidthThreeAddTwoMultiplyHeightThree_Twelve()
        //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Rectangle rectangle = new Square(3);

            //Act
            var result = rectangle.GetPerimetor();

            //Assert
            Assert.AreEqual(12, result);
        }


        // ############################ 7.GetAreaEllipse ############################
        // 
        [TestMethod]  //3.14 * RediusX*RediusY;   ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaEllipse_ThreePointfourteenMultiplyWidthFiveMultiplyHeightSix_NinetyfourPointTwo()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Ellipse ellipse = new Ellipse(5, 6);

            //Act
            var result = ellipse.GetArea();

            //Assert
            Assert.AreEqual(94.2, result);
        }

        // ############################ 8.GetPerimetorEllipse ############################
        // 
        [TestMethod]  //3.14 * (RediusX + RediusY);  ต้องมีTestก่อน ถึงจะไปทำCodeได้
         public void GetPerimetorEllipse_ThreePointfourteenMultiplyWidthTwoAddHeightTwo_TwelvePointFiftysix()
        //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Ellipse ellipse = new Ellipse(2, 2);

            //Act
            var result = ellipse.GetPerimetor();

            //Assert
            Assert.AreEqual(12.56, result);
        }


        // ############################ 9.GetAreaCircle ############################
        // 
        [TestMethod]  //3.14 * Redius * Redius;  ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaCircle_ThreePointfourteenMultiplyFour_FiftyPointTwentyfour()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Circle circle = new Circle(4);

            //Act
            var result = circle.GetArea();

            //Assert
            Assert.AreEqual(50.24, result);
        }

        // ############################ 10.GetPerimetorCircle ############################
        // 
        [TestMethod]  //2 * 3.14 * Redius;  ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetPerimetorCircle_TwoMultiplyThreePointfourteenMultiplyThree_EighteenPointEightyfour()
        //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            Circle circle = new Circle(3);

            //Act
            var result = circle.GetPerimetor();

            //Assert
            Assert.AreEqual(18.84, result);
        }
    }
}
