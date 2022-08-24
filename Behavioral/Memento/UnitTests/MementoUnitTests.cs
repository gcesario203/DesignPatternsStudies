using Implementation;

namespace UnitTests;

public class MementoUnitTests
{
    [Fact]
    public void ShouldReplaceFilePathWithNewFileFormat()
    {
        var imageEditor = new ImageEditor("C:\\MyDocuments\\image.jpg", "jpg");

        imageEditor.ConvertFormatTo("png");

        Assert.Equal(imageEditor.GetFilePath(), "C:\\MyDocuments\\image.png");
    }

    [Fact]
    public void ShouldRestoreImageEditorToLastState()
    {
        var imageEditor = new ImageEditor("C:\\MyDocuments\\image.jpg", "jpg");

        var imageBackupManager = new ImageBackupManager(imageEditor);

        imageBackupManager.Backup();

        imageEditor.ConvertFormatTo("png");

        imageBackupManager.Undo();

        Assert.Equal(imageEditor.GetFilePath(), "C:\\MyDocuments\\image.jpg");
    }
}