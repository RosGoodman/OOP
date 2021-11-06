using NUnit.Framework;
using OOP_Basic.Lesson5;

namespace Test.NUnit.RatioalNumbers
{
    [TestFixture]
    public class Tests
    {
        //преобразуемые в целое
        private RationalNumbers _Numb1;
        private RationalNumbers _Numb2;

        ////не преобразуемые в целое
        private RationalNumbers _Numb3;
        private RationalNumbers _Numb4;
        private RationalNumbers _Numb5;

        private int _NumbInt;
        private float _NumbFloat;
        private decimal _NumbDecimal;

        [SetUp]
        public void Setup()
        {
            //преобразуемые в целое
            _Numb1 = new RationalNumbers(120, 5);
            _Numb2 = new RationalNumbers(30, 6);

            ////не преобразуемые в целое
            _Numb3 = new RationalNumbers(123, 5);
            _Numb4 = new RationalNumbers(123, 5);
            _Numb5 = new RationalNumbers(123, 2);

            _NumbInt = 24;
            _NumbFloat = 24.6f;
            _NumbDecimal = 24.6m;
        }

        #region Tests ==

        [Test]
        public void Test_Equality_RatNumbAndRatNumb()
        {
            //act
            bool equal1 = _Numb3 == _Numb4;
            bool equal2 = _Numb3 == _Numb5;

            //assert
            Assert.IsTrue(equal1, "Должны быть равны.");
            Assert.IsFalse(equal2, "Должны быть неравны.");
        }

        [Test]
        public void Test_Equality_RatNumbAndInt()
        {
            //act
            bool equal1 = _Numb1 == _NumbInt;
            bool equal2 = _Numb3 == _NumbInt;

            //assert
            Assert.IsTrue(equal1, "Должны быть равны.");
            Assert.IsFalse(equal2, "Должны быть неравны.");
        }

        [Test]
        public void Test_Equality_RatNumbAndFloat()
        {
            //act
            bool equal1 = _Numb3 == _NumbFloat;
            bool equal2 = _Numb1 == _NumbFloat;

            //assert
            Assert.IsTrue(equal1, "Должны быть равны.");
            Assert.IsFalse(equal2, "Должны быть неравны.");
        }

        [Test]
        public void Test_Equality_RatNumbAndDecimal()
        {
            //act
            bool equal1 = _Numb3 == _NumbDecimal;
            bool equal2 = _Numb1 == _NumbDecimal;

            //assert
            Assert.IsTrue(equal1, "Должны быть равны.");
            Assert.IsFalse(equal2, "Должны быть неравны.");
        }

        #endregion

        #region Tests !=

        [Test]
        public void Test_NotEquality_RatNumbAndRatNumb()
        {
            //act
            bool equal1 = _Numb3 != _Numb4;
            bool equal2 = _Numb3 != _Numb5;

            //assert
            Assert.IsFalse(equal1, "Должны быть равны.");
            Assert.IsTrue(equal2, "Должны быть неравны.");
        }

        [Test]
        public void Test_NotEquality_RatNumbAndInt()
        {
            //act
            bool equal1 = _Numb1 != _NumbInt;
            bool equal2 = _Numb3 != _NumbInt;
            bool equal3 = _Numb2 != 30;

            //assert
            Assert.IsFalse(equal1, "Должны быть равны.");
            Assert.IsTrue(equal2, "Должны быть неравны.");
            Assert.IsTrue(equal3, "Должны быть неравны.");
        }

        [Test]
        public void Test_NotEquality_RatNumbAndFloat()
        {
            //act
            bool equal1 = _Numb3 != _NumbFloat;
            bool equal2 = _Numb1 != _NumbFloat;

            //assert
            Assert.IsFalse(equal1, "Должны быть равны.");
            Assert.IsTrue(equal2, "Должны быть неравны.");
        }

        [Test]
        public void Test_NotEquality_RatNumbAndDecimal()
        {
            //act
            bool equal1 = _Numb3 != _NumbDecimal;
            bool equal2 = _Numb1 != _NumbDecimal;

            //assert
            Assert.IsFalse(equal1, "Должны быть неравны.");
            Assert.IsTrue(equal2, "Должны быть равны.");
        }

        #endregion
    }
}