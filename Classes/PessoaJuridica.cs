using System.Text.RegularExpressions;
using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }


        public string? RazaoSocial { get; set; }


        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
        //xx.xxx.xxx/00001-xx  ----- xxxxxxxx0001xx
        public bool ValidarCnpj(string cnpj)
        {
           bool retornocnpjvalido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");
           if (retornocnpjvalido == true)
           {
               if (cnpj.Length == 18)
               {
                  string substringCnpj = cnpj.Substring(11, 4);

                  if (substringCnpj == "0001")
                  {
                      return true;
                  }

               }else if (cnpj.Length == 14)
               {
                  string subStringCnpj = cnpj.Substring(8, 4);

                  if (subStringCnpj == "0001")
                  {
                      return true;
                  }

               }
           }

           return false;
        //    if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)")
        // ==true)
        //    {

        //    }

        //    if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
        //    {

        //    } 


        // = Atribuicao
        // == Comparacao
        // === Comparacao exata do mesmo item




        }

        internal bool ValidarCnpj(object cnpj)
        {
            throw new NotImplementedException();
        }

        internal bool ValidarCnpj()
        {
            throw new NotImplementedException();
        }
    }
}