namespace kata_data_munging
{
    public class FileCargo
    {
        private string _fileInput;

        public FileCargo(string fileInput)
        {
            _fileInput = fileInput;
        }

        public string getInput()
        {
            return _fileInput;
        }
    }
}