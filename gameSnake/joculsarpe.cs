using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gameSnake
{
    public class joculsarpe
    {
        public tabladejoc tabladejocsarpe = new tabladejoc(10, 10, 1);
        public sarpe sarpele = new sarpe(0, 0, 0);
        public string keypressed;
        public patrat capulsarpelui = new patrat();
        public List<patrat> elementelepatrat = new List<patrat>();
        public void showCapulSarpelui(Form1 form1)
        {
            elementelepatrat.Add(capulsarpelui);
            form1.Controls.Add(capulsarpelui);
            form1.Controls[1].Show();
            form1.Controls[1].Left = sarpele.elementelesarpelui[0].X;
            form1.Controls[1].Top = sarpele.elementelesarpelui[0].Y;
            
        }
        public void showElementelePatrateSarpele(Form1 form1)
        {
            for (int i = 2; i < elementelepatrat.Count; i++)
            {
                form1.Controls.Add(capulsarpelui);
                form1.Controls[i].Show();
                form1.Controls[i].Left = sarpele.elementelesarpelui[i-1].X;
                form1.Controls[i].Top = sarpele.elementelesarpelui[i-1].Y;
            }
        }

        public void showElementulPatrateSarpele(Form1 form1, int i)
        {
            
                form1.Controls.Add(new patrat());
                form1.Controls[i].Show();
                form1.Controls[i].Left = sarpele.elementelesarpelui[i - 1].X;
                form1.Controls[i].Top = sarpele.elementelesarpelui[i - 1].Y;
                
        }


        public joculsarpe() { }

      


    }
}
