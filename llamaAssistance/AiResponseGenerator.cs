namespace llamaAssistance;

public static class AiResponseGenerator
{
    private static  ConversationContextWithResponse _context;
    public static async Task<string> GenerateResponse(string query)
    {
        var ollama = new OllamaApiClient(new Uri(Environment.GetEnvironmentVariable("ollama_url") ?? throw new InvalidOperationException("ollama_url is not set")));
        Console.WriteLine("Getting models...");
        var models = (await ollama.ListLocalModels()).ToList();
        if (!models.Any())
        {
            throw new InvalidOperationException("No models found\n try to install one like `ollama pull llama2`");
        }
        var modelName = Environment.GetEnvironmentVariable("model_name") ?? models.First().Name;
        Console.WriteLine("using model: " + modelName);
        _context = await ollama.GetCompletion(query,modelName , _context);
        return _context.Response;
    }
}