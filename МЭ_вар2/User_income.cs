using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МЭ_вар2
{
    public class User_income
    {
        public double start_money { get; set; }
        public double end_money { get; set; }

        public User_income(double start_money, double end_money)
        {
            this.start_money = start_money;
            this.end_money = end_money;
        }
    }
}
