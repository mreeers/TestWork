using Application.Repository.Interface;
using Models;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class DepositAction
    {
        private readonly IBase _baseRepo;
        private readonly ApplicationDbContext _context;

        public DepositAction(IBase baseRepo, ApplicationDbContext context)
        {
            _baseRepo = baseRepo;
            _context = context;
        }

        public async Task<User> Add(int id, decimal sum)
        {
            var user = _baseRepo.GetUser(id);
            
            if(sum < 0)
            {
                throw new Exception("Сумма не может быть меньше 0");
            }
            else
            {
                user.Deposit = user.Deposit + sum;

                _baseRepo.Update(user);
                await _baseRepo.SaveAllAsync();

                return user;
            }
        }

        public async Task<User> Withdraw(int id, decimal sum)
        {
            var user = _baseRepo.GetUser(id);
            if (sum < 0)
            {
                throw new Exception("Сумма не может быть меньше 0");
            }
            else
            {
                var commission = (sum * 0.5M) / 100;

                user.Deposit = user.Deposit - sum - commission;

                if (user.Deposit < 0)
                {
                    throw new Exception("Недостаточно средств");
                }
                else
                {
                    _baseRepo.Update(user);
                    await _baseRepo.SaveAllAsync();
                    return user;
                }
            }
        }

        public async Task<decimal> GetBalance(int id)
        {
            var user = _baseRepo.GetUser(id);
            var balance = user.Deposit;
            return balance;
        }

    }
}
