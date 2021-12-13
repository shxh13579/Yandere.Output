using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yandere.Output.Models
{
    [Table("MarkInfo")]
    public class MarkInfo
    {
        [Key]
        public int id { get; set; }

    }
}
