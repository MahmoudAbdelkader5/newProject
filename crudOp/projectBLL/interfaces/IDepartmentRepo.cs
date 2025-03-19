using data_Access_layer.model;
using projectBLL.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBLL.interfaces
{
   public interface IDepartmentRepo
    {

        IEnumerable<Department> GetAll();

        Department getbyid(int id);
        public int add(Department dep);

        public int update(Department dep);
        public int delete(Department dep);

    }
}
