AIAssistant Simulator
Welcome to the AIAssistant Simulator, a versatile and customizable AI-powered assistant written in .NET 7. This assistant utilizes various technologies for speech-to-text, text-to-speech, and AI computations. Below are the key components and instructions to set up and run the AIAssistant Simulator.

Technologies Used:
Pico2wave for TTS:

Install with: sudo apt-get install libttspico-utils
Leopard for Voice-to-Text:

Requires an API key for verification. The user can use the provided API key for fair usage limits.
Set the API key using the leopard_access_key environment variable.
Ollama for AI Calculations:

Install with: curl https://ollama.ai/install.sh | sh
GitHub Project: Ollama GitHub
Set the Ollama URL using the ollama_url environment variable.
Run ollama pull llama2 to pull the Ollama models.
Setup Instructions:
Install Dependencies:

Install Pico2wave: sudo apt-get install libttspico-utils
Install Ollama: curl https://ollama.ai/install.sh | sh
Configure Environment Variables:

Set the audio input device using the audio_device_index environment variable.
Set the Leopard API key using the leopard_access_key environment variable.
Set the Ollama URL using the ollama_url environment variable.
Build and Run:

Build the project using .NET 7: dotnet build
Run the AIAssistant Simulator: dotnet run
Example Usage:
Voice Input:

Configure the input device using the audio_device_index environment variable.
Leopard API Key:

Use the provided API key for Leopard by setting the leopard_access_key environment variable.
Ollama AI Calculation:

Set the Ollama URL using the ollama_url environment variable.
Pull Ollama models with ollama pull llama2.
Run the Assistant:

Execute the AIAssistant Simulator with dotnet run.
Important Notes:
This AIAssistant Simulator allows users to interact using voice commands, converting speech to text.
The Ollama AI service is used for complex computations, and the results are spoken using Pico2wave.
Feel free to explore and enhance the AIAssistant Simulator according to your needs. If you encounter any issues or have suggestions, please refer to the GitHub Issues section.

Happy coding!
