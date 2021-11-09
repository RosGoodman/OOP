using NUnit.Framework;
using OOP_Basic.Lesson5;
using System;

namespace Test.NUnit.RationalNumbersTests
{
    [TestFixture]
    public class Tests
    {
        //������������� � �����
        private RationalNumbers _Numb1;
        private RationalNumbers _Numb2;

        ////�� ������������� � �����
        private RationalNumbers _Numb3;
        private RationalNumbers _Numb4;
        private RationalNumbers _Numb5;

        private object obj = new object();

        private int _NumbInt;
        private float _NumbFloat;
        private decimal _NumbDecimal;

        [SetUp]
        public void Setup()
        {
            //������������� � �����
            _Numb1 = new RationalNumbers(120, 5);
            _Numb2 = new RationalNumbers(30, 6);

            ////�� ������������� � �����
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
            Assert.IsTrue(equal1, "������ ���� �����.");
            Assert.IsFalse(equal2, "������ ���� �������.");
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
            Assert.IsFalse(equal1, "������ ���� �����.");
            Assert.IsTrue(equal2, "������ ���� �������.");
        }

        #endregion

        #region Tests Equals

        [Test]
        public void Test_Equals_RatNumbAndRatNumb()
        {
            //act
            bool equal1 = _Numb3.Equals(_Numb4);
            bool equal2 = _Numb3.Equals(_Numb5);

            //assert
            Assert.IsTrue(equal1, "������ ���� �����.");
            Assert.IsFalse(equal2, "������ ���� �������.");
        }

        [Test]
        public void Test_Equals_RatNumbAndInt()
        {
            //act
            bool equal1 = _Numb1.Equals(_NumbInt);
            bool equal2 = _Numb3.Equals(_NumbInt);

            //assert
            Assert.IsFalse(equal1, "������ ���� �������.");
            Assert.IsFalse(equal2, "������ ���� �������.");
        }

        [Test]
        public void Test_Equals_RatNumbAndFloat()
        {
            //act
            bool equal1 = _Numb3.Equals(_NumbFloat);
            bool equal2 = _Numb1.Equals(_NumbFloat);

            //assert
            Assert.IsFalse(equal1, "������ ���� �������.");
            Assert.IsFalse(equal2, "������ ���� �������.");
        }

        [Test]
        public void Test_Equals_RatNumbAndDecimal()
        {
            //act
            bool equal1 = _Numb3.Equals(_NumbDecimal);
            bool equal2 = _Numb1.Equals(_NumbDecimal);

            //assert
            Assert.IsFalse(equal1, "������ ���� �������.");
            Assert.IsFalse(equal2, "������ ���� �������.");
        }

        [Test]
        public void Test_Equals_RatNumbAndObject()
        {
            //act
            bool equal1 = _Numb3.Equals(obj);   //������ ������
            bool equal2 = _Numb3.Equals((object)_Numb4);    //������, ������� ����� ��������������

            //assert
            Assert.IsFalse(equal1, "������ ���� �������.");
            Assert.IsTrue(equal2, "������ ���� �����.");
        }

        #endregion

        #region Tests <>

        [Test]
        public void Test_More_RatNumbAndRatNumb()
        {
            //act
            bool equal1 = _Numb3 > _Numb4;
            bool equal2 = _Numb3 > _Numb5;
            bool equal3 = _Numb5 > _Numb3;

            //assert
            Assert.IsFalse(equal1, "������ ���� �������� �����������.");
            Assert.IsFalse(equal2, "������ ���� �������� �����������.");
            Assert.IsTrue(equal3, "������ ���� ������ �����������.");
        }

        [Test]
        public void Test_Less_RatNumbAndRatNumb()
        {
            //act
            bool equal1 = _Numb3 < _Numb4;
            bool equal2 = _Numb3 < _Numb5;
            bool equal3 = _Numb5 < _Numb3;

            //assert
            Assert.IsFalse(equal1, "������ ���� �������� �����������.");
            Assert.IsTrue(equal2, "������ ���� ������ �����������.");
            Assert.IsFalse(equal3, "������ ���� �������� �����������.");
        }

        #endregion

        #region Tests <= >=

