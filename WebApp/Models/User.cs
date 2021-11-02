using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class User
    {
        public int Id { get; set; }

        public Role Role { get; set; }

        public string Firstname { get; set; }

        public string Middlename { get; set; }

        public string Lastname { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Confirmed { get; set; }

        public User()
        {
        }

        public User(int id, Role role, string firstname, string middlename, string lastname, string address, string phone, string email, string password, bool confirmed)
        {
            Id = id;
            Role = role;
            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
            Address = address;
            Phone = phone;
            Email = email;
            Password = password;
            Confirmed = confirmed;
        }
    }
}
