using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.Provider
{
    public interface IProvider<Model>
    {
        public List<Model> GetAll();
        public Model GetSingle(object id);
        public bool Insert(Model model);
        public bool Update(Model model);
        public bool Delete(object id);
    }
}
