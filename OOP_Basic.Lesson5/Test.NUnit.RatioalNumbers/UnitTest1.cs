using NUnit.Framework;
using OOP_Basic.Lesson5;

namespace Test.NUnit.RatioalNumbers
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

        [Test]
        public void Test_Equality_RatNumbAndInt()
        {
            //act
            bool equal1 = _Numb1 == _NumbInt;
            bool equal2 = _Numb3 == _NumbInt;

            //assert
            Assert.IsTrue(equal1, "������ ���� �����.");
            Assert.IsFalse(equal2, "������ ���� �������.");
        }

        [Test]
        public void Test_Equality_RatNumbAndFloat()
        {
            //act
            bool equal1 = _Numb3 == _NumbFloat;
            bool equal2 = _Numb1 == _NumbFloat;

            //assert
            Assert.IsTrue(equal1, "������ ���� �����.");
            Assert.IsFalse(equal2, "������ ���� �������.");
        }

        [Test]
        public void Test_Equality_RatNumbAndDecimal()
        {
            //act
            bool equal1 = _Numb3 == _NumbDecimal;
            bool equal2 = _Numb1 == _NumbDecimal;

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

        [Test]
        public void Test_NotEquality_RatNumbAndInt()
        {
            //act
            bool equal1 = _Numb1 != _NumbInt;
            bool equal2 = _Numb3 != _NumbInt;
            bool equal3 = _Numb2 != 30;

            //assert
            Assert.IsFalse(equal1, "������ ���� �����.");
            Assert.IsTrue(equal2, "������ ���� �������.");
            Assert.IsTrue(equal3, "������ ���� �������.");
        }

        [Test]
        public void Test_NotEquality_RatNumbAndFloat()
        {
            //act
            bool equal1 = _Numb3 != _NumbFloat;
            bool equal2 = _Numb1 != _NumbFloat;

            //assert
            Assert.IsFalse(equal1, "������ ���� �����.");
            Assert.IsTrue(equal2, "������ ���� �������.");
        }

        [Test]
        public void Test_NotEquality_RatNumbAndDecimal()
        {
            //act
            bool equal1 = _Numb3 != _NumbDecimal;
            bool equal2 = _Numb1 != _NumbDecimal;

            //assert
            Assert.IsFalse(equal1, "������ ���� �������.");
            Assert.IsTrue(equal2, "������ ���� �����.");
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



        #endregion
    }
}