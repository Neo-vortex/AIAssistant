using llamaAssistance;

while (true)
{
    var audioData = await VoiceRecorder.RecordQuery();

    var transcript = await VoiceTranscription.Transcript(audioData);

    var response = await AiResponseGenerator.GenerateResponse(transcript);
    
    Console.WriteLine(response + "\n");
    TextToVoice.SpeakText(response);
    Console.WriteLine("Press enter to start recording");
    Console.ReadLine();
    Console.WriteLine( string.Join("", Enumerable.Repeat("-",20)) );
}
