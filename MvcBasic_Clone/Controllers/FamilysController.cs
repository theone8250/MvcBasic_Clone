using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic_Clone.Models;//引用Model命名空間，這樣Controlle才能參考到Models資料夾中的Family.cs類別。


namespace MvcBasic_Clone.Controllers
{
    public class FamilysController : Controller
    {
        // GET: Familys
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FamilyList()
        {
            List<Family> families = new List<Family>
            {
                new Family{Id="H123456789",Name="吳泓賢",Phone="0922-341908",Age="23",City="新北"},
                new Family{Id="H123236709",Name="徐沛俊",Phone="0925-341900",Age="33",City="台南"},
                new Family{Id="H120456789",Name="劉思妤",Phone="0920-341908",Age="43",City="台中"}
            };
            return View(families);
        }
    }
}