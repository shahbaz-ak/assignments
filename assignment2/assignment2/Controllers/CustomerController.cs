using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using assignment2.Entities;
using assignment2.Repositories;

namespace assignment2.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository _repo = new CustomerRepository();
        // GET: CustomerController
        [Route("GetAll")]
        public ActionResult Index()
        {
            List<entitiyCustomer> list = _repo.GetCustomers();
            return View(list);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {
            entitiyCustomer e = _repo.GetCustomerId(id);
            return View(e);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(entitiyCustomer c)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Add(c);
                    return RedirectToAction("Index");
                }
                else {
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(string id)
        {
            entitiyCustomer c = _repo.GetCustomerId(id);
            return View(c);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(entitiyCustomer c)
        {
            try
            {
                _repo.Update(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(string id)
        {
            entitiyCustomer c = _repo.GetCustomerId(id);
            return View(c);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(entitiyCustomer c)
        {
            try
            {
                _repo.Delete(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
