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
using DinerMax3000.BusinessLayer;

namespace DinerMax3000.WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DependencyObject cboAllMenus;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public void Button_Click(RoutedEventArgs e, object sender)
        {
            DinerMax3000.WPFClient.DinerMax3000ViewModel currentViewModel =
                (DinerMax3000.WPFClient.DinerMax3000ViewModel)DataContext;

            foreach (var currentMenuItem in currentViewModel.NewMenuItems)
            {
                currentViewModel.SelectedMenu.SaveNewMenuItem(currentMenuItem.Title, currentMenuItem.Description, currentMenuItem.Price);
            }

            BindingOperations.GetBindingExpressionBase(cboAllMenus, ComboBox.ItemsSourceProperty).UpdateTarget();
        }

        public void DataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {

            if (e.Row.Item is DinerMax3000.BusinessLayer.MenuItem newMenuItem && e.EditAction == DataGridEditAction.Commit && e.Row.IsNewItem)
            {
                DinerMax3000.WPFClient.DinerMax3000ViewModel currentViewModel =
                    (DinerMax3000.WPFClient.DinerMax3000ViewModel)DataContext;
                currentViewModel.NewMenuItems.Add(newMenuItem);
            }
        }
    }
}
