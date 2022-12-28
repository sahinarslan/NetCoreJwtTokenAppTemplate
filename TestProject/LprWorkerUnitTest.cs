using xUnitTestTutorial;
 
namespace TestProject
{
    public class LprWorkerUnitTest
    {
        [Fact]
        public void PassingTest()
        {
            LprWorker lprWorker = new();
            Assert.Equal(5, lprWorker.Add(2,3));
        }



        [Theory]
        [InlineData(0,0,0)]
        [InlineData(-1,0,-1)]
        [InlineData(2, 1, 0)]
        [InlineData(5, 7, -2)]
        [InlineData(5, 2, 3)]
        [InlineData(6, 2, 3)]
        public void AddTest(int resut, int s1, int s2)
        {
            LprWorker lprWorker = new();
            Assert.Equal(resut, lprWorker.Add(s1, s2));
        }


        [Fact]
        public void FailingTest()
        {
            LprWorker lprWorker = new();
            Assert.Equal(4, lprWorker.Add(2, 2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        public void IsOldUnitTest(int value)
        {
            LprWorker worker = new();
            Assert.Equal(true, worker.isOdd(value));
        }
    }
}