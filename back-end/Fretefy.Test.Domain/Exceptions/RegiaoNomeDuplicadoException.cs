namespace Fretefy.Test.Domain.Exceptions
{
    public class RegiaoNomeDuplicadoException : DomainException
    {
        public RegiaoNomeDuplicadoException(string nomeRegiao) 
            : base($"Já existe uma região com o nome '{nomeRegiao}'. O nome da região deve ser único.")
        {
        }
    }
}