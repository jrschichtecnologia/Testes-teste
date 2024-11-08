using API_Teste.Interface;

namespace API_Teste.Model
{
    public class Trade : ITrade
    {
        public double Value {  get; set; }

        public string ClientSector {  get; set; }
    }
}
