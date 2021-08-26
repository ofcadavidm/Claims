using System.ComponentModel.DataAnnotations.Schema;

namespace ClaimApi.Model
{
    [Table("Documents")]
    public class Document : BaseCollection
    {
        public string File { get; set; }
        public string Url { get; set; }
    }
}
