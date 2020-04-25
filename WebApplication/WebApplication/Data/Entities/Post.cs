using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public string PictureSource { get; set; }
        public int UploaderId { get; set; }
        public User Uploader { get; set; }
    }
}
