using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckboxFor.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Editing { get; set; }
        public string Detail { get; set; }
        public string Deleting { get; set; }


        public bool IsCheck1 { get; set; }
        public bool IsCheck2 { get; set; }
        public bool IsCheck3 { get; set; }


    }
}