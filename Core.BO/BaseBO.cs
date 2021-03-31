using System;
using System.Collections.Generic;
using System.Text;
using Core.Dao;
using Core.Entities;

namespace Core.BO
{
    /// <summary>
    /// Classe Base para os BOs
    /// </summary>
    /// <typeparam name="TEntity">Entidade</typeparam>
    public class BaseBO<TEntity> : BaseDao<TEntity>
        where TEntity : BaseEntity

    {
        /// <summary>
        /// Metodo responsavel por validar se uma entidade é nula ou inativa
        /// </summary>
        /// <param name="T">Entidade recebida por parametro</param>
        public void ValitateIfNullOrInactive(TEntity T)
        {
             if (T == null || T.Status != true)
             {
                 throw new Exception("MessageResource.IS_NULL_OR_INACTIVE");
             }

        }

    }
}
