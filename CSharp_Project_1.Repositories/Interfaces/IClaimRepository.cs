using CSharp_Project_1.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_1.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        List<Claim> GetAll();
        Claim GetById(string id);
        Claim Add(string id, string roleId, string permissionId, EPolicy policy);
        Claim Update(Claim claim);
        void Delete(string id);
    }
}
