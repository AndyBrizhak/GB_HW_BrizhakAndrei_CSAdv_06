using System.Windows;

namespace Emp_Dep
{
    /// <summary>
    /// Логика взаимодействия для AddEmpWindow.xaml
    /// </summary>
    public partial class AddEmpWindow : Window
    {
        public AddEmpWindow(Rep dbEmpDep, int IDep)
        {
            InitializeComponent();
            btnAddEmp.Click += delegate
            {
                dbEmpDep.AddEmp(txtBoxFName.Text,txtBoxLName.Text,txtBoxAge.Text, IDep);
                this.DialogResult = true;
            };
        }
    }
}
