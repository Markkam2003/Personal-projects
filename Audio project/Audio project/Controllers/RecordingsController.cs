using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audio_project.Controllers
{
    public class RecordingsController : Controller
    {
        private ApplicationDbContext _context;

        public RecordingsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Recordings
        public ActionResult Index()
        {
            // Get all the recordings from the database
            var recordings = _context.Recordings.ToList();

            return View(recordings);
        }

        // GET: Recordings/Create
        public ActionResult Create()
        {
            // Create a new Recording object
            var recording = new Recording();

            return View(recording);
        }

        // POST: Recordings/Create
        [HttpPost]
        public ActionResult Create(Recording recording)
        {
            // Save the recording to the database
            _context.Recordings.Add(recording);
            _context.SaveChanges();

            return Redire
    }
}
