using SQLite;
using Xamarin.Forms;

namespace Sander_Project
{
    [Table("Times")]
    public class SanderTime
    {
        [PrimaryKey, AutoIncrement]
        public TimePicker A_time { get; set; }
        public TimePicker B_time { get; set; }

    }
}
