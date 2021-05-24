using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_lab3
{
    public partial class Form1 : Form
    {
        View view = new View();
        GLgraphics glgraphics = new GLgraphics();
        public Form1()
        {
            InitializeComponent();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            glgraphics.Setup(glControl1.Width, glControl1.Height);
            view.InitShaders();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            
            glControl1.SwapBuffers();
        }
    }
}
