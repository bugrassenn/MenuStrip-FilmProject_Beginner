using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace _1_MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // messagebox 4 parametrisini aynı anda kullandık içerik, başlık, buton ve icon
            MessageBox.Show("This project was made by Alpaslan Buğra Şen","İnfo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=hEJnMQG9ev8");
            label1.Text = "Mad Max";
          
        }

        private void ıLoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "I Love You";
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=TJU061IOMMU");
        }

        private void fastAndForuisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Fast And Furious";
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=eoOaKN4qCKw");
        }

        private void extractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Extraction";
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=L6P3nI6VnlY");
        }

        private void romeoJulietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Romeo + Juliet";
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=8VOAxzgq42A");
        }

        private void redeemingLoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Redeeming Love";
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=_8RIlIOd_us");
        }

        private void unchartedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Uncharted";
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=eHp3MbsCbMg");
        }

        private void blackWidowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Black Widow";
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=ybji16u608U");
        }

        private void loganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Logan";
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=Div0iP65aZo");
        }

        private void batmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Batman";
            chromiumWebBrowser1.LoadUrl("https://www.youtube.com/watch?v=neY2xVmOfUM");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
