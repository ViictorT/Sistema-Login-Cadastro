using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form3 novo = new Form3();
            novo.Show(); this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string strConexao = @"Data Source=DESKTOP-GS9J0SC\SQLEXPRESS;Initial Catalog=Atividade;Integrated Security=True";
            string Query = "SELECT ID,Nome FROM tb_atividade01";
            ;

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(Query, strConexao);

            DataTable Tabela = new DataTable();

            da.Fill(Tabela);

            dgTabela.DataSource = Tabela;

            SqlCommand comando = new SqlCommand(Query, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form4 novo = new Form4();
            novo.Show(); this.Visible = false;
        }
    }
}
