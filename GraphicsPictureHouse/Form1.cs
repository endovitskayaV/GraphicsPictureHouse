using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraphicsPictureHouse
{
    public partial class Form1 : Form
    {
        Graphics gScreen;
        Graphics gBitmap;
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            gBitmap = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gScreen = CreateGraphics();
            bitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            gBitmap = Graphics.FromImage(bitmap); //?
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            MyClass.Draw(e.Graphics);
            gScreen.DrawImage(bitmap, ClientRectangle);
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            this.Text = " " + e.X + " " +e.Y;
        }
    }
}
