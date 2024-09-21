using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcbmain.Services
{
    public class FizzBuzz
    {
        public String Get(int number)
        {
            String strResult = "";
            for(int i=1; i<=number; i++)
            {
                if(i%3==0 && i%5==0)
                    strResult +="fizzbuzz,";
                else if(i%3==0)
                    strResult+="fizz,";
                else if(i%5==0)
                    strResult+="buzz,";
                else
                    strResult+= i.ToString() +",";
            }

            return strResult.TrimEnd(',');
        }
    }
}