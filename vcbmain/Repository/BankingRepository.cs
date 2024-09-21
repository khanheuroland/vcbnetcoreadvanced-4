using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcbmain.Repository
{
    public interface IBankingRepository{
        public double GetLaiSuat(DateTime date);
    }
    public class BankingRepository:IBankingRepository
    {
        public double GetLaiSuat(DateTime date)
        {
            //Get from database
            return 4.5d;
        }
    }
}