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
    public partial class LineUserControl : UserControl
    {
        private static LineUserControl _instance;

        public static LineUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LineUserControl();
                return _instance;
            }
        }
        public LineUserControl()
        {
            InitializeComponent();
        }


    }
}
