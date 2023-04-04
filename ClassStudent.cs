using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppClassFirst
{
    internal class ClassStudent
    {
        //поля
        private string fio;
        private DateTime birthday;
       
        private double scholarship;
        // свойства для доступа к полям
        public string FIO
        {
            get { return fio; }//возвращает значение поля
            set { fio = value; } //устанавливает значение поля
        }
               
        public double Scholarship
        {
            get { return scholarship; }
            set { scholarship = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        
        //методы 
        //конструктор без параметров задает значения полей по умолчанию
        public ClassStudent()
        {
            fio = "";
            birthday = new DateTime(2001, 01, 01);
            scholarship = 0.00;
        }
        //конструктор с параметрами
        public ClassStudent(string f, DateTime d, double s)
        {
            fio = f;
            birthday = d;
            scholarship = s;
        }
        //метод вывода на экран
        public string PrintToScreen()
        {
           string line = $"Студент {fio} дата рождения {birthday}" +"\n";
           line += $"Получает стипендию в размере {scholarship} рублей"+"\n";

            return line;
        }
        public void SaveToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
            streamWriter.WriteLine("Личные данные студента");
            streamWriter.WriteLine($"ФИО: {fio}");
            streamWriter.WriteLine($"Дата рождения: {birthday.ToString()}");
            streamWriter.WriteLine($"Стипендия: {scholarship.ToString()}");
            streamWriter.Close();
        }
   
       
    }
}
