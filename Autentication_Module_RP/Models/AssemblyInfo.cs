using System;
using System.ComponentModel.DataAnnotations;

namespace Autentication_Module_RP.Models
{
    public class User
    {
        public int ID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String BirthDate { get; set; }

    }
}