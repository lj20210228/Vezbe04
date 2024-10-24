using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace WinForms.utils
{
    internal class GradUtil
    {
        public static List<Grad> gradovi { get; set; } = new List<Grad>()
        {
            new Grad()
            {
                Ptt=11000,
                Naziv="Beograd",
            },
             new Grad()
            {
                Ptt=21000,
                Naziv="Novi Sad",
            },
              new Grad()
            {
                Ptt=31000,
                Naziv="Uzice",
            },
               new Grad()
            {
                Ptt=32000,
                Naziv="Cacak",
            },
        };
    }
}
