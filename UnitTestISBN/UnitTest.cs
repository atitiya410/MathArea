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
            

            //Act
            var result = triange.GetArea();
            int resultAreaTriangle = 10;
            //Assert
            Assert.AreEqual(resultAreaTriangle, result);
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
            
            //Act
            var result = triange.GetPerimetor();
            int resultPerimetorTriangle = 12;
            //Assert
            Assert.AreEqual(resultPerimetorTriangle, result);
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

            
            //Act
            var result = rectangle.GetArea();
            int resultAreaRectangle = 25;
            //Assert
            Assert.AreEqual(resultAreaRectangle, result);
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
  
            //Act
            var result = rectangle.GetPerimetor();
            int resultPerimetorRectangle = 32;
            //Assert
            Assert.AreEqual(resultPerimetorRectangle, result);
        }


        // ############################ 5.GetAreaSquare ############################
        // 
        [TestMethod]  // ด้าน*ด้าน(Height * Wigth;)   ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaSquare_WidthTenMultiplyHeightTen_Onehundred()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            int math = 10;
            Rectangle rectangle = new Square(math);

            
            //Act
            var result = rectangle.GetArea();
            int resultAreaSquare = 100;
            //Assert
            Assert.AreEqual(resultAreaSquare, result);
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

            
            //Act
            var result = rectangle.GetPerimetor();
            int resulPerimetorSquaret = 12;
            //Assert
            Assert.AreEqual(resulPerimetorSquaret, result);
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
        
            //Act
            var result = ellipse.GetArea();
            double resultAreaEllipse = 94.2;
            //Assert
            Assert.AreEqual(resultAreaEllipse, Math.Round(result,1));
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
        
            //Act
            var result = ellipse.GetPerimetor();
            double resultPerimetorEllipse = 12.6 ;
            //Assert
            Assert.AreEqual(resultPerimetorEllipse, Math.Round(result,1));
        }


        // ############################ 9.GetAreaCircle ############################
        // 
        [TestMethod]  //3.14 * Redius * Redius;  ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void GetAreaCircle_ThreePointfourteenMultiplyFour_FiftyPointTwentyfour()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            
            int math = 4;
            Circle circle = new Circle(math);

            //Act
            var result = circle.GetArea();
            double resultAreaCircle = 50.2;
            //Assert
            Assert.AreEqual(resultAreaCircle, Math.Round(result,1));
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

            //Act
            var result = circle.GetPerimetor();
            double resultPerimetorCircle = 18.8;
            //Assert
            Assert.AreEqual(resultPerimetorCircle, Math.Round(result,1));
        }
    }
}
