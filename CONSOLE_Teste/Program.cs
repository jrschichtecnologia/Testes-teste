
using System.Text.Json;

Console.WriteLine("Iniciado a chamada!");
Console.ReadLine();

HttpClient client =  new HttpClient();
Uri uri = new Uri("https://localhost:7019/api/testeubs");

client.BaseAddress = uri;

var lst = new List<Request>() 
{ 
    new Request(){ Value=2000000, ClientSector="Private" },
    new Request(){ Value=400000, ClientSector="Public" },
    new Request(){ Value=500000, ClientSector="Public" },
    new Request(){ Value=3000000, ClientSector="Public" },
    new Request(){ Value=2500000, ClientSector="Ong" }
};

var json = JsonSerializer.Serialize(lst);

var url = $"{uri}/Teste?portifolio={json}";
HttpResponseMessage responseMessage = await client.GetAsync(url);

var resp = responseMessage.Content.ReadAsStringAsync().Result;
Console.WriteLine(resp);

Console.WriteLine("finalizou a chamada!");
Console.ReadLine();
class Request
{
    public double Value { get; set; }
    public string? ClientSector { get; set; }
}