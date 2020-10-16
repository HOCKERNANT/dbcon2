using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbcon2
{
    class vendors
    {
        private int m_Vid;
        public int vend_id { get { return m_Vid; } set { m_Vid = value; } }

        private string m_Vname;
        public string vend_name { get { return m_Vname; } set { m_Vname = value; } }

        private string m_Vaddress;
        public string vend_address { get { return m_Vaddress; } set { m_Vaddress = value; } }

        private string m_Vcity;
        public string vend_city { get { return m_Vcity; } set { m_Vcity = value; } }

        private string m_Vstate;
        public string vend_state { get { return m_Vstate; } set { m_Vstate = value; } }

        private string m_Vzip;
        public string vend_zip { get { return m_Vzip; } set { m_Vzip = value; } }

        private string m_Vcountry;
        public string vend_country { get { return m_Vcountry; } set { m_Vcountry = value; } }

        public override string ToString()
        {
            return m_Vname + ", " + m_Vcity;
        }

    }
}
