﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarcodeGenerate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            if (id is null)
            {
                id = "1";
            }
            // string barCode = Item.Barcode;
            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            brCode.Draw(id, 60).Save(AppDomain.CurrentDomain.BaseDirectory + "/Barcode.jpg");
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(string id)
        {
            if(id is null)
            {
                id = "1";
            }
           // string barCode = Item.Barcode;
            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            brCode.Draw(id, 60).Save(AppDomain.CurrentDomain.BaseDirectory + "/Barcode.jpg");
            //ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}