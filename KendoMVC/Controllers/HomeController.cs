using API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoMVC.Controllers
{
    public class HomeController : Controller
    {
      

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetProductos()
        {
            //A traves de un Web Service WCF
            ServiceProduct.ServiceProduct serv = new ServiceProduct.ServiceProduct();
            var datos = serv.GetProductos();
            return View(datos);

            //A traves de un API
            using (ProductosController api = new ProductosController())
            {
                var a = api.Getproductos();
                return View(a);
            }
        }
    }
}