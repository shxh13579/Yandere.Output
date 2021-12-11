using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandere.Output.Models
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
