﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.SocialMediaDtos
{
    public class UpdateSocialMediaDto
    {
        public int SocialMediaId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Icon { get; set; }
    }
}
