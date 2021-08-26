using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimApi.Model
{
    [Table("Documents")]
    public class Document : BaseCollection
    {
        public string File { get; set; }
        public string Url { get; set; }
    }
}
