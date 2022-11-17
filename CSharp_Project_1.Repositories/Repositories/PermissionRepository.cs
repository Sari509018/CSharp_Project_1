using CSharp_Project_1.Repositories.Entities;
using CSharp_Project_1.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_1.Repositories.Repositories
{
    public class PermissionRepository
    {
        public readonly IContext _context;
        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }
        public Permission GetById(string id)
        {
            return _context.Permissions.First(p => p.Id == id);
        }
        public Permission Add(string id, string name, string description)
        {
            _context.Permissions.Add(new Permission(id, name, description));
            return _context.Permissions.First(p => p.Id == id);
        }
        public Permission Update(Permission permission)
        {
            Permission find_permission = _context.Permissions.First(p => p.Id == permission.Id);
            find_permission.Name = permission.Name;
            find_permission.Description = permission.Description;
            return find_permission;
        }
        public void Delete(string id)
        {
            Permission find_permission = _context.Permissions.First(p => p.Id == id);
            _context.Permissions.Remove(find_permission);
        }
    }
}
