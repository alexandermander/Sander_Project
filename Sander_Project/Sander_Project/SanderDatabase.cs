using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Sander_Project
{
    public class SanderDatabase
    {
        private SQLiteConnection _db;

        public SanderDatabase()
        {
            _db = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            _db.CreateTable<SanderTime>();
            Console.WriteLine("db Created");

        }
        public void AddTime(TimePicker myTime)
        {
            var time = new SanderTime { A_time = myTime};
            _db.Insert(time);
        }


    }
}
