using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class CtrlList<T> : Ctrl
    {
        Cords _cords=new Cords();

        List<T> _list=new List<T>();
        Action<T> _action;


        public void Erase()
        {
            throw new NotImplementedException();
        }

        public Cords GetCords()
        {
            return _cords;
        }

        public string GetName()
        {
            return null;
        }

        public void Print()
        {
            for (int i = 0; i < _list.Count(); i++)
            {
                int num = new int();
                num = i;

                Menu.Add(new Button(_cords.X, +_cords.Y+i, _list[i].ToString(), () =>
                {
                    int number = num;
                    _action(_list[num]);
                }));
            }
        }

        public void SetAction(Action a)
        {
            throw new NotImplementedException();
        }

        //public Action Tap()
        //{
        //    throw new NotImplementedException();
        //}

        public Action Tap()
        {
            return null;
        }

        public CtrlList(int x,int y, List<T>list,Action<T>action)
        {
            _cords.X = x;
            _cords.Y = y;
            foreach(T item in list)
            {
                _list.Add(item);
            }
            _action = action;

            Print();
        }
    }
}
