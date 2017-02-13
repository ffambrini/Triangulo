using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication2
{
    public partial class WinTriangulo : Form
    {
        public WinTriangulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txt1.Text = ""; Txt2.Text = ""; Txt3.Text = ""; Txt4.Text = ""; Txt5.Text = ""; Txt6.Text = ""; Txt7.Text = ""; Txt8.Text = ""; Txt9.Text = ""; Txt10.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Precisa capturar os Números no formato de ponto flutuante, tem que usar Virgula
            Double a = Convert.ToDouble(Txt1.Text);
            Double b = Convert.ToDouble(Txt2.Text);
            Double c = Convert.ToDouble(Txt3.Text);

            Double p = (a + b + c) / 2;

            Double Area = p * (p - a) * (p - b) * (p - c);  // Formula de Heron
            
            double raiz = Math.Sqrt(Area);   // Para calcular a Raiz Quadrada

            Txt4.Text = Convert.ToString(raiz);

             double ang1 =  Math.Acos(  (  b*b  +  c*c  - a*a )   /  (2*b*c)   );
             double ang2 =  Math.Acos(  (  a*a   +  b*b -  c*c)  /   (2*a*b)   );
             double ang3 =  Math.Acos(  (  a*a +    c*c  - b*b)  / (2*a*c)   );

            //Convertendo os angulos de Radianos para Graus:
            ang1 = ang1 * (180 / Math.PI);
            ang2 = ang2 * (180 / Math.PI);
            ang3 = ang3 * (180 / Math.PI);

            Txt5.Text = Convert.ToString(ang1);
            Txt7.Text = Convert.ToString(ang2);
            Txt6.Text = Convert.ToString(ang3);

            // Calculo das 3 alturas relativas a cada um dos lados do triangulo
            // Utiliza a Formula:  Area = (base x Haltura) / 2

           double h1 = 2 * raiz / a;
           double h2 = 2 * raiz / b;
           double h3 = 2 * raiz / c;

           Txt8.Text = Convert.ToString(h1);
           Txt10.Text = Convert.ToString(h2);
           Txt9.Text = Convert.ToString(h3);





        }
    }
}
