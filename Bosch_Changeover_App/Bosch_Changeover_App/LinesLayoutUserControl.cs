using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Bosch_Changeover_App
{
    public partial class LinesLayoutUserControl : UserControl
    {
      //  private static LinesLayoutUserControl _instance;

        private Panel mp;

        /*   public static LinesLayoutUserControl Instance
           {
               get
               {
                   if (_instance == null)
                       _instance = new LinesLayoutUserControl(mp);
                   return _instance;
               }
           }*/

        LineUserControl line1;
        LineUserControl line2;
        LineUserControl line3;
        int totalSize = 2;

        public LinesLayoutUserControl(Panel mainPanel)
        {
            mp = mainPanel;

            InitializeComponent();
            panelLine1.Height = mp.Height - 20;
            panelLine2.Height = mp.Height - 20;
            panelLine3.Height = mp.Height - 20;

            line1 = new LineUserControl(1);
            line2 = new LineUserControl(2);
        //    line2b = new LineUserControl(2);
            line3 = new LineUserControl(3);
            panelLine1.Controls.Add(line1);
            //  line1.Dock = DockStyle.Fill;
            //    panelLine1.Controls.Add(line2b);
            //line2b.Location = new Point(line2b.Location.X, line1.Location.Y + line1.Height);
           // line2b.Dock = DockStyle.Fill;
         //   line2b.BringToFront();

            panelLine2.Controls.Add(line2);
     //       line2.Dock = DockStyle.Fill;
    //        line2.BringToFront();

            panelLine3.Controls.Add(line3);
     //       line3.Dock = DockStyle.Fill;
     //       line3.BringToFront();
            



        }

        public void formResized()
        {
            panelLine1.Height = mp.Height - 20;
            panelLine2.Height = mp.Height - 20;
            panelLine3.Height = mp.Height - 20;



            if (mp.Width < panelLine2.Width + panelLine2.Location.X && totalSize == 2)
            {
                shrink();
                shrink();
            }

            else if (mp.Width < panelLine3.Width + panelLine3.Location.X && totalSize == 2)
            {
                shrink();
            }



            else if (mp.Width < panelLine2.Width + panelLine2.Location.X && totalSize == 1)
            {
                shrink();
            }
            else if (mp.Width > panelLine3.Width + panelLine3.Location.X && totalSize == 1)
            {
                grow();
            }
            else if (mp.Width > panelLine3.Width + panelLine3.Location.X && totalSize == 0)
            {
                grow();
                grow();
            }
            else if (mp.Width > panelLine2.Width + panelLine2.Location.X && totalSize == 0)
            {
                grow();
            }



        }

        private void shrink()
        {
            if(totalSize == 2)
            {
   //             panelLine2.Controls.Remove(line2);
                panelLine3.Controls.Remove(line3);
 //               panelLine3.Controls.Add(line2);
                panelLine1.Controls.Add(line3);
                line3.Location = new Point(line3.Location.X, line1.Location.Y + line1.Height);
                totalSize = 1;
     //           panelLine3.Controls.Remove(line3);
      //          panelLine2.Controls.Remove(line2);
       //         panelLine2.Controls.Add(line3);
        //        panelLine1.Controls.Add(line2);
         //       line2.Location = new Point(line2.Location.X, line1.Location.Y + line1.Height);
          //      totalSize = 1;

            }
            else if(totalSize == 1)
            {
          //      panelLine2.Controls.Remove(line3);
        //        panelLine1.Controls.Add(line3);
      //          line3.Location = new Point(line3.Location.X, line2.Location.Y + line1.Height);
    //            totalSize = 0;
                panelLine2.Controls.Remove(line2);
                panelLine1.Controls.Add(line2);
                line2.Location = new Point(line2.Location.X, line3.Location.Y);
                line3.Location = new Point(line2.Location.X, line2.Location.Y + line1.Height);
                totalSize = 0;
            }
        }

        private void grow()
        {
            if (totalSize == 0)
            {
                //                panelLine1.Controls.Remove(line3);
                //               panelLine2.Controls.Add(line3);
                //              line3.Location = new Point(line3.Location.X, 0);
                //             totalSize = 1;
                panelLine1.Controls.Remove(line2);
                panelLine2.Controls.Add(line2);
                line3.Location = new Point(line3.Location.X, line1.Location.Y + line1.Height);
                line2.Location = new Point(line2.Location.X, 0);
                totalSize = 1;
            }
            else if (totalSize == 1)
            {
                //               panelLine1.Controls.Remove(line2);
                //              panelLine2.Controls.Remove(line3);
                //             panelLine2.Controls.Add(line2);
                //            panelLine3.Controls.Add(line3);
                //           line2.Location = new Point(line2.Location.X, 0);
                //          totalSize = 2;
                panelLine1.Controls.Remove(line3);
            //    panelLine3.Controls.Remove(line2);
                panelLine3.Controls.Add(line3);
                panelLine2.Controls.Add(line2);
                line3.Location = new Point(line3.Location.X, 0);
                totalSize = 2;
            }
        }
    }
}
