using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DTO
{
    public class UserDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? surname { get; set; }
        public string phone { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
