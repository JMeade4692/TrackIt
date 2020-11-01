using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TrackIt.Models;

namespace TrackIt.Repository.IRespository
{
    public interface IRepository
    {
        List<VolunteerRecord> GetRecords();
        void SaveImage(Image image);
        Image GetImage(int id);
        VolunteerRecord GetRecord(int id);
        void SaveRecord(VolunteerRecord record);


    }
}
