using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitLibrary;

namespace UnitTestISBN

{
    [TestClass]
    public class TDDTest
    {
        [TestMethod]  //ต้องมีTestก่อน ถึงจะไปทำCodeได้
        public void FindFizzBuzzNumber_InputThree_Fizz()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 3; 
            //Act
            String result = fizzBuzz.FindFizzBuzzNumber(number); //
            //Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FindFizzBuzzNumber_InputFive_Buzz()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 5;
            //Act
            String result = fizzBuzz.FindFizzBuzzNumber(number); //
            //Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FindFizzBuzzNumber_InputNumber_Number()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 1;
            //Act
            String result = fizzBuzz.FindFizzBuzzNumber(number); //
            //Assert
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void FindFizzBuzzNumber_InputThreeAndFive_FizzBuzz()  //ชื่อฟังก์ชั่น_จะtestอะไร_ผลัพธ์ที่ได้
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 3;
            //Act
            String result = fizzBuzz.FindFizzBuzzNumber(number); //
            //Assert
            Assert.AreEqual("1", result);
        }

    }
}
