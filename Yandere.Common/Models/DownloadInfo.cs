using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yandere.Common.Models
{
    [Table("DownloadInfo")]
    public class DownloadInfo
    {
        [Key]
        public int id { get; set; }

        public bool IsPNGDownload { get; set; } = false;

        public bool IsJPGDownload { get; set; } = false;

    }

}
