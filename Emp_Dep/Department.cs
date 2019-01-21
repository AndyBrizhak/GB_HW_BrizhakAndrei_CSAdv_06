﻿using System;
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
        private int _depId;
        private string _depName;

        public Department(string _depName, int _depId)
        {
            DepId = _depId;
            DepName = _depName;
        }

        public int DepId { get => _depId; set => _depId = value; }
        public string DepName
        { get => _depName;
            set
            {
                this._depName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(DepName));
            }
           
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
