using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helth1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrintPreviewbutton_Click(object sender, EventArgs e)
        {
            finaltextBox.Text = (Convert.ToString(PatienttextBox.Text + " Rpt No.") + Convert.ToString(LabtextBox.Text).ToString());
            // richTextBox1.Text = (Convert.ToInt32(textBox.Text) + Convert.ToInt32(textBox1.Text).ToString());
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

            pictureBox.Image = barcode.Draw(finaltextBox.Text, 30);
            SharmaprintPreviewDialog.Document = SharmaprintDocument;
            SharmaprintPreviewDialog.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BiorichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMorebutton_Click(object sender, EventArgs e)
        {
            TestNametextBox1.Show();
            TestNametextBox2.Show();
            TestNametextBox3.Show();
            TestNametextBox4.Show();
            TestNametextBox1.Focus();
            Add.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            TtextBox2.Show();
            TtextBox3.Show();
            TtextBox4.Show();
            TtextBox5.Show();
            TtextBox2.Focus();
            Add1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Add1_Click(object sender, EventArgs e)
        {
            fourthtextbox1.Show();
            fourthtextbox2.Show();
            fourthtextbox3.Show();
            fourthtextbox4.Show();
            fourthtextbox1.Focus();
            Add2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add2_Click(object sender, EventArgs e)
        {
            fifthbo1.Show();
            fifthBox2.Show();
            fifthBox3.Show();
            fifthBox4.Show();
            fifthbo1.Focus();
            

        }

        private void SharmaprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = Properties.Resources.appp;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 1, 0, newImage.Width, newImage.Height);
            Bitmap bm = Properties.Resources.rtpp;
            Image imm = bm;
            e.Graphics.DrawImage(imm, 0, 180, imm.Width, imm.Height);
            e.Graphics.DrawString("Patient Name :" + "  " + PatienttextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 220));
            e.Graphics.DrawString("Lab No :             " + "    " + LabtextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 220));
            e.Graphics.DrawString("Age/Gender :   " + " " + AgetextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 245));
            e.Graphics.DrawString("Collection At :        " + " " + CollectionattextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 245));
            e.Graphics.DrawString("Ref. By :           " + " " + RefbytextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 270));
            e.Graphics.DrawString("Reg. Date :            " + " " + RegDatedateTimePicker.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 270));
            e.Graphics.DrawString("Panel :             " + " " + PaneltextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 295));
            e.Graphics.DrawString("Sample Received :" + " " + SampleReceiveddateTimePicker.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 295));
            e.Graphics.DrawString("Ref. By Dr. :     " + " " + ReferredbudoctortextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 320));
            e.Graphics.DrawString("Result Report :      " + " " + ResultReportdateTimePicker.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 320));
            e.Graphics.DrawString(" " + " " + BiorichTextBox.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(275, 390));
            e.Graphics.DrawString("Test Name : ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(20, 450));
            e.Graphics.DrawString("Result : ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(200, 450));
            e.Graphics.DrawString("Unit : ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(400, 450));
            e.Graphics.DrawString("Ref. Range : ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(600, 450));
            e.Graphics.DrawString("" + TestNametextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(20, 480));
            e.Graphics.DrawString("" + RsulttextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, 480));
            e.Graphics.DrawString("" + UnittextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 480));
            e.Graphics.DrawString("" + RefRangetextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 480));
            e.Graphics.DrawString("" + TestNametextBox1.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(20, 510));
            e.Graphics.DrawString("" + TestNametextBox2.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, 510));
            e.Graphics.DrawString("" + TestNametextBox3.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 510));
            e.Graphics.DrawString("" + TestNametextBox4.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 510));
            e.Graphics.DrawString("" + TtextBox2.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(20, 540));
            e.Graphics.DrawString("" + TtextBox3.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, 540));
            e.Graphics.DrawString("" + TtextBox4.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 540));
            e.Graphics.DrawString("" + TtextBox5.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 540));
            e.Graphics.DrawString("" + fourthtextbox1.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(20, 570));
            e.Graphics.DrawString("" + fourthtextbox2.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, 570));
            e.Graphics.DrawString("" + fourthtextbox3.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 570));
            e.Graphics.DrawString("" + fourthtextbox4.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 570));
            e.Graphics.DrawString("" + fifthbo1.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(20, 600));
            e.Graphics.DrawString("" + fifthBox2.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(200, 600));
            e.Graphics.DrawString("" + fifthBox3.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(400, 600));
            e.Graphics.DrawString("" + fifthBox4.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 600));
            e.Graphics.DrawString("Dr. A.K GUPTA", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(650, 1030));
            e.Graphics.DrawString("M.D Pathologist", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(655, 1060));
            // e.Graphics.DrawString(Dashlabel.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 1100));
            Pen blackPen = new Pen(Color.Black, 2);


            int x1 = 0;
            int y1 = 1125;
            int x2 = 900;
            int y2 = 1125;


            e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
            Pen blackPe = new Pen(Color.Black, 2);


            int x = 40;
            int y = 210;
            int width = 727;
            int height = 140;


            e.Graphics.DrawRectangle(blackPe, x, y, width, height);
            e.Graphics.DrawString("Email:sharmahealthsquare@gmail.com  Web:sharmahealthsquare.com  Online/Offline Services Available", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(12, 1130));
            Image im = pictureBox.Image;
            e.Graphics.DrawImage(im, 15, 150, im.Width, im.Height);
        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            SharmaprintDocument.Print();
        }

        private void shrmagroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
