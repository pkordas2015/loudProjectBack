using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoLoud.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }

        public int TotalPoints { get; set; }

        public int Likes { get; set; }

        public int Comments { get; set; }

        public int Shares { get; set; }
    }
}