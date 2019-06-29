using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyVentas_BE
{
  public  class ProveedorBE
    {
        private String mvarcod_prv;
        public String Cod_prv
        {
            get { return mvarcod_prv; }
            set { mvarcod_prv = value; }
        }
        private String mvarraz_soc_prv;
        public String Raz_soc_prv
        {
            get { return mvarraz_soc_prv; }
            set { mvarraz_soc_prv = value; }
        }
        private String mvardir_prv;
        public String Dir_prv
        {
            get { return mvardir_prv; }
            set { mvardir_prv = value; }
        }

        private String mvartel_prv;
        public String Tel_prv
        {
            get { return mvartel_prv; }
            set { mvartel_prv = value; }
        }

        private String mvarcod_dis;
        public String Cod_dis
        {
            get { return mvarcod_dis; }
            set { mvarcod_dis = value; }
        }
        private String mvarrep_ven;
        public String Rep_ven
        {
            get { return mvarrep_ven; }
            set { mvarrep_ven = value; }
        }
    }
}
