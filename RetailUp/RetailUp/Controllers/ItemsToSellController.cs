﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailUp.DAL;
using RetailUp.Models;

namespace RetailUp.Controllers
{
    public class ItemsToSellController : Controller
    {
        public IItemToSellRepository ItemRep;

       public ItemsToSellController(IItemToSellRepository itemRep)
        {
            ItemRep = itemRep;
        }

        // GET: ItemsToSellController
        public ActionResult Index()
        {
            var listItem = ItemRep.GetItemsToSell();

            return View(listItem);
        }

        // GET: ItemsToSellController/Details/5
        public ActionResult Details(int id) 
        {
            var itemToSell = ItemRep.GetById(id);

            return View(itemToSell);
        }

        // GET: ItemsToSellController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemsToSellController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemToSell itemToSell)
        {
            try
            {
                ItemRep.Insert(itemToSell);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: ItemsToSellController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = ItemRep.GetById(id);

            return View(item);
        }

        // POST: ItemsToSellController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( ItemToSell itemToSell)
        {
            try
            {             
                ItemRep.Update(itemToSell);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: ItemsToSellController/Delete/5
        public ActionResult Delete(int id)
        {
            var itemToSell = ItemRep.GetById(id);
            return View(itemToSell);
        }

        // POST: ItemsToSellController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                ItemRep.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }
    }
}