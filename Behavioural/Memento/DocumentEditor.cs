using System.Dynamic;

namespace designPattern.Behavioural.Memento
{
    public class DocumentEditor
    {
        private string _content;
        private string _font;
        private double _fontSize;
        private string _fontColor;
        private bool _isBold;
        private bool _isUnderlined;
        private bool _isItalicized;

        public void SetContent(string content) => _content = content;
        public void SetFont(string font) => _font = font;
        public void SetFontSize(double fontSize) => _fontSize = fontSize;
        public void SetFontColor(string fontColor) => _fontColor = fontColor;
        public void SetBold(bool isBold) => _isBold = isBold;
        public void SetUnderLine(bool isUnderlined) => _isUnderlined = isUnderlined;
        public void SetItalics(bool isItalicized) => _isItalicized = isItalicized;
        
        public void Print()
{
    Console.WriteLine("----- Memento State -----");
    Console.WriteLine($"Content     : {_content}");
    Console.WriteLine($"Font        : {_font}");
    Console.WriteLine($"Font Size   : {_fontSize}");
    Console.WriteLine($"Font Color  : {_fontColor}");
    Console.WriteLine($"Bold        : {_isBold}");
    Console.WriteLine($"Underlined  : {_isUnderlined}");
    Console.WriteLine($"Italicized  : {_isItalicized}");
    Console.WriteLine("-------------------------");
}


        public Memento Save()
        {
            return new Memento(_content, _font, _fontSize, _fontColor, _isBold, _isUnderlined, _isItalicized);
        }

        public void Restore(Memento restorePoint)
        {

            this._content = restorePoint.GetContent();
            this._font = restorePoint.GetFont();
            this._fontSize = restorePoint.GetFontSize();
           this._fontColor = restorePoint.GetFontColor();
            this._isBold = restorePoint.IsBold();
            this._isUnderlined = restorePoint.IsUnderlined();
            this._isItalicized = restorePoint.IsItalicized();

        }

        // Private nested class: only DocumentEditor can access this
        public class Memento
        {
            private readonly string _content;
            private readonly string _font;
            private readonly double _fontSize;
            private readonly string _fontColor;
            private readonly bool _isBold;
            private readonly bool _isUnderlined;
            private readonly bool _isItalicized;

            internal Memento(string content, string font, double fontSize, string fontColor,
                            bool isBold, bool isUnderlined, bool isItalicized)
            {
                _content = content;
                _font = font;
                _fontSize = fontSize;
                _fontColor = fontColor;
                _isBold = isBold;
                _isUnderlined = isUnderlined;
                _isItalicized = isItalicized;
            }

            public string GetContent()
            {
                return _content;
            }

            public string GetFont()
            {
                return _font;
            }

            public double GetFontSize()
            {
                return _fontSize;
            }

            public string GetFontColor()
            {
                return _fontColor;
            }

            public bool IsBold()
            {
                return _isBold;
            }

            public bool IsUnderlined()
            {
                return _isUnderlined;
            }

            public bool IsItalicized()
            {
                return _isItalicized;
            }

        }
    }




}