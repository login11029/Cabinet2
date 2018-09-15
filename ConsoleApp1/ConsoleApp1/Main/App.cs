using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    partial class App
    {
        bool endProgram = false;
        Cabinet cabinet = new Cabinet();

        public void Program()
        {
            Action a = null;

            Menu.NextMenu(MainM);

            while (endProgram != true)
            {
                a=Menu.Action();
                if (a != null)
                {
                    a();
                }
            }
        }
        void ShowList<T>(List<T> list, Action<T> action)
        {

            Menu.Add(new Button(1, 0, "Back", () =>
            {
                Menu.PrevMenu();
            }));

            for (int i = 0; i < list.Count(); i++)
            {
                int num = new int();
                num = i;

                Menu.Add(new Button(1, i + 1, list[i].ToString(), () =>
                {
                    int number = num;
                    action(list[num]);
                }));
            }
        }
        List<T> FindItem<T>(List<T> list, T item)
        {
            if (list.Count == 0)
                return list;

            List<T> found = new List<T>();

            foreach (T element in list)
            {
                if (element.Equals(item))
                    found.Add(element);
            }

            return found;
        }
        void Exit()
        {
            endProgram = true;
        }
        public App()
        {
            endProgram = false;
        }
    }
}







