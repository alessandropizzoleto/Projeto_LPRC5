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
using Projeto_LPRC5.Model.Conexão;

namespace Projeto_LPRC5.View
{
    public partial class frmEntregasFornecedor : Form
    {

        public string strconsulta = "SELECT * FROM entrega_fornecedor;";
        dbEntregaFornecedor acesso = new dbEntregaFornecedor();


    


        public frmEntregasFornecedor()
        {
            InitializeComponent();
        }

        private void frmEntregasFornecedor_Load(object sender, EventArgs e)
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
            txtID.Text = "";
            TxtCondominio.Text = "";
            TxtEntrega.Text = "";
            TxtFornecedor.Text = "";
            TxtFuncionario.Text = "";
            TxtHorario.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TxtCondominio.Text == string.Empty || TxtEntrega.Text == string.Empty || TxtFornecedor.Text == string.Empty || TxtFuncionario.Text == string.Empty || TxtHorario.Text == string.Empty)
            {
                MessageBox.Show("É necessário preencher todos os campos!");
            }
            else
            {
                try
                {
                    acesso.ExecutaSQL($"INSERT INTO entrega_fornecedor (fornecedor,condominio, funcionario_remetente, data_entrega, horario_entrega) VALUES('" + Convert.ToString(TxtFornecedor.Text) + "','" + Convert.ToString(TxtCondominio.Text) + "','" + Convert.ToString(TxtFuncionario.Text) + "','" + Convert.ToString(TxtEntrega.Text) + "','" + Convert.ToString(TxtHorario.Text) + "');");
                    DataTable query = acesso.RetornaSQL($"SELECT id FROM usuario WHERE id='{Convert.ToString(txtID.Text)}';");

                    frmEntregasFornecedor_Load(sender, e);
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
            TxtFornecedor.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            TxtCondominio.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            TxtFuncionario.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            TxtEntrega.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
            TxtHorario.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[5].Value);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            TxtFornecedor.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            TxtCondominio.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            TxtFuncionario.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            TxtEntrega.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
            TxtHorario.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            TxtFornecedor.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            TxtCondominio.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            TxtFuncionario.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            TxtEntrega.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
            TxtHorario.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

            acesso.ExecutaSQL($"Update entrega_fornecedor Set Fornecedor = {Convert.ToInt32(TxtFornecedor.Text)}, condominio = {Convert.ToInt32(TxtCondominio.Text)}, funcionario_remetente = {Convert.ToInt32(TxtFuncionario.Text)}, data_entrega = {Convert.ToString(TxtEntrega.Text)}, horario_entrega = {Convert.ToString(TxtHorario.Text)} Where id = {Convert.ToInt32(txtID)};");

        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            acesso.ExecutaSQL($"DELETE FROM entrega_fornecedor WHERE id = {Convert.ToString(txtID.Text)};");
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTxt();
        }
    }
}
