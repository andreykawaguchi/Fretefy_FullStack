namespace Fretefy.Test.Domain.Exceptions
{
    public class RegiaoNomeDuplicadoException : DomainException
    {
        public RegiaoNomeDuplicadoException(string nomeRegiao) 
            : base($"J� existe uma regi�o com o nome '{nomeRegiao}'. O nome da regi�o deve ser �nico.")
        {
        }
    }
}