using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookmarks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Button t = new Button();
            t.Width = 240;
            t.Text = textBox1.Text;
            t.Click += new EventHandler((send,e)=>ClickLink(t.Text));
            LinkList.Controls.Add(t);
        }

        private void ClickLink(string text)
        {
            textBox2.Text = text;
        }
    }
}
