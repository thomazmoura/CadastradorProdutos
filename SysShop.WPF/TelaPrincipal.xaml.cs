using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SysShop.WPF.UserControls;

namespace SysShop.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mItmSobre_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("SysShop - Sistema de registro de produtos", "SysShop - Sobre", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void mItmSair_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void mItmArquivoProdutosCadastro_Click(object sender, RoutedEventArgs e)
        {
            var novaGuia = new ClosableTab
            {
                Title = "Cadastro de Produto"
            };
            var quadroDaGuia = new Frame();
            quadroDaGuia.Content = new PaginaCadastroProduto();
            novaGuia.Content = quadroDaGuia;
            tbctrlPrincipal.Items.Add(novaGuia);
            novaGuia.Focus();
        }
    }
}
