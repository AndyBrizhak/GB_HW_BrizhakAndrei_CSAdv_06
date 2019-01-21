using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Dep
{
    class DB_Emp_Dep/*: IEquatable<Department>*/
    {
        public ObservableCollection<Employee> DbEmployees { get; set; }
        public ObservableCollection<Department> DbDepartments { get; set; }

        public DB_Emp_Dep()
        {
            DbEmployees = new ObservableCollection<Employee>();
            DbDepartments = new ObservableCollection<Department>();
        }


        /// <summary>
        /// Добавляет Департамент 
        /// </summary>
        /// <param name="NameDep">Имя нового департамента</param>
        public void AddDep(string nameDep)
        {
          DbDepartments.Add(new Department(nameDep, DbDepartments.Count + 1));
           
        }

        /// <summary>
        /// Удаление департамента и всех его сотрудников
        /// </summary>
        /// <param name="id">Идентификатор департамента</param>
        public void DelDep(int id)
        {
            for (int i = DbEmployees.Count-1; i >=0 ; i--)
            {
                if (DbEmployees[i].DepID==id)
                {
                   DbEmployees.RemoveAt(i); 
                }
            }

            for (int i = DbDepartments.Count - 1; i >= 0; i--)
            {
                if(DbDepartments[i].DepId == id) DbDepartments.RemoveAt(i);
            }
        }

       

        //public bool CheckUnic(string nameDep, ObservableCollection<Department> depCollection)
        //{
        //    bool unicName = true;
        //    foreach (var item in depCollection)
        //    {
        //        if (nameDep == item.DepName)
        //        {
        //            unicName = false;
        //        }
        //    }

        //    return unicName;
        //}
    }
}
