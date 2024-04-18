namespace praktykanciAplikacja.Models
{
    public class Addres
    {
        private string city { get; set; }
        private string street { get; set; }
        private string number { get; set; }

        public Addres(string city,string street,string number)
        {
            this.city = city;
            this.street = street;
            this.number = number;
        }

        public string getAddres()
        {
            return $"{this.city} {this.street} {this.number}";
        }

    }
}
