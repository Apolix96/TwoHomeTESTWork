using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dbsamicro.Models;
using dbsamicro.srpDjihad;
namespace dbsamicro.Controllers
{
    public class HomeController : Controller
    {
        private Context context = new Context();

        // GET: Home
        public ActionResult Index()
        {// объект класса с полученными значениями из бд
            Ienumerable ie = new Ienumerable();
            //передали объекты  свойство viewbag
            ViewBag.xD = ie.DataUse();
            //возращаем предаставление
            return View();
        }
        //Добавление новых элементов
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
        // валидация данных, 
        // есть проверка данных, проверит поле'я и они  будут не пустыми, работаем дальше,
        // иначе тогда вернем представление с сообщением
        [HttpPost]
        public ActionResult Insert(Micro micro)
        {
            Insert insert = new Insert();
            if (ModelState.IsValid)
            {
                insert.InsertSet(micro);
                return RedirectToAction("Index");
            }
            return View(micro);

           
        }


        //изменить
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Micro micro = context.micros.Find(id);
            if (micro == null)
            {
                return HttpNotFound();
            }
            return View(micro);
        }

        [HttpPost]
        public ActionResult Edit(Micro micro)
        {
            // валидация данных, 
            // есть проверка данных, проверит поле'я и они  будут не пустыми, работаем дальше,
            // иначе тогда вернем представление с сообщением

            Editor edit = new Editor();
            if (ModelState.IsValid)
            {
               
                edit.Edit(micro);
                return RedirectToAction("Index");
            }
            return View(micro);
           
        }
        // удаление
        public ActionResult Delete(int Id)
        {
            // возращаем представление id (элементы нашего id)
            return View(context.micros.Find(Id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int Id)
        {
            Deletor deletor = new Deletor();
            deletor.Delete(Id);
            return RedirectToAction("Index");
        }

        // информация
        // создаем объект класса для образеия к классу
        // создаём неопределенного типа переменную которой присваиваем результат
        // ктр будет получен из класса info
        // проверка если переменная пустая, возращаем на страницу ошибку
        // а так возращаем результат полученный из класса
        [HttpGet]
        public ActionResult Informirovanie(int? id)
        {
            Info info = new Info();
            var micro = info.Informirovanie(id);
            if (micro == null)
            {
                return View("NotFound");
            }
            return View(micro);
        }
    }
}