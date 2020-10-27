using Xunit;

namespace kata_data_munging
{
    class FileCargoTests
    {
        public void Test1()
        {
            var fileCargo = new FileCargo("test");

            var result = fileCargo.getInput();

            Assert.Equal("test", result);
        }
    }
}
