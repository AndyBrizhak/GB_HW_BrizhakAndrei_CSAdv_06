using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace Emp_Dep
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public Rep dbEmpDep;
        public MainWindow()
        {
            InitializeComponent();
            dbEmpDep = new Rep();
            MainGrid.DataContext=dbEmpDep;
            this.DataContext = dbEmpDep;

            dbEmpDep.AddDep("Приемная");
            dbEmpDep.AddDep("Прачечная");
            dbEmpDep.AddDep("Морг");
            dbEmpDep.AddEmp("Василий", "Афанасьев", 25.ToString(), 1);
            dbEmpDep.AddEmp("Федор", "Ивлев", 25.ToString(), 1);
            dbEmpDep.AddEmp("Тамара", "Иванова", 32.ToString(), 2);
            dbEmpDep.AddEmp("Валентина", "Кошелева", 32.ToString(), 2);
            dbEmpDep.AddEmp("Василий", "Пупкин", 48.ToString(), 3);
            dbEmpDep.AddEmp("Иван", "Ложкин", 48.ToString(), 3);

            //DepCombobox.ItemsSource = dbEmpDep.DbDepartments;

            DepEditBtn.Click += delegate
            {
                new EditDepWindow((DepCombobox.SelectedItem as Department).DepId, dbEmpDep).ShowDialog();
            };

            ListEmp.MouseDoubleClick += ListEmp_MouseDoubleClick;
        }

        private void ListEmp_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
            new EditEmpWindow((ListEmp.SelectedItem as Employee).GetHashCode(), dbEmpDep).ShowDialog();
        }

        private void DepCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListEmp.ItemsSource = dbEmpDep.DbEmployees.Where(w => w.DepID ==(DepCombobox.SelectedValue as Department)?.DepId);
        }

        private void ButtonDelDep_Click(object sender, RoutedEventArgs e)
        {
            dbEmpDep.DelDep((DepCombobox.SelectedValue as Department).DepId);
        }

        private void ButtonAddDep_Click(object sender, RoutedEventArgs e)
        {
            
            new AddDepWindow(dbEmpDep).ShowDialog();
        }

        private void ButtonAddEmp_Click(object sender, RoutedEventArgs e)
        {

            new AddEmpWindow(dbEmpDep,(DepCombobox.SelectedItem as Department).DepId).ShowDialog();
        }

        private void ButtonDelEmp_Click(object sender, RoutedEventArgs e)
        {

            //new AddEmpWindow(dbEmpDep, (DepCombobox.SelectedItem as Department).DepId).ShowDialog();
            dbEmpDep.DelEmp(ListEmp.SelectedIndex);
        }

    }
}
