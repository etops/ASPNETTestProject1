using ASPNETTestProject1.Domain.Concrete;
using ASPNETTestProject1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPNETTestProject1.Controllers
{
    public class PortfolioController : ApiController
    {
        public PortfolioRepository portfolioRepository;

        public PortfolioController()
        {
            this.portfolioRepository = new PortfolioRepository();
        }

        // GET api/portfolio
        public IEnumerable<Portfolio> Get()
        {
            return portfolioRepository.Portfolios();
        }

        // GET api/portfolio/5
        public Portfolio Get(int id)
        {
            return portfolioRepository.Portfolios().Where(p => p.Id == id).FirstOrDefault();
        }

        // POST api/portfolio
        public void Post([FromBody]string value)
        {

        }

        // PUT api/portfolio/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/portfolio/5
        public void Delete(int id)
        {

        }
    }
}
