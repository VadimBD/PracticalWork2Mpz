using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    internal class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; } = [];

        public Client(int clientId, string name, string phone, string email)
        {
            ClientId = clientId;
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
