using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitStudy
{
    internal class Bank
    {
        private async void Credit() 
        {
            await DoComplexWork();
            
            Console.WriteLine("Money Credited");

        }

        private Task<int> DoComplexWork()
        {
            Thread.Sleep(5000);
            // throw new NotImplementedException();
            return Task.FromResult(0);
        }

        public void AddMoney() 
        {
            Credit();
        
        }
    }
}
