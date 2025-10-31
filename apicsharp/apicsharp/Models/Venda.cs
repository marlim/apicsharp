namespace apicsharp.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }


        public Cliente Cliente { get; set; }
    }
}
