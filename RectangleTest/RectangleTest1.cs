using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kamalpreetkaur_8806104_Assignment2;
using NUnit.Framework;
namespace RectangleTest
{
    public class ReactangleTest
    {
        [TestFixture]

        public class RectangleTest1
        {
            // test cases for GetLength method

            [Test]
            public void GetLength_length5_width3_output5()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(5, 3);
                int expected = 5;

                // Act
                int actual = rectangle.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetLength_length2_width2_output2()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(2, 2);
                int expected = 2;

                // Act
                int actual = rectangle.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetLength_length3_width3_output3()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(3, 3);
                int expected = 3;

                // Act
                int actual = rectangle.GetLength();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // test cases for SetLength method

            [Test]
            public void SetLength_length7_output7()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 7;

                // Act
                int actual = rectangle.SetLength(7);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void SetLength_length5_output5()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 5;

                // Act
                int actual = rectangle.SetLength(5);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void SetLength_Value1()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 1;

                // Act
                int actual = rectangle.SetLength(1);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // test cases for GetWidth method

            [Test]
            public void GetWidth_width2_output2()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(4, 2);
                int expected = 2;

                // Act
                int actual = rectangle.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetWidth_width9_output9()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(4, 9);
                int expected = 9;

                // Act
                int actual = rectangle.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetWidth_width34_output34()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(4, 34);
                int expected = 34;

                // Act
                int actual = rectangle.GetWidth();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // test cases for SetWidth method

            [Test]
            public void SetWidth_width1_output1()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 1;

                // Act
                int actual = rectangle.SetWidth(1);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void SetWidth_width22_output22()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 22;

                // Act
                int actual = rectangle.SetWidth(22);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void SetWidth_width12_output12()
            {
                // Arrange
                Rectangle rectangle = new Rectangle();
                int expected = 12;

                // Act
                int actual = rectangle.SetWidth(12);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // test cases for GetPerimeter method

            [Test]
            public void GetPerimeter_length2_width3_output10()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(2, 3);
                int expected = 10;

                // Act
                int actual = rectangle.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetPerimeter_length1_width2_output6()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(1, 2);
                int expected = 6;

                // Act
                int actual = rectangle.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetPerimeter_length10_width2_output24()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(10, 2);
                int expected = 24;

                // Act
                int actual = rectangle.GetPerimeter();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            // test cases for GetArea method

            [Test]
            public void GetArea_length5_width5_output25()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(5, 5);
                int expected = 25;

                // Act
                int actual = rectangle.GetArea();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetArea_length2_width5_output10()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(2, 5);
                int expected = 10;

                // Act
                int actual = rectangle.GetArea();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetArea_length6_width3_output10()
            {
                // Arrange
                Rectangle rectangle = new Rectangle(6, 3);
                int expected = 18;

                // Act
                int actual = rectangle.GetArea();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
