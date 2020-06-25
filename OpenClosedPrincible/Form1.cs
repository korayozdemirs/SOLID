using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenClosedPrincible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger lg = new Logger(new SystemLog());
            lg.Log("test");

            //Logger lg = new Logger(new XmlLog(), new DbLog(),new FileLog());
            //lg.Log(LogType.Db, "deger");
        }
    }
}
