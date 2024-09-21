using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vcbmain.Repository;

namespace vcbmain.Services
{
    public class BankingService
    {
        IBankingRepository bankingRepository;
        public BankingService(IBankingRepository bankingRepository)
        {
            this.bankingRepository = bankingRepository;
        }

        public double GetOutputMoney(int money, int days)
        {
            double laisuat = bankingRepository.GetLaiSuat(DateTime.Now.Date);
            return Math.Round(money* (laisuat*days/(365*100)));
        }
    }
}