using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackIt.Data;
using TrackIt.Models;
using TrackIt.Repository.IRespository;

namespace TrackIt.Repository
{
     public class EFRepository : IRepository
    {

        private readonly ApplicationDbContext _db;
        

        public EFRepository(ApplicationDbContext db)
        {
            _db = db;
            
        }

        public Image GetImage(int id)
        {
            Image img = new Image();
            img = _db.Images.FirstOrDefault(i => i.RecordID == id);
            if (img == null) return img;
            string imageBase64Data = Convert.ToBase64String(img.ImageData);
            img.ImageDataUrl = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            return img;
        }

        public VolunteerRecord GetRecord(int id)
        {
            return _db.VolunteerRecords.FirstOrDefault(v => v.RecordID == id);
        }

        public List<VolunteerRecord> GetRecords()
        {
            return _db.VolunteerRecords.ToList();
        }

        public void SaveImage(Image image)
        {
            Image dbEntry = _db.Images
               .FirstOrDefault(d => d.ID == image.ID);
            if (dbEntry != null)
            {
                dbEntry.RecordID = image.RecordID;
                dbEntry.ImageData = image.ImageData;
                dbEntry.ImageTitle = image.ImageTitle;

            }
            else
            {
                _db.Images.Add(image);
            }

            _db.SaveChanges();
        }

        public void SaveRecord(VolunteerRecord record)
        {
            if (record.RecordID == 0)
            {
                _db.VolunteerRecords.Add(record);
                _db.SaveChanges();
            }
            else
            {
                VolunteerRecord dbEntry = _db.VolunteerRecords
                    .FirstOrDefault(p => p.RecordID == record.RecordID);
                if (dbEntry != null)
                {
                    dbEntry.EventName = record.EventName;
                    dbEntry.Notes = record.Notes;

                    _db.SaveChanges();

                }
            }
        }
    }
}
