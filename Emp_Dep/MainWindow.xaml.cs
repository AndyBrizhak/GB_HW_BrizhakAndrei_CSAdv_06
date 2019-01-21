﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
            DB_Emp_Dep dbEmpDep = new DB_Emp_Dep();
            dbEmpDep.AddDep("Приемная");
            dbEmpDep.AddDep("Прачечная");
            dbEmpDep.AddDep("Морг");
            dbEmpDep.AddEmp("Василий", "Афанасьев", 25, 1 );
            dbEmpDep.AddEmp("Тамара", "Иванова", 32, 2);
            dbEmpDep.AddEmp("Василий", "Пупкин", 48, 3);

            ListViewDbDep.ItemsSource = dbEmpDep.DbDepartments;
            ListViewDbEmp.ItemsSource = dbEmpDep.DbEmployees;


        }
    }
}
