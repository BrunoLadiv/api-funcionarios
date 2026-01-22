namespace api_c_.Models
{
    public class ServiceResponse<T>
    {
        public T Dados { get; set; }
        public bool Sucesso { get; set; } = true;
        public string Mensagens { get; set; } = string.Empty;
    }
}
