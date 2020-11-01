using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrackIt.Models;
using TrackIt.Repository.IRespository;

namespace TrackIt.Controllers
{
    public class AccountController : Controller
    {
        private IRepository repository;

        public AccountController(IRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult UploadPic()
        {
            return View();
        }

        //public IActionResult Profile()
        //{
        //    var model = repository.GetRecords();
        //    return View(model);

        //}
        //public IActionResult UploadPic(VolunteerRecord record)
        //{
        //    repository.SaveRecord(record);
        //    UploadImage(record);
        //    return RedirectToAction("Profile");
            
        //}
        public void UploadImage(VolunteerRecord record)
        {
            if (record.RecordID > 0)
            {
                foreach (var file in Request.Form.Files)
                {
                    var img = new Image { RecordID = record.RecordID, ImageTitle = file.FileName };

                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        img.ImageData = ms.ToArray();
                        ms.Close();
                        ms.Dispose();
                    }

                    repository.SaveImage(img);
                }

                TempData["message"] = "Image(s) stored in  database!";
            }
            else
            {
                TempData["message"] = "Cannot add images to a non existent product!";
            }


        }
    }
}
