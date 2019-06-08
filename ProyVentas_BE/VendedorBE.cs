using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyVentas_BE
{
    public class VendedorBE
    {
        private String  mvarcod_ven;
        public String Cod_Ven
        {
            get { return mvarcod_ven; }
            set { mvarcod_ven = value; }
        }
        private String mvarnom_ven;
        public String Nom_Ven
        {
            get { return mvarnom_ven; }
            set { mvarnom_ven = value; }
        }
        private String mvarape_ven;
        public String Ape_Ven
        {
            get { return mvarape_ven; }
            set { mvarape_ven = value; }
        }
        
        private Single mvarsue_ven;
        public Single Sue_Ven
        {
            get { return mvarsue_ven; }
            set { mvarsue_ven = value; }
        }
                  
        private System.DateTime mvarfec_ing;
        public System.DateTime Fec_ing
        {
            get { return mvarfec_ing; }
            set { mvarfec_ing = value; }
        }
         private String mvartip_ven;
        public String Tip_Ven
        {
            get { return mvartip_ven; }
            set { mvartip_ven = value; }
        }
}
    }

