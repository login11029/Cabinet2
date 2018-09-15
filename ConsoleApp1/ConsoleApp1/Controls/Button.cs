using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StringAndStringBuilder
{
    class Button:Ctrl
    {
        Action _action = null;
        string _text;
        Cords _cords;

        public Action Tap()
        {
            return _action;
        }
        public Cords GetCords()
        {
            return _cords;
        }
        public string GetName()
        {
            return _text;
        }
        public string GetData()
        {
            return _text;
        }
        public void Erase()
        {
            string buf=null;
            for(int i=0;i<_text.Length;i++)
            {
                buf += ' ';
            }
            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.WriteLine(buf);
        }
        public void SetAction(Action a)
        {
            _action = a;
        }
        public void Print()
        {
            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.WriteLine(_text);
        }
        public Button(int x,int y,string text, Action action)
        {
            _cords = new Cords();
            _cords.X = x;
            _cords.Y = y;
            _action = action;
            _text = text;

            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.WriteLine(_text);
        }
        public Button(int x, int y, string text)
        {
            _cords = new Cords();
            _cords.X = x;
            _cords.Y = y;
            _text = text;

            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.WriteLine(_text);
        }
    }
}
