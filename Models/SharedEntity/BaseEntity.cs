using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class BaseEntity
    {
        [Column("CreatedDate")]
        [DataType(DataType.DateTime)]
        DateTime? CreatedDate { get; set; }
        [Column("CreatedBy")]
        string CreatedBy { get; set; }
        [Column("UpdatedDate")]
        [DataType(DataType.DateTime)]
        DateTime? UpdatedDate { get; set; }
        [Column("UpdatedBy")]
        string UpdatedBy { get; set; }
    }
}
