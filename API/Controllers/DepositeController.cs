using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Application.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IBase _baseRepo;

        public DepositeController(ApplicationDbContext context, IBase baseRepo)
        {
            _context = context;
            _baseRepo = baseRepo;
        }

        // GET: api/Deposite
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        // GET: api/Deposite/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpGet("{id}/getbalance")]
        public async Task<ActionResult<User>> GetBalance(int id)
        {
            var request = new DepositAction(_baseRepo, _context);
            try
            {
                var balance = await request.GetBalance(id);
                return Ok(balance);
            }
            catch(Exception ex)
            {
                return BadRequest($"Произошла ошибка: {ex.Message}");
            }
        }

        [HttpPost("{id}/add")]
        public async Task<ActionResult<User>> AddDeposite(int id, decimal sum)
        {
            var request = new DepositAction(_baseRepo, _context);
            try
            {
                var getUser = await request.Add(id, sum);
                return Ok($"Успешное пополнение. Сумма на счету: {getUser.Deposit}");
            }
            catch(Exception ex)
            {
                return BadRequest($"Произошла ошибка: {ex.Message}");
            }
        }

        [HttpPost("{id}/withdraw")]
        public async Task<ActionResult<User>> WithdrawDeposite(int id, decimal sum)
        {
            try
            {
                var request = new DepositAction(_baseRepo, _context);
                var getUser = await request.Withdraw(id, sum);
                return Ok("Успешное списание. Сумма на счету: {getUser.Deposit}");
            }
            catch (Exception ex)
            {
                return BadRequest($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
