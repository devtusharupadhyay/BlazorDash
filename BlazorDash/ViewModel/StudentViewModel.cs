using BlazorDash.Models;
using BlazorDash.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDash.ViewModel
{
    public class StudentViewModel
    {
        public PaginatedList<Student> Students { get; set; }
    }
}
