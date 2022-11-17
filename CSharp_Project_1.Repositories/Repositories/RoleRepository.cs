using CSharp_Project_1.Repositories.Entities;
using CSharp_Project_1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_1.Repositories.Repositories
{
    public class RoleRepository
    {
        private readonly IContext _context;

        public RoleRepository(IContext context)
        {
            _context = context;
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(string id)
        {
            return _context.Roles.First(r => r.Id == id);
        }

        public Role Add(string id, string name, string description)
        {
            _context.Roles.Add(new Role(id, name, description));
            return _context.Roles.First(r => r.Id == id);
        }

        public Role Update(Role role)
        {
            Role find_role = _context.Roles.First(r => r.Id == role.Id);
            find_role.Name = role.Name;
            find_role.Description = role.Description;
            return find_role;
        }

        public void Delete(string id)
        {
            Role find_role = _context.Roles.First(r => r.Id == id);
            _context.Roles.Remove(find_role);
        }



    }
}

