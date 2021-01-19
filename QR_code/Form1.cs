using MessagingToolkit.QRCode.Codec.Data;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_code
{
    public partial class Form1 : Form
    {
        Image file;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator codeGenerator = new QRCodeGenerator();
            QRCodeData codeData = codeGenerator.CreateQrCode(guna2TextBox1.Text,QRCodeGenerator.ECCLevel.H);
            QRCode code = new QRCode(codeData);
            file = code.GetGraphic(10);
            guna2PictureBox1.Image = code.GetGraphic(10);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPg Files | *.jpg";
           DialogResult result =  saveFileDialog1.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                file.Save(saveFileDialog1.FileName);
                MessageBox.Show("the code is saved");
            }
            else
            {
                MessageBox.Show("the code is not saved");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult result  =  openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                guna2PictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                file = Image.FromFile(openFileDialog1.FileName);
                MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                guna2TextBox1.Text = decoder.Decode(new QRCodeBitmapImage(guna2PictureBox1.Image as Bitmap));
                MessageBox.Show("the data is decoded ");
            }

        }
    }
}
