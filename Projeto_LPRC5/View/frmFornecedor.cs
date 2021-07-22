using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Projeto_LPRC5.View
{
    public partial class frmFornecedor : Form
    {

        public string strconsulta = "SELECT * FROM fornecedor;";
        classeFornecedor acesso = new classeFornecedor();


        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = acesso.RetornaSQL(this.strconsulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void LimpaTxt()
        {
            TxtCEP.Text = "";
            txtID.Text = "";
            TxtDDI.Text = "";
            TxtEmail.Text = "";
            TxtJuridica.Text = "";
            TxtNome.Text = "";
            Txtnro.Text = "";
            TxtProdutos.Text = "";
            TxtRazao.Text = "";
            TxtServ.Text = "";
            TxtTelefone.Text = "";
            TxtWebsite.Text = "";
        }

        //Botão Salvar
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TxtCEP.Text == string.Empty || TxtDDI.Text == string.Empty || TxtEmail.Text == string.Empty || TxtJuridica.Text == string.Empty || TxtNome.Text == string.Empty || Txtnro.Text == string.Empty || TxtProdutos.Text == string.Empty || TxtRazao.Text == string.Empty || TxtServ.Text == string.Empty || TxtTelefone.Text == string.Empty || TxtWebsite.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher todos os campos!");
            }
            else
            {
                try
                {
                    acesso.ExecutaSQL($"INSERT INTO Fornecedor (id_pessoa_juridica,razao, nomefantasia, cep, nro, website, produtos_fornecidos, ddi, telefone, tipo_servico, email) VALUES('" + Convert.ToString(TxtJuridica.Text) + "','" + Convert.ToString(TxtRazao.Text) + "','" + Convert.ToString(TxtNome.Text) + "','" + Convert.ToString(TxtCEP.Text) + "','" + Convert.ToString(Txtnro.Text) + "','" + Convert.ToString(TxtWebsite.Text) + "','" + Convert.ToString(TxtProdutos.Text) + "','" + Convert.ToString(TxtDDI.Text) + "','" + Convert.ToString(TxtTelefone.Text) + "','" + Convert.ToString(TxtServ.Text) + "','" + Convert.ToString(TxtEmail.Text) + "');");
                    DataTable query = acesso.RetornaSQL($"SELECT u_id FROM usuario WHERE u_cpf='{Convert.ToString(txtID.Text)}';");

                    Form1_Load(sender, e);
                    LimpaTxt();
                }
                catch (Exception a)
                {
                    MessageBox.Show("Erro: funcionário não encontrado no sistema. " + a.Message);
                }
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            TxtJuridica.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            TxtRazao.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            TxtNome.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            TxtCEP.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
            Txtnro.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
            TxtWebsite.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[6].Value);
            TxtProdutos.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[7].Value);
            TxtDDI.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[8].Value);
            TxtTelefone.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[9].Value);
            TxtServ.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[10].Value);
            TxtEmail.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[11].Value);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            TxtJuridica.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            TxtRazao.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            TxtNome.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            TxtCEP.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
            Txtnro.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
            TxtWebsite.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[6].Value);
            TxtProdutos.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[7].Value);
            TxtDDI.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[8].Value);
            TxtTelefone.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[9].Value);
            TxtServ.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[10].Value);
            TxtEmail.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[11].Value);
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            TxtJuridica.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            TxtRazao.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            TxtNome.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            TxtCEP.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
            Txtnro.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
            TxtWebsite.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[6].Value);
            TxtProdutos.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[7].Value);
            TxtDDI.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[8].Value);
            TxtTelefone.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[9].Value);
            TxtServ.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[10].Value);
            TxtEmail.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[11].Value);
        }


        //botão atualizar
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            acesso.ExecutaSQL($"Update fornecedores Set id_pessoa_juridica = {Convert.ToInt32(TxtJuridica.Text)}, razao = {Convert.ToString(TxtRazao.Text)}, nomefantasia = {Convert.ToString(TxtNome.Text)}, CEP = {Convert.ToString(TxtCEP.Text)}, nro = {Convert.ToInt32(Txtnro.Text)}, website = {Convert.ToString(TxtWebsite)}, produtos_fornecidos = {Convert.ToString(TxtProdutos.Text)}, ddi = {Convert.ToInt32(TxtDDI.Text)}, telefone = {Convert.ToString(TxtTelefone.Text)}, tipo_servico = {Convert.ToString(TxtServ.Text)}, email = {Convert.ToString(TxtEmail.Text)}   Where id_fornecedor = {Convert.ToInt32(txtID)};");

        }

        //botão deletar

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            acesso.ExecutaSQL($"DELETE FROM fornecedores WHERE id_fornecedor = {Convert.ToString(txtID.Text)};");
        }


        //botão limpar
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTxt();
        }

        private void TelaIni_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal novo = new frmPrincipal();
            novo.Show();
        }
    }
}
