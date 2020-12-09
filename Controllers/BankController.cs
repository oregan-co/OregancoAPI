using System;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OreganCoAPI.Models;
using OreganCoAPI.Services;

namespace OreganCoAPI.Controllers
{
    [ApiController]
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class BankController : ControllerBase
    {
        public readonly IMapper _mapper;
        public readonly IBankService _bank;

        public BankController(IMapper mapper, IBankService bank)
        {
            _mapper = mapper;
            _bank = bank;
        }

        [HttpPost("transaction/new")]
        public IActionResult PostNewTransaction([FromBody] BankTransaction transaction)
        {
            var response = _bank.PostNewTransaction(transaction);

            return Ok(response);
        }
    }
}
