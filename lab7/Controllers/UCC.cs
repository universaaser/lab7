using lab7.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using lab7.Data;
using lab7.Models;

namespace lab7.Controllers
{
    public class UniversityCampusesController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: UniversityCampuses
        public ActionResult Index()
        {
            return View(db.UniversityCampuses.ToList());
        }

        // GET: UniversityCampuses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UniversityCampus universityCampus = db.UniversityCampuses.Find(id);
            if (universityCampus == null)
            {
                return HttpNotFound();
            }
            return View(universityCampus);
        }

        // GET: UniversityCampuses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UniversityCampuses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] UniversityCampus universityCampus)
        {
            if (ModelState.IsValid)
            {
                db.UniversityCampuses.Add(universityCampus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(universityCampus);
        }

        // GET: UniversityCampuses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UniversityCampus universityCampus = db.UniversityCampuses.Find(id);
            if (universityCampus == null)
            {
                return HttpNotFound();
            }
            return View(universityCampus);
        }

        // POST: UniversityCampuses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] UniversityCampus universityCampus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(universityCampus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(universityCampus);
        }

        // GET: UniversityCampuses/Delete/5
        public ActionResult Delete(int? id)
