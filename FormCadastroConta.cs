using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBanco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

       public void Cadastrar_Click(object sender, EventArgs e)
        {
            //Conta novaConta = new ContaCorrente();

            int NovoCodigo = Convert.ToInt32(textNovoCodigo.Text);
            string NovoTitular = textNovoTitular.Text;

            //novaConta.CodigoDaConta = Convert.ToInt32(textNovoCodigo.Text);
            //novaConta.TitularDaConta = textNovoTitular.text;

            //novaConta.Titular = new Cliente(textoTitular.Text);
            //novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            this.formPrincipal.AdicionaConta(NovoCodigo, NovoTitular);

            // limpa as informações no TextBox
            textNovoCodigo.Clear();
            textNovoTitular.Clear();

        }

      

    }


    //public partial class FormCadastroConta : Form
    //{

    //    public FormCadastroConta()
    //    {
    //        InitializeComponent();
    //    }

    //    Ação de cadastro de conta
    //}
}
