using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Securely
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e) { FadeForm(); }

        private void Button_Form_Control_Close_Click(object sender, EventArgs e) { Close(); }

        private void Button_Form_Control_Minimise_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void Move_Form(object sender, MouseEventArgs e) { ReleaseCapture(); SendMessage(this.Handle, 0xA1, 0x2, 0); }

        private void Button_Folder_Browser_Click(object sender, EventArgs e) { PickFolder(); }
    }
}
