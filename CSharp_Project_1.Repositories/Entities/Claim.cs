using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Project_1.Repositories.Entities
{
    public enum EPolicy { Allow, Deny }
    public class Claim
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string PermissionId { get; set; }
        public EPolicy Policy { get; set; }

        public Claim() { }

        public Claim(string Id, string RoleId, string PermissionId, EPolicy Policy)
        {
            this.Id = Id;
            this.RoleId = RoleId;
            this.PermissionId = PermissionId;
        }
    }
}

