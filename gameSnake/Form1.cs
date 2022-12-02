using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gameSnake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        int gamestart = 0;
        joculsarpe joc = new joculsarpe();

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            joc.tabladejocsarpe = new tabladejoc(10, 10, 1);
            joc.tabladejocsarpe.drawTabladejoc(ref g);
            joc.sarpele.elementelesarpelui.Add(new elementsnake());
            //button1.Enabled = false;
            button1.Text = "STOP";
            joc.showCapulSarpelui( this );
            timer1.Start();
            gamestart = 1;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
                
       }

        public void createnewelementreltiveposition()
        {
            //add a new element in coada
            joc.sarpele.elementelesarpelui.Add(new elementsnake());
            joc.sarpele.elementelesarpelui[joc.sarpele.elementelesarpelui.Count - 1].X = joc.sarpele.elementelesarpelui[joc.sarpele.elementelesarpelui.Count - 2].X - 10;
            joc.sarpele.elementelesarpelui[joc.sarpele.elementelesarpelui.Count - 1].Y = joc.sarpele.elementelesarpelui[joc.sarpele.elementelesarpelui.Count - 2].Y - 10;
            joc.showElementulPatrateSarpele(this, Controls.Count - 1);
        }

        public void createandmovesnake()
        {

            //move tail to newposxy

            for (int i = joc.sarpele.elementelesarpelui.Count; i >= 1; i--)
            {
                try
                {
                    joc.sarpele.elementelesarpelui[i].X = joc.sarpele.elementelesarpelui[i - 1].X;
                    joc.sarpele.elementelesarpelui[i].Y = joc.sarpele.elementelesarpelui[i - 1].Y;

                }
                catch { }
            }

            //update patratele de pe form1
            for (int i = joc.elementelepatrat.Count; i >= 1; i--)
            {
                try
                {
                    joc.elementelepatrat[i].Left = joc.elementelepatrat[i - 1].Left;
                    joc.elementelepatrat[i].Top = joc.elementelepatrat[i - 1].Top;

                }
                catch { }
            }

        
        }

        public void createnelemenets()
        {
            // joc.showElementelePatrateSarpele(this);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {


            
           


        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gamestart == 1)
            {
                joc.keypressed = e.KeyValue.ToString();
                Text = e.KeyValue.ToString();

                if (joc.keypressed == "68")
                {
                    if (joc.capulsarpelui.Left < 200)
                    {
                        joc.capulsarpelui.Left += 10;
                    }
                }
                else if (joc.keypressed == "65")
                {
                    if (joc.capulsarpelui.Left > 0)
                    {
                        joc.capulsarpelui.Left -= 10;
                    }
                }
                else if (joc.keypressed == "87")
                {
                    if (joc.capulsarpelui.Top > 0)
                    {
                        joc.capulsarpelui.Top -= 10;
                    }
                }
                else if (joc.keypressed == "83")
                {
                    if (joc.capulsarpelui.Top < 200)
                    {
                        joc.capulsarpelui.Top += 10;
                    }
                }


                //create new element of snake

                joc.sarpele.elementelesarpelui.Add(new elementsnake());
                joc.sarpele.elementelesarpelui[joc.sarpele.elementelesarpelui.Count - 1].X = joc.sarpele.elementelesarpelui[0].X;
                joc.sarpele.elementelesarpelui[joc.sarpele.elementelesarpelui.Count - 1].Y = joc.sarpele.elementelesarpelui[0].Y;
                joc.showElementulPatrateSarpele(this, Controls.Count - 1);

               

                //move cap to newposxy
                joc.sarpele.elementelesarpelui[0].X = joc.capulsarpelui.Left;
                joc.sarpele.elementelesarpelui[0].Y = joc.capulsarpelui.Top;


                //redraw tabla de joc
               
                joc.tabladejocsarpe.drawTabladejoc(ref g);
            }
        }
            
            
             
           
        
    }
}
