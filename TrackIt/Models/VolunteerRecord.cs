using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrackIt.Models
{
    public class VolunteerRecord
    {
        [Key]
        public int RecordID { get; set; }

        public int CompanyId { get; set; }

        public DocumentTypes DocumentType { get; set; }
        public byte[] Document { get; set; }


        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        public string Notes { get; set; }

        public string EventName { get; set; }

}  
    public enum DocumentTypes {Doc, Docx, PDF, Jpeg, Png}
}
