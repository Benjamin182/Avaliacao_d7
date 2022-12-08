using avaliacaod7.Data;
using System;
using System.Collections.Generic;
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

namespace avaliacaod7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context context;
        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            var users = context.Users.ToList();

            foreach (var user in users)
            {
                if (user.Email == Email.Text)
                {
                    if (user.Password == Password.Text)
                    {
                        MessageBox.Show("Usuário logado com êxito!");
                    }
                    else MessageBox.Show("Senha Inválida");
                }
                else MessageBox.Show("Usuário não encontrado");
            }

        }
    }
}
