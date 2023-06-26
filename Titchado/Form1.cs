using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titchado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private Bitmap originalImage;
        private Bitmap compressedImage;

        private Bitmap CompressImage(Bitmap image)
        {
            Bitmap compressed = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    // Reduz a quantidade de cores para comprimir a imagem
                    int red = (pixel.R / 32) * 32;
                    int green = (pixel.G / 32) * 32;
                    int blue = (pixel.B / 32) * 32;

                    Color newPixel = Color.FromArgb(red, green, blue);
                    compressed.SetPixel(x, y, newPixel);
                }
            }

            return compressed;
        }

        private Bitmap ComprimeSemPerdas(Bitmap image)
        {
            List<Color> pixels = new List<Color>();

            // Convertendo a imagem em uma sequência de pixels
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    pixels.Add(pixel);
                }
            }

            List<Run> runs = new List<Run>();

            // Executando o algoritmo RLE nos pixels
            Run currentRun = new Run(pixels[0]);

            for (int i = 1; i < pixels.Count; i++)
            {
                Color currentPixel = pixels[i];

                if (currentPixel == currentRun.Color && currentRun.Count < 255)
                {
                    currentRun.Count++;
                }
                else
                {
                    runs.Add(currentRun);
                    currentRun = new Run(currentPixel);
                }
            }

            runs.Add(currentRun);

            // Convertendo os runs comprimidos de volta em uma imagem
            Bitmap compressed = new Bitmap(image.Width, image.Height);
            int index = 0;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = runs[index].Color;
                    compressed.SetPixel(x, y, pixel);

                    runs[index].Count--;

                    if (runs[index].Count == 0)
                        index++;
                }
            }

            return compressed;
        }

        private class Run
        {
            public Color Color { get; }
            public int Count { get; set; }

            public Run(Color color)
            {
                Color = color;
                Count = 1;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens (*.bmp;*.jpg;*.png;*jpeg;)|*.bmp;*.jpg;*.png;*jpeg;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    pbOriginal.Image = originalImage;
                }
            }
        }

        private void btnSalvaImg_Click(object sender, EventArgs e)
        {
            if (pbCompressed.Image == null)
            {
                MessageBox.Show("A imagem resultante não pode ser salva porque ela não existe.");
                return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Imagem JPEG|*.jpg|Imagem PNG|*.png|Todos os arquivos|*.*";
            saveFileDialog1.Title = "Salvar Imagem Resultante";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                ImageFormat format;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        format = ImageFormat.Jpeg;
                        break;
                    case 2:
                        format = ImageFormat.Png;
                        break;
                    case 3:
                        format = ImageFormat.Tiff;
                        break;
                    default:
                        format = ImageFormat.Jpeg;
                        break;
                }

                pbCompressed.Image.Save(saveFileDialog1.FileName, format);
                MessageBox.Show("Imagem salva", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Selecione uma imagem antes de comprimir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            compressedImage = CompressImage(originalImage);
            pbCompressed.Image = compressedImage;
        }

        private void btnBonito_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Selecione uma imagem antes de comprimir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            compressedImage = ComprimeSemPerdas(originalImage);
            pbCompressed.Image = compressedImage;
        }
    }
}
