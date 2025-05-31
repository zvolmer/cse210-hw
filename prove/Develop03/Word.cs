namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public bool IsHidden
        {
            get { return _isHidden; }
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public string Display()
        {
            if (_isHidden)
            {
                return new string('_', _text.Length);
            }
            else
            {
                return _text;
            }
        }
    }
}