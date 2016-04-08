using ASPNETTestProject1.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETTestProject1.Controllers
{
    public class PortfolioMVCController : Controller
    {
        public PortfolioRepository portfolioRepository;
        public PortfolioMVCController()
        {
            this.portfolioRepository = new PortfolioRepository();
        }
        //
        // GET: /PortfolioMVC/

        public ActionResult Index()
        {
            return View(portfolioRepository.Portfolios());
        }

        //
        // GET: /PortfolioMVC/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PortfolioMVC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PortfolioMVC/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PortfolioMVC/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PortfolioMVC/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PortfolioMVC/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PortfolioMVC/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
