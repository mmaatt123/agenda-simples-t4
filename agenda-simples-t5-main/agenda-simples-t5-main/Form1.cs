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

namespace agenda_simples_t5
{
    public partial class Form1 : Form
    {
        private Contato[] ListaDeContatos = new Contato[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            Contato objetoContato = new Contato(txtNome.Text, txtSobrenome.Text, txtTelefone.Text, txtEmail.Text);
            lstContatos.Items.Add(objetoContato.ToString());
        }

        private void Escrever(Contato contato)
        {
            StreamWriter escrevedorDeArquivos = new StreamWriter("contato.txt");
            escrevedorDeArquivos.WriteLine(ListaDeContatos.Length + 1);
            escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
            escrevedorDeArquivos.WriteLine(contato.Sobrenome);
            escrevedorDeArquivos.WriteLine(contato.Telefone);
            escrevedorDeArquivos.WriteLine(contato.Email);
            for (int i = 0; i < ListaDeContatos.Length; i++)
            {
                escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
                escrevedorDeArquivos.WriteLine(contato.Sobrenome);
                escrevedorDeArquivos.WriteLine(contato.Telefone);
                escrevedorDeArquivos.WriteLine(contato.Email);
            }
        }
    }
}
