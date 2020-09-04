using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace A179_WPFLogin
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window

    { 
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\user\source\repos\A179_WPFLogin\A179_WPFLogin\Login.mdf;Integrated Security=True";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = string.Format("SELECT COUNT(*) FROM LoginTable " + "WHERE UserName = '{0}' AND Password='{1}'", txtUserName.Text, txtPassword.Password);
                SqlCommand comm = new SqlCommand(sql, conn);
                int count = Convert.ToInt32(comm.ExecuteScalar());
                if(count == 1)
                {
                    MessageBox.Show("Login 成功");

                }
                else
                {
                    MessageBox.Show("Login Fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
