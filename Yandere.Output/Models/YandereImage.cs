using System;
using System.Collections.Generic;
using System.Text;

namespace Yandere.Output.Models
{
    public class YandereImage
    {
        public int id { get; set; }
        public string tags { get; set; }
        public long? created_at { get; set; }
        public long? updated_at { get; set; }
        public int? creator_id { get; set; }
        public string approver_id { get; set; }
        public string author { get; set; }
        public int? change { get; set; }
        public string source { get; set; }
        public double score { get; set; }
        public string md5 { get; set; }
        public long? file_size { get; set; }
        public string file_ext { get; set; }
        public string file_url { get; set; }
        public bool? is_shown_in_index { get; set; }
        public string preview_url { get; set; }
        public long? preview_width { get; set; }
        public long? preview_height { get; set; }
        public long? actual_preview_width { get; set; }
        public long? actual_preview_height { get; set; }
        public string sample_url { get; set; }
        public long? sample_width { get; set; }
        public long? sample_height { get; set; }
        public long? sample_file_size { get; set; }
        public string jpeg_url { get; set; }
        public long? jpeg_width { get; set; }
        public long? jpeg_height { get; set; }
        public long? jpeg_file_size { get; set; }
        public string rating { get; set; }
        public bool? is_rating_locked { get; set; }
        public bool? has_children { get; set; }
        public int? parent_id { get; set; }
        public string status { get; set; }
        public bool? is_pending { get; set; }
        public long? width { get; set; }
        public long? height { get; set; }
        public bool? is_held { get; set; }
        public string frames_pending_string { get; set; }
        public string[] frames_pending { get; set; }
        public string frames_string { get; set; }
        public string[] frames { get; set; }
        public string is_note_locked { get; set; }
        public int? last_noted_at { get; set; }
        public int? last_commented_at { get; set; }
    }

    public enum ImageType
    {
        JPG,PNG
    }
}
