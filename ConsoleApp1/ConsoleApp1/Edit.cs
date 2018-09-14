using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Edit:Ctrl
    {
        Cords _cords;
        string _text;
        string _data;

        public Action Tap()
        {
            Console.SetCursorPosition(_cords.X+10, _cords.Y);
            _data = Console.ReadLine();
            return null;
        }
        public Cords GetCords()
        {
            return _cords;
        }
        public string GetData()
        {
            return _data;
        }
        public string GetName()
        {
            return _text;
        }
        public void Print()
        {
            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.WriteLine(_text);

            if(_data!=null)
            {
                Console.SetCursorPosition(_cords.X + 10, _cords.Y);
                Console.WriteLine(_data);
            }
        }
        public void Erase()
        {
            string buf = null;
            for (int i = 0; i < _text.Length; i++)
            {
                buf += ' ';
            }
            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.WriteLine(buf);

            buf = null;
            for (int i = 0; i < _data.Length; i++)
            {
                buf += ' ';
            }
            Console.SetCursorPosition(_cords.X+10, _cords.Y);
            Console.WriteLine(buf);
        }
        public void SetAction(Action a)
        {
        }
        public Edit(int x, int y, string text)
        {
            _cords = new Cords();
            _cords.X = x;
            _cords.Y = y;
            _text = text;

            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.WriteLine(_text);
        }
        public Edit(int x, int y, string text,string data)
        {
            _cords = new Cords();
            _cords.X = x;
            _cords.Y = y;
            _text = text;
            _data = data;

            Console.SetCursorPosition(_cords.X, _cords.Y);
            Console.WriteLine(_text);

            if (_data != null)
            {
                Console.SetCursorPosition(_cords.X + 10, _cords.Y);
                Console.WriteLine(_data);
            }
        }
    }
}
