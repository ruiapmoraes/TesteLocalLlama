using System.Net.Http.Json;
using System.Text.Json;

var http = new HttpClient
{
    BaseAddress = new Uri("http://localhost:11434")
};

Console.WriteLine("=== Rui AI - Chat Local com Ollama ===");
Console.WriteLine("Digite 'sair' para encerrar.\n");

while (true)
{
    Console.Write("Você: ");
    var input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        continue;

    if (input.ToLower() == "sair")
        break;

    var request = new
    {
        model = "llama3:latest", // confirme com: ollama list
        prompt = input,
        stream = false
    };

    try
    {
        var response = await http.PostAsJsonAsync("/api/generate", request);

        var body = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"Erro: {response.StatusCode}");
            Console.WriteLine(body);
            continue;
        }

        using var doc = JsonDocument.Parse(body);
        var result = doc.RootElement.GetProperty("response").GetString();

        Console.WriteLine($"\nIA: {result}\n");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }
}

Console.WriteLine("Encerrado.");