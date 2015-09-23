using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDeJagged
{
    public partial class Form1 : Form
    {
        int cont = 0;
        float prom;
        float min = 10.0f;
        float max = 0.0f;

        int salones;
        int alumnos;
        int calificacione;
        int pos;
        int mostrar;
        float total;
        ArrayList calificaciones;

        public Form1()
        {
            InitializeComponent();
            calificaciones = new ArrayList();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            salones = Convert.ToInt32(textBox1.Text);
            alumnos = Convert.ToInt32(textBox2.Text);

            int[][] salon = new int[salones][];

            for (int i = 0; i < salones; i++)
            {
                salon[i] = new int[alumnos];
            }
            button1.Text = "Mostrar";
            
            if (calificacione > 0)
            {

                for (int i = 0; i < salon.Length; i++)
                {
                    for (int x = 0; x < salon[i].Length; x++)
                    {
                        total += salon[i][x] = Int32.Parse(calificaciones[pos++].ToString());
                        prom = total / cont;
                        if (max<salon[i][x])
                        {
                            max = salon[i][x];
                        }

                        if (min > salon[i][x])
                        {
                            min = salon[i][x];
                        }

                    }
                }

                listBox1.Items.Add("Lista de Calificaciones");

                for (int i = 0; i < salon.Length; i++)
                {
                    listBox1.Items.Add("Salon " + (i + 1));
                    for (int x = 0; x < salon[i].Length; x++)
                    {
                        listBox1.Items.Add(calificaciones[mostrar++]);
                    }
                }
                listBox1.Items.Add("El Total es: "+total);
          
                textBoxPromedio.Text = prom.ToString();

                textBoxMayor.Text = max.ToString();

                textBoxMenor.Text = min.ToString();
            }

          }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
            cont++;
            calificacione = Convert.ToInt32(textBox3.Text);
            calificaciones.Add(calificacione);
            MessageBox.Show("Guardada.");
        }
    }
}
