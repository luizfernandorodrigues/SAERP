using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAERP.Models
{
    public class A23Estado
    {
        public int ukey { get; set; }
        public string nome { get; set; }
        public string sigla { get; set; }

        public A22Pais A22Pais  { get; set; }
        public int a22_ukey { get; set; }
    }
}