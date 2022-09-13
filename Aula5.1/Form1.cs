using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5._1
{
    public partial class Form1 : Form
    {
        Time obj;
        Time[] v = new Time[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Time timinho = new Time("Brasil","SP");
            //MessageBox.Show("Nome: " + timinho.Nome + "\nPais: " + timinho.Pais + 
            //  "\nEstado: " + timinho.Estado + "\nTítulo: " + timinho.Titulo);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                obj = new Time();
                obj.Nome = txtNome.Text;
                obj.Pais = txtPais.Text;
                obj.Estado = txtEstado.Text;
                obj.Titulo = Convert.ToInt32(txtTitulo.Text);
                v[i] = obj;
                i++;
            }
            else
            {
                MessageBox.Show("Não é possível gravar");
            }

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            for(int j = 0; j < 10; j++)
            {
                if (v[j].Nome.Equals(txtNome.Text))
                {
                    txtEstado.Text = v[j].Estado;
                    txtPais.Text = v[j].Pais;
                    txtTitulo.Text = v[j].Titulo.ToString();
                    j = 9;
                }
                else
                {
                    if (j == 9) MessageBox.Show("Time não encontrado");
                }
            }
        }
    }
}
