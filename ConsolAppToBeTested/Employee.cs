using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolAppToBeTested
{
    public class Employee : IEmployee
    {
        private decimal bonus=0.1m;

        public string? Address { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Salary { get; set; }
        public ServiceZone? serviceZone { get; set; }
        public decimal Bonus
        {
            get => bonus; set => bonus = value;
        }

    }

}
