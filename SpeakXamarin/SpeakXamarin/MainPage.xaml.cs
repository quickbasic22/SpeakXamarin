using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SpeakXamarin
{
    public partial class MainPage : ContentPage
    {
        SpeechOptions settings;
        public MainPage()
        {
            InitializeComponent();
            EntryText.Text = "Xamarin is a program to create phone apps for Androids.";
        }

        private async void BtnSpeak_Clicked(object sender, EventArgs e)
        {
            settings = new SpeechOptions()
            {
                Volume = (float)VolumeLevel.Value,
                Pitch = (float)PitchLevel.Value
            };
            await TextToSpeech.SpeakAsync(EntryText.Text, settings);
        }

        private void VolumeLevel_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            settings.Volume = (float)VolumeLevel.Value;
            LblVolumeSlider.Text = "Volume Level " + VolumeLevel.Value.ToString();
        }

        private void PitchLevel_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            settings.Pitch = (float)PitchLevel.Value;
            LblPitchSlider.Text = "PitchLevel " + PitchLevel.Value.ToString();
        }
    }
}
