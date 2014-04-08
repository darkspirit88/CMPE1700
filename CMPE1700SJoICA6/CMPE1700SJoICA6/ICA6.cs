using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1700SJoICA6
{
    public partial class ICA6 : Form
    {
        public CDrawer canvas = new CDrawer(800,600);
        public Color [ , ] colors = new Color [60,80];
        public Color fillColor = new Color();
        DialogResult result = new DialogResult();
        int x;
        int y;
        int blocks;
        
        
        public ICA6()
        {
            InitializeComponent();
            canvas.Scale = 10;
            canvas.ContinuousUpdate = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            Random generator = new Random();
        

            for (x = 0; x < colors.GetLength(0); x++)
            {    
                for (y = 0; y < colors.GetLength(1); y++)
                 {  
                    colors[x, 0] = Color.Black;
                    colors[x, colors.GetLength(1) -1] = Color.Black;
                    colors[0 , y] = Color.Black;
                    colors[0 , colors.GetLength(0)-1] = Color.Black;
                 }
            }
                    
                    

            for (x = 0; x < colors.GetLength(0); x++)
            {
                colors[x, 0] = Color.Red;
                colors[x, colors.GetLength(1)-1] = Color.Red;
            }

            for (y = 0; y < colors.GetLength(1); y++)
            {
                colors[0, y] = Color.Red;
                colors[colors.GetLength(0) - 1, y] = Color.Red;
            }
                    

            for (blocks = 0; blocks <= trbBlock.Value; blocks++)
            {
                x = generator.Next(colors.GetLength(0) - 1);
                y = generator.Next(colors.GetLength(1) - 1);
                colors[x, y] = Color.Red;
                canvas.SetBBScaledPixel(y, x, colors[x, y]);
            }

            for (x = 0; x < colors.GetLength(0); x++)
                for (y = 0; y < colors.GetLength(1); y++)
                    canvas.SetBBScaledPixel(y, x, colors[x, y]);

            canvas.Render();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            timerClick.Enabled = true;
        }

        void FloodFill(int x, int y, Color target, Color Replacement)
        {
            if (colors[y, x] != target)
                return;
            if (colors[y, x] == Replacement)
                return;

            colors[y, x] = Replacement;

            
            if (x + 1 < colors.GetLength(1))
                FloodFill(y, x + 1, target, Replacement);
            if (x - 1 >= 0)
                FloodFill(y, x - 1, target, Replacement);
            if (y + 1 < colors.GetLength(0))
                FloodFill(y + 1, x, target, Replacement);
            if (y - 1 >= 0)
                FloodFill(y - 1, x, target, Replacement);

        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                fillColor = colorDialog1.Color;

        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            Point pointDraw;    //point to draw the circle


            if (canvas.GetLastMouseLeftClick(out pointDraw))
            {

                
            }
        }

    }
}
