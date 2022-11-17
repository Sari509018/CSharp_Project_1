using CSharp_Project_1.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_1.Repositories.Interfaces
{
    public interface IPermissionRepository
    {
        List<Permission> GetAll();
        Permission GetById(string id);
        Permission Add(string id, string name, string description);
        Permission Update(Permission permission);
        void Delete(string id);
    }
}