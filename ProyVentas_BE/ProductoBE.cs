using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyVentas_BE
{
   public class ProductoBE
    {
        private String mvarcod_pro;
        public String Cod_Pro
        {
            get { return mvarcod_pro; }
            set { mvarcod_pro = value; }
        }

        private String mvarDes_pro;
        public String Des_Pro
        {
            get { return mvarDes_pro; }
            set { mvarDes_pro = value; }
        }


        private Single  mvarPre_pro;
        public Single Pre_Pro
        {
            get { return mvarPre_pro; }
            set { mvarPre_pro = value; }
        }

        private int  mvarStk_Act;
        public int Stk_Act
        {
            get { return mvarStk_Act; }
            set { mvarStk_Act = value; }
        }

        private int mvarStk_Min;
        public int  Stk_Min
        {
            get { return mvarStk_Min; }
            set { mvarStk_Min = value; }
        }

        private String mvarUni_med;
        public String Uni_Med
        {
            get { return mvarUni_med; }
            set { mvarUni_med = value; }
        }

        private String mvarLin_pro;
        public String Lin_Pro
        {
            get { return mvarLin_pro; }
            set { mvarLin_pro = value; }
        }
       
        private Boolean  mvarImportado;
        public Boolean Importado
        {
            get { return mvarImportado; }
            set { mvarImportado = value; }
        }
    }
}
