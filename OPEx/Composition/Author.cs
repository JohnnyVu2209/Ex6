using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Author
    {
        private string Name, _Email;
        private char Gender;
        public Author(string name,string email,char gender)
        {
            Name = name;
            _Email = email;
            Gender = gender;
        }
        public string GetName()
        {
            return Name;
        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                this._Email = value;
            }
        }
        public char GetGender()
        {
            return Gender;
        }
        public override string ToString()
        {
            return String.Format("Author[name = {0} ,email = {1} ,gender = {2}] ",this.Name,this._Email,this.Gender);
        }
    }
}
