using Pv;

namespace llamaAssistance;

public static class VoiceTranscription
{
    public static async Task<string> Transcript(short[] data)
    {
        Console.WriteLine("Creating leopard instance...");
        var leopard = Leopard.Create(
            accessKey: Environment.GetEnvironmentVariable("leopard_access_key"));
        Console.WriteLine("Processing input audio...");
        var result = leopard.Process(data);
        Console.WriteLine(result.TranscriptString);
        return result.TranscriptString;
    }
}