using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyVentas_BE
{
    public class OrdenBE
    {
        private String mvarnumoco;
        private System.DateTime mvarfechaoc;
        private String mvarcodprv;
        private System.DateTime mvarfecate;
        private String mvarestoco;
        private DataTable Detalles;
                
        public String NumOco
        {
            get { return mvarnumoco; }
            set { mvarnumoco = value; }
        }
        public System.DateTime FecOco
        {
            get { return mvarfechaoc; }
            set { mvarfechaoc = value; }
        }
        public String CodPrv
        {
            get { return mvarcodprv; }
            set { mvarcodprv = value; }
        }
        public System.DateTime FecAte
        {
            get { return mvarfecate; }
            set { mvarfecate = value; }
        }
        public String EstOco
        {
            get { return mvarestoco; }
            set { mvarestoco = value; }
        }
        
        public DataTable DetallesOC
        {
            get { return Detalles; }
            set { Detalles = value; }

        }
    }
}
