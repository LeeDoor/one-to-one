using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Controls;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace one_to_one
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private Student selectedStudent;
        public List<Student> Students { get; set; }
        public Student SelectedStudent
        {
            get => selectedStudent;
            set
            {
                selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }
        }

        public MainWindowVM()
        {
            using (WindowDbContext dbContext = new WindowDbContext())
            {
                //List<Card> cards = new List<Card> 
                //{ 
                //    new Card() { SerialNumber = 2229999 }, 
                //    new Card() { SerialNumber = 563563563 },
                //    new Card() { SerialNumber = 64756743 }, 
                //    new Card() { SerialNumber = 12313131 } 
                //};

                //dbContext.Cards.AddRange(cards);
                //dbContext.Students.AddRange(
                //    new Student 
                //    { 
                //        FirstName = "Sergay", 
                //        LastName = "Nikolaev", 
                //        BirthDay = DateTime.Parse("2000/12/12"), 
                //        Card = cards[0], 
                //        PhoneNumber = "+89052222" 
                //    },
                //    new Student { FirstName = "nikolay", LastName = "sergeev", BirthDay = new DateTime(2012, 12, 12), Card = cards[2], PhoneNumber = "+352222" });
                //dbContext.SaveChanges();
                Students = dbContext.Students.Include(n=>n.Card).ToList();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
