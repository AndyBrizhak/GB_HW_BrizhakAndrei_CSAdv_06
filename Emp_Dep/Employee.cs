using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Versioning;


namespace Emp_Dep
{
    public class Employee : INotifyPropertyChanged
    {
        public string fName;
        private string lName;
        private int age;
        private int depID;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FName
        {
            get => fName;
            set
            {
                fName = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(FName));
            }
        }

        public string LName { get => lName; set => lName = value; }
        public int Age { get => age; set => age = value; }
        public int DepID { get => depID; set => depID = value; }

        public Employee()
        {
            FName = fName;
            LName = lName;
            Age = age;
            DepID = depID;
        }
    }

}
