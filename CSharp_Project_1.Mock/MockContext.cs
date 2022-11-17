using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using CSharp_Project_1.Repositories.Entities;
using CSharp_Project_1.Repositories.Interfaces;

namespace CSharp_Project_1.Mock { 
   public class MockContext : IContext
    {
    public List<Role> Roles { get; set; }
    public List<Permission> Permissions { get; set; }
    public List<Claim> Claims { get; set; }

    public MockContext()
    {

        Roles = new List<Role>();
        Permissions = new List<Permission>();
        Claims = new List<Claim>();

    }
}
}

