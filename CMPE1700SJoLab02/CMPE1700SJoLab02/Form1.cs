using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1700SJoLab02
{     
    public partial class Form1 : Form
    {
        public enum MineState
        {
            Invisible, Visible, Guess
        }
        public struct Mine
        {
            public MineState _mine;
            public string _value;

            public Mine(MineState mine, string value)
            {
                _mine = mine;
                _value = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            CDrawer Canvas = new CDrawer(10, 10);
            Canvas.Scale = 50;

            Canvas.Clear();


        }
    }
}
