using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrackIt.Models
{
    public class Image
    {
        public int ID { get; set; }

        public string ImageTitle { get; set; }

        public byte[] ImageData { get; set; }

        //public int RecordID { get; set; }

        public int ForeignID { get; set; }

            

        [NotMapped]
        public string ImageDataUrl { get; set; }
        public object RecordID { get; internal set; }
    }
}
