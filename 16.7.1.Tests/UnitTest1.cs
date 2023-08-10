namespace _16._7._1.Tests
{
    public class Tests
    {
        [TestFixture]
        public class Class1
        {
            [Test]
            public void AdditionalTest()
            {
                Calculator Calc = new Calculator();
                Assert.True(Calc.Additional(1, 1) == 2);
            }

            [Test]
            public void Subtraction()
            {
                Calculator Calc = new Calculator();
                Assert.True(Calc.Subtraction(1, 1) == 0);
            }

            [Test]
            public void Miltiplication()
            {
                Calculator Calc = new Calculator();
                Assert.True(Calc.Miltiplication(2, 2) == 4);
            }

            [Test]
            public void Division()
            {
                Calculator Calc = new Calculator();
                Assert.True(Calc.Division(4, 2) == 2);
            }
        }
    }
}