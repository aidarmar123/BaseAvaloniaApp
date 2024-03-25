using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication2.Models
{
    public class User
    {
        public User(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public  int Age { get; set; }
        public  string Name { get; set; }
       
    }
}
