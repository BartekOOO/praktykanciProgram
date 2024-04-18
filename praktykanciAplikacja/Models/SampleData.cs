using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktykanciAplikacja.Models {
    static class SampleData {
        public static List<Apprentices> Orders = new List<Apprentices>() {
            new Apprentices {
                id = 1,
                firstName = "Bartłomiej",
                lastName = "Władimiruk",
                desiredPosition = "Programista",
                dateSubmitted = DateTime.Now,
                addres = new Addres("Biała Podlaska","Grabanów","21"),
                dateOfBirth = new DateTime(2003,8,16)
            }
        };
    }
}
