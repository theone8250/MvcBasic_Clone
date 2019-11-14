using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcBasic_Clone.Models;

namespace MvcBasic_Clone.ViewModels
{
    public class PeopleViewModel
    {
        public List<Employee> Emplooyees { get; set; }
        public List<Friend> Friends { get; set; }
    }
}