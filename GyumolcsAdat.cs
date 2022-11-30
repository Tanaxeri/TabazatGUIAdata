using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabazatGUIAdata
{
    internal class GyumolcsAdat
    {

        int id;
        string gyumnev;
        double egysegar;
        double mennyiseg;

        public int Id { get => id; set => id = value; }
        public string Gyumnev { get => gyumnev; set => gyumnev = value; }
        public double Egysegar { get => egysegar; set => egysegar = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public GyumolcsAdat(int id, string gyumnev, double egysegar, double mennyiseg)
        {
            Id = id;
            Gyumnev = gyumnev;
            Egysegar = egysegar;
            Mennyiseg = mennyiseg;
        }



    }
}
