using System.Diagnostics;

namespace llamaAssistance;

public static class TextToVoice
{
    public static void SpeakText(string text)
    {
        var randomFileName = Path.GetRandomFileName().Split(".")[0];
        var filePath = $"/tmp/{randomFileName}.txt";
        File.WriteAllText(filePath, text);
        var script = $"pico2wave -w=/tmp/{randomFileName}.wav < {filePath} && aplay /tmp/{randomFileName}.wav && rm /tmp/{randomFileName}.wav";
        var psi = new ProcessStartInfo("/bin/bash")
        {
            UseShellExecute = false,
            RedirectStandardOutput = true, 
            RedirectStandardError = true, 
            RedirectStandardInput = true,
            CreateNoWindow = true 
        };
        var process = new Process { StartInfo = psi };
        process.Start();
        process.StandardInput.WriteLine(script);
        process.StandardInput.Flush();
        process.StandardInput.Close();
        process.WaitForExit(); 
    }
}