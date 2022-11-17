using CSharp_Project_1.Repositories.Entities;
using CSharp_Project_1.Repositories.Interfaces;
using CSharp_Project_1.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_1.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepository
    {

        public readonly IContext _context;

        public ClaimRepository(IContext context)
        {
            _context = context;
        }

        public List<Claim> GetAll() { return _context.Claims; }

        public Claim GetById(string id)
        {
            Claim find_claim = _context.Claims.First(c => c.Id == id);
            return find_claim;
        }

        public Claim Add(string id, string roleId, string permissionId, EPolicy policy)
        {
            _context.Claims.Add(new Claim(id, roleId, permissionId, policy));
            return _context.Claims.First(c => c.Id == id);
        }

        public Claim Update(Claim claim)
        {
            Claim find_claim = _context.Claims.First(c => c.Id == claim.Id);
            find_claim.RoleId = claim.RoleId;
            find_claim.PermissionId = claim.PermissionId;
            find_claim.Policy = claim.Policy;
            return find_claim;
        }
        public void Delete(string id)
        {
            Claim find_claim = _context.Claims.First(c => c.Id == id);
            _context.Claims.Remove(find_claim);
        }


    }
}

