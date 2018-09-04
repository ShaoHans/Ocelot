using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiOne.Models
{
    public class MemberService
    {
        private static List<Member> _members = new List<Member>()
        {
            new Member{ Id=1,Name="shz",Gender = Gender.Male,Mobile="12345678902",RegistDate=DateTime.Now}
        };

        public static List<Member> GetAll()
        {
            return _members;
        }

        public static Member GetById(int id)
        {
            return _members.FirstOrDefault(m => m.Id == id);
        }

        public static void Add(string name, string mobile = "", Gender gender = Gender.Male)
        {
            Member member = new Member
            {
                Id = _members.Count + 1,
                Name = name,
                Gender = gender,
                Mobile = mobile,
                RegistDate = DateTime.Now
            };

            _members.Add(member);
        }
    }
}
