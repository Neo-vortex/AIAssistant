using System.Diagnostics;
using Pv;

namespace llamaAssistance;

public class VoiceRecorder
{
    private static bool _cancel;
    private static readonly int PV_RECORDER_FRAME_LENGTH = 2048;

    public static async Task<short[]> RecordQuery()
    {
        _cancel = false;
        var timer = new Stopwatch();
        var data = new List<short>();
        var recorder = PvRecorder.Create(PV_RECORDER_FRAME_LENGTH, Environment.GetEnvironmentVariable("audio_device_index") != null ? int.Parse(Environment.GetEnvironmentVariable("audio_device_index")) : 0);
        Console.WriteLine($"Using device: {recorder.SelectedDevice}");
        Console.WriteLine($"Recording...");
        var runningTask=  Task.Run(() =>
        {
            recorder.Start();
            timer.Start();
            while (!_cancel)
            {
                data.AddRange(recorder.Read());
            }
            timer.Stop();
            recorder.Dispose();
        });
        Console.ReadLine();
        _cancel = true;
        await runningTask;
        Console.WriteLine("Recording time: " + timer.ElapsedMilliseconds + "ms");
        return data.ToArray();


    }
}