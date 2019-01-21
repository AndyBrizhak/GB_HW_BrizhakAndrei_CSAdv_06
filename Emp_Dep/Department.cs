using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Emp_Dep
{
    class Department: INotifyPropertyChanged
    {
        private int depId;
        private string depName;

        public Department(string depName, int depId)
        {
            DepId = depId;
            DepName = depName;
        }

        public int DepId { get => depId; set => depId = value; }
        public string DepName
        { get => depName;
            set
            {
                this.depName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(DepName));
            }
           
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
