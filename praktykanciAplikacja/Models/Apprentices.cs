using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktykanciAplikacja.Models {
    public class Apprentices {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName {  get; set; }
        public string desiredPosition { get; set; }
        public DateTime dateSubmitted { get; set; }
        public Addres addres { get; set; }
        public DateTime dateOfBirth { get; set; }

    }
}
