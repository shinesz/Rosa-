using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.EntityFramework;
using System.Globalization;

namespace Rosa
{
    public partial class EventsForms : Form
    {
        public MySqlConnection conexao;

        public EventsForms()
        {
            InitializeComponent();
            
            conexao = new MySqlConnection("server=localhost;DataBase=Rosa1;Uid=root;password=");
            try
            {
                conexao.Open();//Tentando conectar ao BD

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);//Enviando a mesagem de erro aos usuários
                conexao.Close();//fechando a conexão com o banco de dados
            }
        }//fim do DAOPessoa


        private void EventsForms_Load(object sender, EventArgs e)
        {
          
        }
    }
}
