using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class People
    {
        public string _fullname;
        public string _job;
        public int _age;
        public string _interests;
        public int _height;
        public string _gender;

        

        public People(string Fullname, string Job, int Age, string Interests, 
            int Height, string Gender)
        {
            _fullname= Fullname;
            _job= Job;
            _age= Age;
            _interests= Interests;
            _height= Height;
            _gender = Gender;
        }
    }

    
}
