using System.ComponentModel.DataAnnotations;

namespace AppFluxoDeCaixa.Models
{
    public class Clientes
    {
        public Guid ClientesId { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Campo Nome é Obrigatório!")]
        [MaxLength(100, ErrorMessage = "O Limite do campo é de 100 Caracteres!")]
        [MinLength(3, ErrorMessage = "O Campo Nome deve ter, no mínimo, 3 Caracters")]
        public string ClientesNome { get; set; }


        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O Campo Endereço é Obrigatório!")]
        public string Logradouro { get; set; }


        [Required(ErrorMessage = "O Campo Cidade é Obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Campo UF é Obrigatório!")]
        [MaxLength(2, ErrorMessage = "O Limite do campo é de 2 Caracteres!")]
        [MinLength(2, ErrorMessage = "O Campo UF deve ter 2 Caracters")]
        public string UF { get; set; }

        [Required(ErrorMessage = "O Campo CEP é Obrigatório!")]
        [MaxLength(8, ErrorMessage = "O Limite do campo é de 8 Dígitos Numéricos!")]
        [MinLength(8, ErrorMessage = "O Campo CEP deve ter 8 Dígitos Numéricos")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O Campo Bairro é Obrigatório!")]
        public string Bairro { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O Campo E-mail é Obrigatório!")]
        public string Email { get; set; }

        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O Campo Celular é Obrigatório!")]
        [MaxLength(11, ErrorMessage = "O Limite do campo é de 11 Dígitos Numéricos!")]
        [MinLength(11, ErrorMessage = "O Campo Celular deve ter 11 Dígitos Numéricos")]
        public string Celular { get; set; }

        [Display(Name = "Tipo de Pessoa")]
        [Required(ErrorMessage = "O Campo Tipo de Pessoa é Obrigatório!")]
        public string TipoPessoa { get; set; }

        [Display(Name = "CPF / CNPJ")]
        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        public string CpfCnpj { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessage = "O Campo Data de Cadastro é Obrigatório!")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Data Nasc. / Fundação")]
        [Required(ErrorMessage = "O Campo é Obrigatório!")]
        public DateOnly DataNascFundacao { get; set; }

        [Display(Name = "Ativo?")]
        public bool CadastroAtivo { get; set; }

        [Display(Name = "Observação")]
        [MaxLength(255, ErrorMessage = "O Campo Observação é Obrigatório!")]
        public string? Observacao { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "O Campo Número é obrigatório")]
        public string Numero { get; set; }

    }
}
