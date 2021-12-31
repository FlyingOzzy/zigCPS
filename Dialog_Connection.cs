using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HXApiTesterCS
{
    public partial class Dialog_Connection : Form
    {
        public string IP_Address { get; set; }

        public int PORT_Number { get; set; }

        public bool bOK { get; set; }





        public Dialog_Connection()
        {
            InitializeComponent();

            
            InitControls();

        }


        private void InitControls()
        {
            tb_ip.Text = "192.168.226.133";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            IP_Address = tb_ip.Text;

            int ival = 0;
            int.TryParse(tb_port.Text, out ival);
            PORT_Number = ival;

            bOK = true;

            this.Close();
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            bOK = false;
            this.Close();

        }

    }
}
