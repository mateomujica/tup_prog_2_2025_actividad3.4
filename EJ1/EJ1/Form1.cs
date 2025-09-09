using EJ1.Models;
using System.Collections;

namespace EJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList figuras = new ArrayList();

        private void btnCrearFig_Click(object sender, EventArgs e)
        {

            if (rBortoedro.Checked == true)
            {


                double ancho = Convert.ToDouble(tbxAncho.Text);
                double alto = Convert.ToDouble(tbxAltoOrt.Text);
                double largo = Convert.ToDouble(tbxLargo.Text);

                Figura nueva = new Ortoedro(ancho, alto, largo);
                figuras.Add(nueva);
                /*lsbInfo.Items.Add(nueva.Describir());*/

            }

            if (rBcilindro.Checked == true)
            {

                double radio = Convert.ToDouble(tbxRadio.Text);
                double alto2 = Convert.ToDouble(tbxAltoCil.Text);

                Figura nueva = new Cilindro(radio, alto2);
                figuras.Add(nueva);
                //lsbInfo.Items.Add(nueva.Describir());
            }

            rBortoedro.Checked = false;
            rBcilindro.Checked = false;
            tbxAncho.Clear();
            tbxAltoOrt.Clear();
            tbxLargo.Clear();
            tbxRadio.Clear();
            tbxAltoCil.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsbInfo.Items.Clear();

            foreach (Figura f in figuras)
            {
                lsbInfo.Items.Add(f);
            }
        }

        private void btnOrdenarPArea_Click(object sender, EventArgs e)
        {
            lsbInfo.Items.Clear();

            figuras.Sort();

          
            foreach (Figura f in figuras)
            {
                lsbInfo.Items.Add(f);
            }
        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            Figura seleccionado = lsbInfo.SelectedItem as Figura;

            if (seleccionado != null)
            {
                lsbMasInfo.Items.Add("");
                lsbMasInfo.Items.Add(seleccionado.Describir());

            }
            else { MessageBox.Show("No se a seleccionado una figura "); }
        }
    }
    
}
