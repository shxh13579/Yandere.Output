using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yandere.Common.Models
{
    [Table("MarkInfo")]
    public class MarkInfo
    {
        [Key]
        public int id { get; set; }

    }
}
