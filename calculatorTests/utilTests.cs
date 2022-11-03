using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Tests
{
     /* 
     тесты натакие операции как 
     сложения 
     умножения 
     вычитания 
     и деления 
     */
    [TestClass()]
    public class utilTests
    {
        [TestMethod()]
        public void Compute_Add()
        {
            //arrange
            int x = 10;
            int y = 40;
            int exp = 50;

            //act
            calculator calc = new calculator();
            int actual = calc.Add(x,y);

            //assert
            Assert.AreEqual(exp, actual);
        }

        [TestMethod()]
        public void Compute_Sub()
        {
            //arrange
            int x = 10;
            int y = 40;
            int exp = -30;

            //act
            calculator calc = new calculator();
            int actual = calc.Sub(x, y);

            //assert
            Assert.AreEqual(exp, actual);
        }

        [TestMethod()]
        public void Compute_Mul()
        {
            //arrange
            int x = 10;
            int y = 40;
            int exp = 400;

            //act
            calculator calc = new calculator();
            int actual = calc.Mul(x, y);

            //assert
            Assert.AreEqual(exp, actual);
        }
        [TestMethod()]
        public void Compute_Div()
        {
            //arrange
            int x = 10;
            int y = 40;
            int exp = 0.25;

            //act
            calculator calc = new calculator();
            int actual = calc.Div(x, y);

            //assert
            Assert.AreEqual(exp, actual);
        }
    }
}