using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    static class Menu
    {
        static List<Ctrl> controls=new List<Ctrl>();
        static List<Action> prevMenu=new List<Action>();
        static Cursor cursor=new Cursor();

        static public Action Action()
        {
            char c;
            Action action;
            int index = 0;

            while (true)
            {
                cursor.PrintCursor(controls[index].GetCords());
                c = Console.ReadKey(true).KeyChar;

                switch (c)
                {
                    case 'w':
                        if (index > 0) index--;
                        break;

                    case 's':
                        if (index < controls.Count() - 1) index++;
                        break;

                    case 'e':
                        action = controls.ElementAt(index).Tap();
                        return action;
                }
            }
        }
        static public void PrevMenu()
        {
            prevMenu.RemoveAt(prevMenu.Count() - 1);
            prevMenu.ElementAt(prevMenu.Count() - 1)();
        }
        static public void Add(Ctrl control)
        {
            controls.Add(control);
        }
        static public void AddPrevMenu(Action prev)
        {
            prevMenu.Add(prev);
        }
        static public void ShowMenu()
        {
            Clear();
            foreach(Ctrl item in controls)
            {
                controls.Add(item);
            }
            foreach (Ctrl item in controls)
            {
                item.Print();
            }
        }
        static public void Clear()
        {
            controls.Clear();
            Console.Clear();
        }
    }
}
