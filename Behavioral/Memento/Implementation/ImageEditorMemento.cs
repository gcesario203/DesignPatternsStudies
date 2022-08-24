using Implementation.Interfaces;

namespace Implementation
{
    public class ImageEditorMemento : IMemento
    {
        private DateTime Date;

        private string Name;

        private string FileFormat;
        private string FilePath;

        public ImageEditorMemento(DateTime date, string name, string filePath, string fileFormat)
        {
            Date = date;
            Name = name;
            FileFormat = fileFormat;
            FilePath = filePath;
        }
        public DateTime GetDate()
        {
            return Date;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetFileFormat()
        {
            return FileFormat;
        }
        public string GetFilePath()
        {
            return FilePath;
        }
        
    }
}