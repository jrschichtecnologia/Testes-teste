using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace WorkflowSolicitacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormSolicitacao_Click(object sender, EventArgs e)
        {
            try
            {
                string perfil = rdbFinanceiro.Checked ? rdbFinanceiro.Text : rdbOperacional.Checked ? rdbOperacional.Text : rdbFinanceiroMaster.Checked ? rdbFinanceiroMaster.Text : "";
                string nroConta = txtNroConta.Text;

                Library.SolicitacaoDescontoPendencia.frmSolicitacaoDescontoPendencia frm = new Library.SolicitacaoDescontoPendencia.frmSolicitacaoDescontoPendencia("T_FABRICION", perfil,nroConta,"");
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENÇÃO!!!");
            }            
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                string perfil = rdbFinanceiro.Checked ? rdbFinanceiro.Text : rdbOperacional.Checked ? rdbOperacional.Text : rdbFinanceiroMaster.Checked ? rdbFinanceiroMaster.Text : "";
                string nroConta = txtNroConta.Text;

                Library.SolicitacaoDescontoPendencia.frmConsultaSolicitacoesDescPend frm = new Library.SolicitacaoDescontoPendencia.frmConsultaSolicitacoesDescPend("T_FABRICION", perfil);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ATENÇÃO!!!");
            }
        }
    }
}