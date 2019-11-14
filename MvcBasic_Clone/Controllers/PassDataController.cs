using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic_Clone.Models;
using MvcBasic_Clone.ViewModels;

namespace MvcBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PassViewData()
        {
            ViewData["Name"] = "Kevin"; //儲存字串
            ViewData["Age"] = 33;       //儲存整數
            ViewData["Single"] = true;  //儲存布林值

            return View();
        }
        public ActionResult PassViewBag()
        {
            ViewBag.Nickname = "Mary";
            // ViewData["Nickname"] = "Davo"; Nickname會顯示Davo
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;

            return View();
        }
        public ActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "無足夠權限存取系統資料，請聯絡系統人員";
            TempData["UserName"] = "David";
            TempData["Time"] = DateTime.Now.ToLongTimeString();
            return RedirectToAction("ErrorMessage", "ErrorHandler");
        }
        public ActionResult PetShop()
        {
            //使用ViewData傳遞資料到View
            ViewData["Company"] = "汪星人寵物店";
            //使用ViewBag傳遞資料到View
            ViewBag.Address = "台北市信義區松山路100號";
            //宣告一個List泛型集合,代表model資料模型
            List<string> petsList = new List<string>();
            petsList.Add("狗");
            petsList.Add("貓");
            petsList.Add("魚");
            petsList.Add("鼠");
            petsList.Add("變色龍");
            //將petSList資料模型指派給ViewData.Model屬性, 傳遞到View
            //ViewData.Model = petsList;
            //return View();

            //實際上傳送model物件給View,會更常使用View(petsList)語法取代
            return View(petsList);
        }
        public ActionResult PassViewModel()
        {
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM.Emplooyees = null;
            peopleVM.Friends = null;

            return View(peopleVM);
        }
    }
}