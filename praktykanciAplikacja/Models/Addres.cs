using System.IO;

namespace praktykanciAplikacja.Models
{
    public class Addres
    {
        public string city { get; set; }
        public string street { get; set; }
        public string number { get; set; }

        public Addres(string city,string street,string number)
        {
            this.city = city;
            this.street = street;
            this.number = number;
        }

        public string getAddres()
        {
            return $"{street}, {city}, {number}";
        }

    }
}
