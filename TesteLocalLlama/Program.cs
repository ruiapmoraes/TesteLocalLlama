using System.Net.Http.Json;
using System.Text.Json;

var http = new HttpClient()
{
    BaseAddress = new Uri("http://localhost:11434")
};

var request = new
{
    model = "llama3:latest",
    prompt = "Explique o que é Dependency Injection em C# de forma simples.",
    stream = false
};

Console.WriteLine("Enviando requisição ao Ollama...\\n");

var response = await http.PostAsJsonAsync("/api/generate", request);

if (!response.IsSuccessStatusCode) 
{
    Console.WriteLine($"Erro: {response.StatusCode}");
    return;
}

var json = await response.Content.ReadAsStringAsync();

using var doc = JsonDocument.Parse(json);
var result = doc.RootElement.GetProperty("response").GetString();

Console.WriteLine("Resposta do modelo:\n");
Console.WriteLine(result);