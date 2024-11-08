using API_Teste.Model;
using Newtonsoft.Json;

namespace API_Teste.BLL
{
    public class Regras
    {
        private readonly List<dynamic> _params = new List<dynamic>
        {
            new { Risco = "LOWRISK", Setor = "Public", ValorMin = 0, ValorMax=1000000},
            new { Risco = "MEDIUMRISK", Setor = "Public", ValorMin = 1000000.01, ValorMax=double.MaxValue },
            new { Risco = "HARDRISK", Setor = "Private", ValorMin = 1000000.01, ValorMax=double.MaxValue }
        };
        public Regras()
        {
            
        }
        public List<string> Executar(string portifolio)
        {
            var lstRetorno = new List<string>();
            var lst = ObterObj(portifolio);
            foreach (var item in lst)
            {
                switch (item.ClientSector)
                {
                    case "Public":
                        lstRetorno.Add(Publico(item.Value));
                        break;
                    case "Private":
                        lstRetorno.Add(Privado(item.Value));
                        break;
                    default:
                        lstRetorno.Add($"NOTFOUND");
                        break;
                }                
            }
            return lstRetorno;
        }
        private List<Trade> ObterObj(string portifolio)
        {
            var obj = JsonConvert.DeserializeObject<List<Trade>>(portifolio);
            return obj;
        }
        private string Privado(double value)
        {
            var lstParams = _params.Where(p => p.Setor == "Private").ToList();
            return ObterClassificacao(value, lstParams);
        }
        private string Publico(double value)
        {
            var lstParams = _params.Where(p => p.Setor == "Public").ToList();
            return ObterClassificacao(value, lstParams);
        }
        private string ObterClassificacao(double value, List<dynamic> lst)
        {
            string Risco = "Classificação não encontrada";
            foreach (var item in lst)
            {
                if (value > item.ValorMin && value < item.ValorMax)
                    Risco = item.Risco;
            }
            return Risco;
        }
    }
}
