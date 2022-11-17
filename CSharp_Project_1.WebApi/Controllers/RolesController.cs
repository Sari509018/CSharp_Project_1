using CSharp_Project_1.Mock;
using CSharp_Project_1.Repositories.Entities;
using CSharp_Project_1.Repositories.Interfaces;
using CSharp_Project_1.Repositories.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_Project_1.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RolesController(IRoleRepository RoleRepository)
        {
            _roleRepository = RoleRepository;
        }

        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Role GetById(string id)
        {
            return _roleRepository.GetById(id);
        }

        [HttpPost()]
        public Role Post(string id, string name, string description)
        {
            return _roleRepository.Add(id, name, description);
        }

        [HttpPut()]
        public Role Put(Role role)
        {
            return _roleRepository.Update(role);
        }

        [HttpDelete()]
        public void Delete(string id)
        {
            _roleRepository.Delete(id);
        }
    }
}

