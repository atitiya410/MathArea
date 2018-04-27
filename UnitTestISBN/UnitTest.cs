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
            int width = 4;
            int height = 5;
            Triangle triange = new Triangle(width, height);
            int number = 10;

            //Act
            var result = triange.GetArea();

            //Assert
            Assert.AreEqual(number, result);
        }

        // ############################ 2.GetPerimetorTriangle ############################
        // 
        [TestMethod]  //ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetPerimetorTriangle_SqrtWidthThreeHeightFour_Twelve()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            int width = 3;
            int height = 4;
            Triangle triange = new Triangle(width, height);
            int number = 12;
            //Act
            var result = triange.GetPerimetor();

            //Assert
            Assert.AreEqual(number, result);
        }


        // ############################ 3.GetAreaRectangle ############################
        // 
        [TestMethod]  //Height * Wigth - สี่เหลี่ยมผืนผ้า ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaRectangle_WidthFiveMultiplyHeightFive_Twentyfive()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            int width = 5;
            int height = 5;
            Rectangle rectangle = new Rectangle(width, height);

            int number = 25;
            //Act
            var result = rectangle.GetArea();

            //Assert
            Assert.AreEqual(number, result);
        }

        // ############################ 4.GetPerimetorRectangle ############################
        // 
        [TestMethod]  //2*Height + 2*Wigth - สามเหลี่ยม ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetPerimetorRectangle_TwoMultiplyWidthTenAddTwoMultiplyHeightSix_Thirtytwo() 
            //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            int width = 10;
            int height = 6;
            Rectangle rectangle = new Rectangle(width, height);

            int number = 32;

            //Act
            var result = rectangle.GetPerimetor();

            //Assert
            Assert.AreEqual(number, result);
        }


        // ############################ 5.GetAreaSquare ############################
        // 
        [TestMethod]  // ด้าน*ด้าน(Height * Wigth;)   ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaSquare_WidthTenMultiplyHeightTen_Onehundred()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            int math = 10;
            Rectangle rectangle = new Square(math);

            int number = 100;
            //Act
            var result = rectangle.GetArea();

            //Assert
            Assert.AreEqual(number, result);
        }

        // ############################ 6.GetPerimetorSquare ############################
        // 
        [TestMethod]  //2*Height + 2*Wigth;    ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetPerimetorSquare_TwoMultiplyWidthThreeAddTwoMultiplyHeightThree_Twelve()
        //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            int math = 3;
            Rectangle rectangle = new Square(math);

            int number = 12;
            //Act
            var result = rectangle.GetPerimetor();

            //Assert
            Assert.AreEqual(number, result);
        }


        // ############################ 7.GetAreaEllipse ############################
        // 
        [TestMethod]  //3.14 * RediusX*RediusY;   ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaEllipse_ThreePointfourteenMultiplyWidthFiveMultiplyHeightSix_NinetyfourPointTwo()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            int width = 5;
            int height = 6;
            Ellipse ellipse = new Ellipse(width, height);

            double number = 94.2;
            //Act
            var result = ellipse.GetArea();

            //Assert
            Assert.AreEqual(number, result);
        }

        // ############################ 8.GetPerimetorEllipse ############################
        // 
        [TestMethod]  //3.14 * (RediusX + RediusY);  ต้องมีTestก่อน ถึงจะไปทำCodeได้
         public void GetPerimetorEllipse_ThreePointfourteenMultiplyWidthTwoAddHeightTwo_TwelvePointFiftysix()
        //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            int width = 2;
            int height = 2;
            Ellipse ellipse = new Ellipse(width, height);

            double number = 12.56;
            //Act
            var result = ellipse.GetPerimetor();

            //Assert
            Assert.AreEqual(number, result);
        }


        // ############################ 9.GetAreaCircle ############################
        // 
        [TestMethod]  //3.14 * Redius * Redius;  ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaCircle_ThreePointfourteenMultiplyFour_FiftyPointTwentyfour()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            
            int math = 4;
            Circle circle = new Circle(math);

            double number = 50.24;

            //Act
            var result = circle.GetArea();

            //Assert
            Assert.AreEqual(number, result);
        }

        // ############################ 10.GetPerimetorCircle ############################
        // 
        [TestMethod]  //2 * 3.14 * Redius;  ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetPerimetorCircle_TwoMultiplyThreePointfourteenMultiplyThree_EighteenPointEightyfour()
        //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            int math = 3;
            Circle circle = new Circle(math);
            double number = 18.84;

            //Act
            var result = circle.GetPerimetor();

            //Assert
            Assert.AreEqual(number, result);
        }
    }
}
