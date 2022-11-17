using CSharp_Project_1.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_1.Repositories.Interfaces
{
    public interface IContext
    {
        List<Role> Roles { get; set; }
        List<Permission> Permissions { get; set; }
        List<Claim> Claims { get; set; }

    }
}
