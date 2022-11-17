using CSharp_Project_1.Repositories.Entities;
using CSharp_Project_1.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_Project_1.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionsController(IPermissionRepository PermissionRepository)
        {
            _permissionRepository = PermissionRepository;
        }

        [HttpGet]
        public List<Permission> Get()
        {
            return _permissionRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Permission GetById(string id)
        {
            return _permissionRepository.GetById(id);
        }

        [HttpPost()]
        public Permission Post(string id, string name, string description)
        {
            return _permissionRepository.Add(id, name, description);
        }

        [HttpPut()]
        public Permission Put(Permission permission)
        {
            return _permissionRepository.Update(permission);
        }

        [HttpDelete()]
        public void Delete(string id)
        {
            _permissionRepository.Delete(id);
        }
    }
}