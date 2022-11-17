using CSharp_Project_1.Repositories.Entities;
using CSharp_Project_1.Repositories.Interfaces;
using CSharp_Project_1.Repositories.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharp_Project_1.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimsController(IClaimRepository ClaimRepository)
        {
            _claimRepository = ClaimRepository;
        }

        [HttpGet]
        public List<Claim> Get()
        {
            return _claimRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Claim GetById(string id)
        {
            return _claimRepository.GetById(id);
        }

        [HttpPost()]
        public Claim Post(string id, string roleId, string permissionId, EPolicy policy)
        {
            return _claimRepository.Add(id, roleId, permissionId, policy);
        }

        [HttpPut()]
        public Claim Put(Claim claim)
        {
            return _claimRepository.Update(claim);
        }

        [HttpDelete()]
        public void Delete(string id)
        {
            _claimRepository.Delete(id);
        }
    }
}
