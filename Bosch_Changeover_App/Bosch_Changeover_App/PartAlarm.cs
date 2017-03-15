using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bosch_Changeover_App

{
    public partial class PartAlarm : UserControl
    {
        private int partType;
        private int lineNumber;
        private DateTime timeToLine;
        public PartAlarm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Panel)this.Parent).Controls.Remove(this);
        }
    }
}

