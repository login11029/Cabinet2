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
        static int index = 0;
        static Action _currentMenu;
        static public Action Action()
        {
            char c;
            Action action;

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
            Clear();
            prevMenu.ElementAt(prevMenu.Count() - 1)();
        }
        static public void Add(Ctrl control)
        {
            controls.Add(control);
        }
        static public void Refresh()
        {
            Clear();
            _currentMenu();
        }
        static public void NextMenu(Action menu)
        {
            Clear();
            prevMenu.Add(menu);
            _currentMenu = menu;
            menu();
        }

        static public void ShowList<T>(List<T> list, Action<T> action)
        {
            Action menu = () =>
            {
                Add(new Button(1, 0, "Back", () =>
                {
                    PrevMenu();
                }));

                for (int i = 0; i < list.Count(); i++)
                {
                    int num = new int();
                    num = i;

                    Add(new Button(1, i + 1, list[i].ToString(), () =>
                    {
                        int number = num;
                        action(list[num]);
                    }));

                }
            };

            _currentMenu = menu;
            NextMenu(menu);
        }

        static public void Clear()
        {
            controls.Clear();
            Console.Clear();
            index = 0;
        }
    }
}
