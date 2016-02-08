using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp01.Models
{
    public class RegistroModel
    {
        [Required(ErrorMessage = "Nome é Obrigatório!")]
        [StringLength(100, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Cidade é Obrigatório!")]
        [StringLength(100, MinimumLength = 3)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Estado é Obrigatório!")]
        [StringLength(2, MinimumLength = 2)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Email é Obrigatório!")]
        [StringLength(100, MinimumLength = 5)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone deve ser informado.!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do telefone no formato (000) 0000-0000")]
        [DisplayName("Número do Telefone")]
        public string Fone { get; set; }

        [Required(ErrorMessage = "O celular deve ser informado.!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do celular no formato (000) 00000-0000")]
        [DisplayName("Número do Celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Descrição pessoal é Obrigatório!")]
        [StringLength(100, MinimumLength = 5)]
        public string Descricao { get; set; }
    }
}