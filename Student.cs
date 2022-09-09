using System;

namespace one_to_one
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }

        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
