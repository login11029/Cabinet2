using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            App app=new App();
            app.Program();






            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            ////ContainsExample();
            ////ReplaceTest();
            //DateTime date = new DateTime();
            //string birdth;
            //Console.WriteLine("Enter date:");
            //birdth = Console.ReadLine();
            //DateTimeFormatInfo dtf = new CultureInfo("uk-Ua", false).DateTimeFormat;
            ////  DateTimeFormatInfo usDtfi = new CultureInfo("uk-UA", false).DateTimeFormat;
            //date = Convert.ToDateTime(birdth,dtf);
            ////Convert.ToDateTime(birdth,usDtfi);
            ////Convert.ToDateTime(birdth, usDtfi);
            
            //Console.WriteLine(date.ToLongDateString());



            ////Console.WriteLine(date.ToString("dd.MMMM.yyyy"));
            ////Console.WriteLine(date.ToString("dd.MM.yyyy"));
            ////var dateNow=DateTime.Now;
            ////TimeSpan ts = dateNow - date;
            ////Console.WriteLine("Вам зараз {0}", (int)ts.TotalDays/365);
            //////TimeSpan ts = new TimeSpan(34229992);
            ////Console.WriteLine($"Day: {ts.Days}, Hours: {ts.Hours}, " +
            ////    $"Minutes: {ts.Minutes}, " +
            ////    $"Seconds: {ts.Seconds}, Milliseconds: {ts.Milliseconds} ");

        }
        static void ReplaceTest()
        {
            string str = "Гарна погода, багато мух.";
            //var result=str.Split(' ');
            //foreach (var item in result)
            //{
            //    item.Replace()
            //}
            StringBuilder builder = 
                new StringBuilder(str);
            builder.Replace(' ', 'X');
            Console.WriteLine(builder.ToString());
            
        }
        static void ContainsExample()
        {
            string str = "Славік,Валера,Вихлоп,Дімон,Пороть,Віталька";
            string[] mas = str.Split(',');
            Console.WriteLine("Вкажіть слово для пошуку:");
            string search = Console.ReadLine();
            search = search.Trim(); //search.TrimEnd();
            Console.WriteLine("Результати пошуку:");
            foreach (var item in mas)
            {
                if (item.Contains(search))
                    Console.WriteLine(item);
                //Console.WriteLine(item);
            }
        }
    }
}
