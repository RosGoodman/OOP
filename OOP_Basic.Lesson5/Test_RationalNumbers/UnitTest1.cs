using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Basic.Lesson5;

namespace Test_RationalNumbers
{
    [TestClass]
    public class Tests
    {
        ////преобразуемые в целое
        //private RationalNumbers _Numb1 = new RationalNumbers(120, 5);
        //private RationalNumbers _Numb2 = new RationalNumbers(30, 6);

        //////не преобразуемые в целое
        ////private RationalNumbers _Numb3 = new RationalNumbers(123, 5);
        ////private RationalNumbers _Numb4 = new RationalNumbers(123, 5);
        ////private RationalNumbers _Numb5 = new RationalNumbers(123, 2);

        //private int _NumbInt = 10;
        //private float _NumbFloat = 12.123f;
        //private decimal _NumbDecimal = 123.423m;

        [TestMethod]
        public void Test_Equality_RatNumbAndRatNumb()
        {
            //arrange
            RationalNumbers _Numb3 = new RationalNumbers(123, 5);
            RationalNumbers _Numb4 = new RationalNumbers(123, 5);
            RationalNumbers _Numb5 = new RationalNumbers(123, 2);

            //act
            bool equal1 = _Numb3 == _Numb4;
            bool equal2 = _Numb3 == _Numb5;

            //assert
            Assert.AreEqual(true, equal1, "ƒолжны быть равны.");
            Assert.AreEqual(false, equal2, "ƒолжны быть неравны.");
        }
    }
}