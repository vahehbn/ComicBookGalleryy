﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGalleryyy.Controllers
{
    public class ComicBooksController :Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The amazing spider man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>";

            ViewBag.Artists = new string[]
            {
                 "Script: Dan Slott",
                 "Pencils: Humberto Ramos",
                 "Inks: Victor Olazaba",
                 "Colors: Edgar Delgado",
                 "Letters: Chris Eliopoulos"
            };
            return View();
        }

        
        
    }
}