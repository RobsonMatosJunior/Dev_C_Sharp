using System;
using System.Net.Http;
using System.Threading.Tasks;

class ApiController
{
    private readonly HttpClient _client;

    public ApiController()
    {
        _client = new HttpClient();
        _client.BaseAddress = new Uri("https://viacep.com.br/");
    }
    public async Task<string> GetCEPAsync(string cep)
    {
        string url = $"ws/{cep}/json/";
        HttpResponseMessage response = await _client.GetAsync(url);

        if(response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        else
        {
            return "Erro ao consultar o CEP.";
        }
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        ApiController apiController = new ApiController();
        string cep = string.Empty;
        char repetir = 'n';
        string result = string.Empty;

        do
        {
            Console.WriteLine("Digite o CEP: ");
            cep = Console.ReadLine();
            result = await apiController.GetCEPAsync(cep);
            Console.WriteLine(result);

            Console.WriteLine("Deseja repetir (s/n)?");
            repetir = char.Parse(Console.ReadLine());
        }

        while (repetir == 's');
        Console.ReadLine();
        
    }
}