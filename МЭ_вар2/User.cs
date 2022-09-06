using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МЭ_вар2
{
    public class User
    {
        public int money{ get; set; }
        public int month { get; set; } = 12;

        public User(int money) 
        { 
            this.money = money;
        }

    }
}
