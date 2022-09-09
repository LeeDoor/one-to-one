using System;
namespace one_to_one
{
    public class Card
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }

        public Student Student { get; set; }
    }
}