        [Test]
        public void Test_MoreOrEqual_RatNumbAndRatNumb()
        {
            //act
            bool equal1 = _Numb3 >= _Numb4;
            bool equal2 = _Numb3 >= _Numb5;
            bool equal3 = _Numb5 >= _Numb3;

            //assert
            Assert.IsTrue(equal1, "������ ���� ������ ���������.");
            Assert.IsFalse(equal2, "������ ���� �������� ���������.");
            Assert.IsTrue(equal3, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_LessOrEqual_RatNumbAndRatNumb()
        {
            //act
            bool equal1 = _Numb3 <= _Numb4;
            bool equal2 = _Numb3 <= _Numb5;
            bool equal3 = _Numb5 <= _Numb3;

            //assert
            Assert.IsTrue(equal1, "������ ���� ������ ���������.");
            Assert.IsTrue(equal2, "������ ���� ������ ���������.");
            Assert.IsFalse(equal3, "������ ���� �������� ���������.");
        }

        #endregion

        #region Tests +-

        [Test]
        public void Test_Addition_RatNumbAndRatNumb()
        {
            //act
            RationalNumbers ansver1 = _Numb2 + _Numb2;

            //assert
            Assert.AreEqual(ansver1, new RationalNumbers(60, 6), "�������� ��������� ���������.");
        }

        [Test]
        public void Test_Substruction_RatNumbAndRatNumb()
        {
            //act
            bool ansver1 = (_Numb2 - _Numb2) == new RationalNumbers(0, 6);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_Addition_RatNumbAndInt()
        {
            //act
            bool ansver1 = _Numb2 + _NumbInt == new RationalNumbers(29, 1);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_Substruction_RatNumbAndInt()
        {
            //act
            bool ansver1 = (_Numb2 - _NumbInt) == new RationalNumbers(-19, 1);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_Addition_RatNumbAndFloat()
        {
            //act
            bool ansver1 = _Numb2 + _NumbFloat == new RationalNumbers(148, 5);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_Substruction_RatNumbAndFloat()
        {
            bool ansver1 = (_Numb2 - _NumbFloat) == new RationalNumbers(-98, 5);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_Addition_RatNumbAndDecimal()
        {
            //act
            bool ansver1 = _Numb2 + _NumbDecimal == new RationalNumbers(148, 5);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_Substruction_RatNumbAndDecimal()
        {
            //act
            bool ansver1 = (_Numb2 - _NumbDecimal) == new RationalNumbers(-98, 5);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
        }

        #endregion

        #region Tests ++ --

        [Test]
        public void Test_Increment_RatNumb()
        {
            //arrange
            RationalNumbers chekingNumb = _Numb2;
            RationalNumbers chekingNumb2 = _Numb2;

            //act
            RationalNumbers newRatinonal = chekingNumb++ + 1;
            RationalNumbers newRatinonal2 = ++chekingNumb2 + 1;

            //assert
            Assert.AreEqual(newRatinonal, new RationalNumbers(36, 6), "�������� ��������� ���������.");
            Assert.AreEqual(newRatinonal2, new RationalNumbers(42, 6), "�������� ��������� ���������.");
        }

        [Test]
        public void Test_Decrement_RatNumb()
        {
            //arrange
            RationalNumbers chekingNumb = _Numb2;
            RationalNumbers chekingNumb2 = _Numb2;

            //act
            RationalNumbers newRatinonal = chekingNumb-- + 1;
            RationalNumbers newRatinonal2 = --chekingNumb2 + 1;

            //assert
            Assert.AreEqual(newRatinonal, new RationalNumbers(36, 6), "�������� ��������� ���������.");
            Assert.AreEqual(newRatinonal2, new RationalNumbers(30, 6), "�������� ��������� ���������.");
        }

        #endregion

        #region Tests %

        [Test]
        public void Test_RemainderOfTheDivision_RatNumbByRatNumb()
        {
            //act
            RationalNumbers newRatinonal = _Numb1 % _Numb2;

            //assert
            Assert.AreEqual(newRatinonal, new RationalNumbers(4, 5), "������� �� ������������� ����������.");
        }

        [Test]
        public void Test_RemainderOfTheDivision_RatNumbByInt()
        {
            //act
            RationalNumbers newRatinonal = _Numb1 % _NumbInt;

            //assert
            Assert.AreEqual(newRatinonal, new RationalNumbers(0, 0), "������� �� ������������� ����������.");
        }

        [Test]
        public void Test_RemainderOfTheDivision_RatNumbByFloat()
        {
            //act
            RationalNumbers newRatinonal = _Numb1 % _NumbFloat;

            //assert
            Assert.AreEqual(newRatinonal, new RationalNumbers(120, 5), "������� �� ������������� ����������.");
        }

        [Test]
        public void Test_RemainderOfTheDivision_RatNumbByDecimal()
        {
            //act
            RationalNumbers newRatinonal = _Numb1 % _NumbDecimal;

            //assert
            Assert.AreEqual(newRatinonal, new RationalNumbers(120, 5), "������� �� ������������� ����������.");
        }

        #endregion

        #region Tests *

        [Test]
        public void Test_Multiplication_RatNumbByRatNumb()
        {

            //act
            //RationalNumbers newRatinonal = chekingNumb++ + 1;
            //RationalNumbers newRatinonal2 = ++chekingNumb2 + 1;

            ////assert
            //Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
            //Assert.IsTrue(ansver2, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_Multiplication_RatNumbByInt()
        {
            //arrange
            RationalNumbers chekingNumb = _Numb2;
            RationalNumbers chekingNumb2 = _Numb2;

            //act
            RationalNumbers newRatinonal = chekingNumb++ + 1;
            bool ansver1 = newRatinonal == new RationalNumbers(36, 6);
            RationalNumbers newRatinonal2 = ++chekingNumb2 + 1;
            bool ansver2 = newRatinonal2 == new RationalNumbers(42, 6);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
            Assert.IsTrue(ansver2, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_Multiplication_RatNumbByFloat()
        {
            //arrange
            RationalNumbers chekingNumb = _Numb2;
            RationalNumbers chekingNumb2 = _Numb2;

            //act
            RationalNumbers newRatinonal = chekingNumb++ + 1;
            bool ansver1 = newRatinonal == new RationalNumbers(36, 6);
            RationalNumbers newRatinonal2 = ++chekingNumb2 + 1;
            bool ansver2 = newRatinonal2 == new RationalNumbers(42, 6);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
            Assert.IsTrue(ansver2, "������ ���� ������ ���������.");
        }

        [Test]
        public void Test_Multiplication_RatNumbByDecimal()
        {
            //arrange
            RationalNumbers chekingNumb = _Numb2;
            RationalNumbers chekingNumb2 = _Numb2;

            //act
            RationalNumbers newRatinonal = chekingNumb++ + 1;
            bool ansver1 = newRatinonal == new RationalNumbers(36, 6);
            RationalNumbers newRatinonal2 = ++chekingNumb2 + 1;
            bool ansver2 = newRatinonal2 == new RationalNumbers(42, 6);

            //assert
            Assert.IsTrue(ansver1, "������ ���� ������ ���������.");
            Assert.IsTrue(ansver2, "������ ���� ������ ���������.");
        }

        #endregion
    }
}