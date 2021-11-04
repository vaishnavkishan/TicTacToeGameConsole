using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constants
{
    internal enum EPiece
    {
        [Display(Name ="-")]
        NA = 0,
        [Display(Name ="X")]
        X = 1,
        [Display(Name ="O")]
        O = 2
    }
}
