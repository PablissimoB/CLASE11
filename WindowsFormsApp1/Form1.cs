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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archivo.txt");

            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }
            try
            {
                
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    sw.WriteLine(texto);
                }

                textBox1.Clear();
                MessageBox.Show("Texto guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }
    }
}
