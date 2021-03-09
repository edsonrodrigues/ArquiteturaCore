using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Dao.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        void Inserir(T item);
        void Deletar(T item);
        void Editar(T item);
        T SelecionarPorId(int id);
        IQueryable<T> SelecionarTodos();

    }
}
