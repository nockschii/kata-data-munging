using System;
using Xunit;

namespace kata_data_munging
{
    public class FileHandlerTests
    {
        [Fact]
        public void ReadFile_FileExists_TypeFileCargo()
        {
            var fileHandler = new FileHandler();

            var input = fileHandler.read("weather.dat");

            Assert.IsType<FileCargo>(input);
        }
    }
}
