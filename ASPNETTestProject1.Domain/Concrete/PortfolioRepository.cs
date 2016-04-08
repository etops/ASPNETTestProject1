using ASPNETTestProject1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETTestProject1.Domain.Concrete
{
    public class PortfolioRepository
    {
        public IEnumerable<Portfolio> Portfolios()
        {
            List<Portfolio> portfolios = new List<Portfolio>
            {
                new Portfolio
                {
                    Id = 1,
                    Name = "Test Portfolio A"
                },
                new Portfolio
                {
                    Id = 2,
                    Name = "Test Portfolio B"
                },
            };
            return portfolios;
        }
    }
}
