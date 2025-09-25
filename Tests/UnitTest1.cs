namespace Tests
{
    public class UnitTest1
    {
        private readonly Calculator calc = new Calculator();

        [Fact]
        public void TestAdd()
        {
            Assert.Equal(5, calc.Add(2, 3));
            Assert.Equal(0, calc.Add(-1, 1));
        }

        [Fact]
        public void TestMultiply()
        {
            Assert.Equal(6, calc.Multiply(2, 3));
            Assert.Equal(-5, calc.Multiply(-1, 5));
        }
    }
}
