using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool? Status { get; set; }
        public DateTime? Dt_Criacao { get; set; }

        public BaseEntity()
        {
            this.Id = 0;
            this.Status = true;
            this.Dt_Criacao = DateTime.Now.Date;
        }

    }
}
