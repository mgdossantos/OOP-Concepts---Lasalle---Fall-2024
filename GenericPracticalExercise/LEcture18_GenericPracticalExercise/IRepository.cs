using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture18_GenericPracticalExercise
{
    public interface IRepository<T> where T : Entity
    {
        void add(T entity);
        T get(int id);
        IEnumerable<T> getAll();
        void update(T entity);
        void delete(int id);
    }
}
