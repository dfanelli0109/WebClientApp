using System;
using System.ComponentModel.DataAnnotations;

namespace PractApp.Clients
{
    public class Client
    {
        public int ID { get; set; }
        public string Clients { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
