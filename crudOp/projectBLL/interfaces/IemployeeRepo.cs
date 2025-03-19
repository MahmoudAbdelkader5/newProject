using data_Access_layer.model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace projectBLL.interfaces
{
    public interface IemployeeRepo
    {
        IEnumerable<Employee> GetAll();

        Employee getbyid(int id);
        public int add(Employee dep);

        public int update(Employee dep);
        public int delete(Employee dep);
    }
}