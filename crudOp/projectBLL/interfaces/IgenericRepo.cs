using data_Access_layer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBLL.interfaces
{
    public interface IgenericRepo<T>
    {
        IEnumerable<T> GetAll();

        T getbyid(int id);
        public int add(T dep);

        public int update(T dep);
        public int delete(T dep);
    }
}
