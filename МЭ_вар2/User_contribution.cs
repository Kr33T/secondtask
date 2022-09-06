using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МЭ_вар2
{
    public class User_contribution
    {
        public double all_money { get; set; }
        public double percent_money { get; set; }
        public int tax{ get; set; } = 0;
        public double percent { get; set; }

        private double percent_bank = 8.0;

        public User_contribution(int all_money)
        {
            this.all_money = all_money;

            if(all_money < 700000)
            {
                percent = all_money / 50000 + 1;
            }
            else
            {
                int s = all_money - 700000;
                percent = 20 - s / 50000;
            }
            if(percent > percent_bank + 5)
            {
                tax = 30;
            }
        }

        public double Get_persentMoney()
        {
            double m = Math.Round(percent * all_money / 100,2);
            return m - Math.Round(tax * m / 100,2);
        }

        public void Update_percent()
        {
            percent += 0.5;
            if (percent > percent_bank + 5)
            {
                tax = 30;
            }
        }
    }
}
