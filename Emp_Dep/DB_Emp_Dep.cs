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
        /// <param name="depDb">Коллекция департаментов</param>
        public void AddDep(string NameDep, ObservableCollection<Department> depDb)
        {
            depDb.Add(new Department(NameDep, depDb.Count+1));
        }

        /// <summary>
        /// Удаление департамента и всех его сотрудников
        /// </summary>
        /// <param name="id">Идентификатор департамента</param>
        /// <param name="depDb">Коллекция департаментов</param>
        public void DelDep(int id, ObservableCollection<Department> depDb)
        {
            for (int i = DbEmployees.Count-1; i >=0 ; i--)
            {
                if (DbEmployees[i].DepID==id)
                {
                   DbEmployees.RemoveAt(i); 
                }
            }

            for (int i = depDb.Count - 1; i >= 0; i--)
            {
                if(depDb[i].DepId == id) depDb.RemoveAt(i);
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
