using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_1.Repositories.Entities
{
    public class Role
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Role() { }

        public Role(string Id, string Name, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }

    }

}
