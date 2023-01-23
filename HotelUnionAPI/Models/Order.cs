using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelUnionAPI.Models
{
    public class Order
    {
        public string id { get; set; }
        public string name { get; set; }
        public string birth { get; set; }
        public string address { get; set; } 
        public string hp { get; set; }
        public string email { get; set; }
        public string room_id { get; set; }
        public string room_name { get; set; }
        public string location { get; set; }
        public string date_s { get; set; }
        public string date_e { get; set; }
        public string content { get; set; }
    }
}
