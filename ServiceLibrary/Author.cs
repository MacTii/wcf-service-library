using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace ServiceLibrary
{
    [DataContract]
    public class Author
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        public Author(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is string))
            {
                return false;
            }

            string other = obj as string;
            string[] otherSplit = other.Split(' ');
            return otherSplit[0].Equals(Name) && otherSplit[1].Equals(Surname);
        }
    }
}
