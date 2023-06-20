using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AMSModels
{
    public class ImageViewModel
    {
        [Display(Name = "Browse File")]
        [Required(ErrorMessage = "Please Upload Vehicle Images.")]
        //[RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Only Image files allowed.")]
        public IFormFile[] Images { get; set; }
    }
}
