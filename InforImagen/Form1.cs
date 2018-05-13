using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InforImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ubicacion = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Title = "Abrir";
            Open.Filter = "Jpg files (*.jpg)|*.jpg|Gif files (*.gif)|*.gif|Bitmap files (*.Bmp)|*.bmp|PNG files (*.png)|*.png*";

            if (Open.ShowDialog() == DialogResult.OK)
            {
                ubicacion = Open.FileName;
                pictureBox1.ImageLocation = ubicacion;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = pictureBox1.Size.Height.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = pictureBox1.Size.Width.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@ubicacion, FileMode.Open, FileAccess.Read);

            //Se inicializa un arreglo de Bytes del tamaño de la imagen
            byte[] binData = new byte[stream.Length];
            textBox3.Text=binData.Length.ToString();
        }
    }
}
