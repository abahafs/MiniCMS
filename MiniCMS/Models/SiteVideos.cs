﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MiniCMS.Models
{
    public class SiteVideos
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Link { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public Users user { get; set; }

        public int LangId { get; set; }
        [ForeignKey("LangId")]
        public Language Lang { get; set; }

    }
}