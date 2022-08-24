using Implementation.Interfaces;

namespace Implementation
{
    public class ImageBackupManager
    {
        private readonly ImageEditor _imageEditor;

        private Stack<IMemento> _mementos = new Stack<IMemento>();

        public ImageBackupManager(ImageEditor imageEditor)
        {
            _imageEditor = imageEditor;
        }

        public void Backup()
        {
            _mementos.Push(_imageEditor.Save());
        }

        public void Undo()
        {
            var memento = _mementos.Pop();

            if(memento == null)
                return;

            _imageEditor.Restore(memento);
        }
    }
}