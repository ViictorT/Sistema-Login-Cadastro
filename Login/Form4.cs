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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show(); this.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string strConexao = @"Data Source=DESKTOP-GS9J0SC\SQLEXPRESS;Initial Catalog=Atividade;Integrated Security=True";
            string Query = "UPDATE tb_atividade01 SET Nome = '" + txtEditar.Text + "' WHERE ID =" + txtIDEditar.Text;

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
