using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Dep
{
    public class Rep                                                             /*: IEquatable<Department>*/
    {
        public ObservableCollection<Employee> DbEmployees { get; set; }
        public ObservableCollection<Department> DbDepartments { get; set; }

        public Rep()
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

        /// <summary>
        /// Добавление работника в коллекцию
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="age"></param>
        /// <param name="depId"></param>
        public void AddEmp(string fName, string lName, int age, int depId)
        {
            DbEmployees.Add(new Employee(fName, lName, age, depId));

        }

        /// <summary>
        /// Удаляет работника из коллекции
        /// </summary>
        /// <param name="id">Порядковый номер в коллекции</param>
        public void DelEmp(int id)
        {
            if (DbEmployees.Count == 0) return;
            if (DbEmployees.Count <id) return;
            DbEmployees.RemoveAt(id); 
        }
    }
}
