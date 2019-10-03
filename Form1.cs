using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentBanco.Builder;
using FluentBanco.Models;


namespace FluentBanco
{
    public partial class Form1 : Form
    {

        List<Cuenta> Cuentas = new List<Cuenta>();

        public Form1()
        {
            InitializeComponent();
            comboBox1TipodeC.SelectedIndex = 0;
        }

            private void Form1_Load(object sender , EventArgs e)
        {

        }

        private void TextBoxNumDeC_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonGenerar_Click(object sender, EventArgs e)
        {
            string aux = textBoxNumDeC.Text;
            bool[] flag = new bool[4];

            for (int i = 0; i < aux.Length; i++)
            {
                if (Char.IsDigit(aux[i]) == false)
                {
                    flag[0] = true;
                    break;
                }
            }

            aux = textBoxPropietario.Text;

            if (aux.Length == 0)
            {
                flag[1] = true;
            }

            aux = textBoxTasa.Text;
            int puntos = 0;

            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == '.')
                    puntos++;

                else if (Char.IsDigit(aux[i]) == false || puntos > 1)
                {
                    flag[2] = true;
                    break;
                }
            }

            aux = textBoxSaldoInicial.Text;
            puntos = 0;

            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == '.')
                    puntos++;

                else if (Char.IsDigit(aux[i]) == false || puntos > 1)
                {
                    flag[3] = true;
                    break;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (flag[i] == true)
                {
                    MessageBox.Show("Los datos ingresados son incorrectos.");
                    return;
                }
            }

            if (textBoxNumDeC.Text == "" || textBoxPropietario.Text == "" || textBoxTasa.Text == "" || textBoxSaldoInicial.Text == "" )
            {
                MessageBox.Show("Uno o más campos están vacíos.");
                return;
            }

            Tipo tipo = (Tipo)Enum.Parse(typeof(Tipo), comboBox1TipodeC.SelectedItem.ToString());

            Cuenta cuentanueva = CuentaFluentBuilder.Crear(tipo)
                .NumeroCuenta(Int32.Parse(textBoxNumDeC.Text))
                .Propietario(textBoxPropietario.Text)
                .Tasa(double.Parse(textBoxTasa.Text))
                .SaldoInicial(double.Parse(textBoxSaldoInicial.Text))
                .AbrirCuenta();

            Cuentas.Add(cuentanueva);

            var source = new BindingSource(Cuentas, null);
            dataGridView1.DataSource = source;

            MessageBox.Show("La cuenta se creó correctamente.");

        }

        //public void ComboBox1TipodeC_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    comboBox1TipodeC.SelectedItem = Tipo.Basic;
            
        //}
    }
}
