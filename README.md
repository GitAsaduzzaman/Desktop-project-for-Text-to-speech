# Quantum Text-to-Speech Application

This project is a Windows Forms application built in C# that uses the System.Speech.Synthesis library to convert text to speech. Users can input text, choose the speed and volume, and select a voice gender to hear the text spoken aloud.

## Features

- Text-to-speech conversion
- Adjustable speech speed and volume
- Voice gender selection (Male, Female)

## Requirements

- .NET Framework 4.5 or later
- Visual Studio 2019 or later

## Installation

1. **Clone the repository:**

    ```sh
    git clone https://github.com/GitAsaduzzaman/Desktop-project-for-Text-to-speech.git
    cd Desktop-project-for-Text-to-speech
    ```

2. **Open the project:**

    Open `QuantumTextToSpeech.sln` in Visual Studio.

3. **Build the project:**

    Build the solution to restore the necessary packages and compile the code.

4. **Run the application:**

    Run the application from Visual Studio.

## Usage

1. **Enter text:**

    Type or paste the text you want to be spoken into the `richTextBox`.

2. **Select speech properties:**

    - Adjust the speech speed using the `SpeedtrackBar`.
    - Adjust the speech volume using the `VolumetrackBar`.
    - Select the voice gender using the `voicomboBox`.

3. **Click the Speak button:**

    Click the `Speechbutton` to hear the text spoken aloud.

## Code Overview

The main logic for text-to-speech conversion is implemented in the `Speechbutton_Click` event handler:

```csharp
private void Speechbutton_Click(object sender, EventArgs e)
{
    if (richTextBox1.Text == "")
    {
        MessageBox.Show("Please Enter text", "Empty Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    else
    {
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        speechSynthesizer.Rate = SpeedtrackBar.Value;
        speechSynthesizer.Volume = VolumetrackBar.Value;

        if (voicomboBox.Text == "Male")
        {
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Male);
        }
        else if (voicomboBox.Text == "Female")
        {
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
        }

        speechSynthesizer.SpeakAsync(richTextBox1.Text);
    }
}
