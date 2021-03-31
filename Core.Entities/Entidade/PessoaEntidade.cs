using Core.Commons.DataAnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Core.Entities.Entidade
{
    public class PessoaEntidade : BaseEntity
    {
        [Required(ErrorMessage = "Campo nome obrigatório, validacao via data anotation")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

       // [RequiredIdAttribute(ErrorMessage = "Campo obrigatório, validacao via data anotation customizada")]
       //implementar validação de fomato via regex
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
