using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOne.Models
{
    public class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public DateTime RegistDate { get; set; }

        public string Mobile { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}
