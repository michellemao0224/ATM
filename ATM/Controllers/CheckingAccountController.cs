﻿using ATM.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class CheckingAccountController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: CheckingAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: CheckingAccount/Details
        public ActionResult Details()
        {
            var userId = User.Identity.GetUserId();
            var checkingAccount = db.CheckingAccounts.Where(m => m.ApplicationUserId ==
            userId).First();
            //var checkingAccount = new CheckingAccount {
            //    AccountNumber = "0000123456",
            //    FirstName = "Michelle",
            //    LastName = "Mao",
            //    Balance = 1000
            //};
            return View(checkingAccount);
        }

        public ActionResult List()
        {
            return View(db.CheckingAccounts.ToList());
        }

        // GET: CheckingAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckingAccount/Create
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

        // GET: CheckingAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckingAccount/Edit/5
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

        // GET: CheckingAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckingAccount/Delete/5
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
