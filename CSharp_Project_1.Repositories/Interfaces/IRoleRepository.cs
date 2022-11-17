using CSharp_Project_1.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_1.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        List<Role> GetAll();
        Role GetById(string id);
        Role Add(string id, string name, string description);
        Role Update(Role role);
        void Delete(string id);
    }
}
