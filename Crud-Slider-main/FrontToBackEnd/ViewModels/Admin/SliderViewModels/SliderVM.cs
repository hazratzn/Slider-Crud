﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBackEnd.ViewModels.Admin.SliderViewModels
{
    public class SliderVM
    {
        public int Id { get; set; }
        
        [Required]
        public List<IFormFile> Photos { get; set; }
        [Required]
        public string Desc { get; set; }
    }
}
