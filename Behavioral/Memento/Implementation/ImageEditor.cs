using Implementation.Interfaces;

namespace Implementation;
public class ImageEditor
{
    private string FilePath;

    private string FileFormat;

    public ImageEditor(string filePath, string fileFormat)
    {
        FilePath = filePath;
        FileFormat = fileFormat;
    }

    public string GetFilePath()
    {
        return FilePath;
    }
    public string GetFileFormat()
    {
        return FileFormat;
    }

    public void ConvertFormatTo(string format)
    {
        FileFormat = format;

        ChangeFilePathByFormat();
    }

    private void ChangeFilePathByFormat()
    {
        FilePath = $"{string.Join("", FilePath.Split(".").SkipLast(1))}.{FileFormat}";
    }

    public IMemento Save()
    {
        return new ImageEditorMemento(DateTime.Now, DateTime.UtcNow.ToString(),FilePath, FileFormat);
    }

    public void Restore(IMemento memento)
    {
        var imageEditorMemento = memento as ImageEditorMemento;

        FilePath = imageEditorMemento?.GetFilePath() ?? FilePath;

        FileFormat = imageEditorMemento?.GetFileFormat() ?? FileFormat;
    }
}
