﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Versioning;


namespace Emp_Dep
{
    public class Employee : INotifyPropertyChanged
    {
        public string _fName;
        private string _lName;
        private int _age;
        private int _depID;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FName
        {
            get => _fName;
            set
            {
                _fName = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(FName));
            }
        }

        public string LName { get => _lName; set => _lName = value; }
        public int Age { get => _age; set => _age = value; }
        public int DepID { get => _depID; set => _depID = value; }

        public Employee(string _fName, string _lName, int _age, int _depID)
        {
            FName = _fName;
            LName = _lName;
            Age = _age;
            DepID = _depID;
        }

        public override string ToString()
        {
            //Person person = new Person { Name = "Tom", Age = 23 };

            //Console.WriteLine("Имя: {0}  Возраст: {1}", person.Name, person.Age);
            return FName ;

        }
    }

}
