using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities.Entidade
{
    public class PessoaEntidade : BaseEntity
    {
        [Required(ErrorMessage = "Campo nome obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        // [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Cpf")]
        public string Cpf { get; set; }

        // [Required(ErrorMessage = "Campo email é obrigatório.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Campo nome obrigatório.")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        //[Required(ErrorMessage = "Campo senha é obrigatório.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }


    }
}
