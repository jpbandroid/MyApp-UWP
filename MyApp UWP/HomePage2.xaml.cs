using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyApp_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage2 : Page
    {
        public HomePage2()
        {
            this.InitializeComponent();
            if (ElementSoundPlayer.State == ElementSoundPlayerState.On)
                soundToggle.IsOn = true;
            if (ElementSoundPlayer.SpatialAudioMode == ElementSpatialAudioMode.On && soundToggle.IsOn == true)
                spatialAudioBox.IsChecked = true;

        }

        private void teachingtip1(object sender, RoutedEventArgs e)
        {
            tt1.IsOpen = true;

        }
        private void soundToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (soundToggle.IsOn == true)
            {
                spatialAudioBox.IsEnabled = true;
                ElementSoundPlayer.State = ElementSoundPlayerState.On;
            }
            else
            {
                spatialAudioBox.IsEnabled = false;
                spatialAudioBox.IsChecked = false;

                ElementSoundPlayer.State = ElementSoundPlayerState.Off;
                ElementSoundPlayer.SpatialAudioMode = ElementSpatialAudioMode.Off;
            }
        }
        private void spatialAudioBox_Checked(object sender, RoutedEventArgs e)
        {
            if (soundToggle.IsOn == true)
            {
                ElementSoundPlayer.SpatialAudioMode = ElementSpatialAudioMode.On;
            }
        }

        private void spatialAudioBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (soundToggle.IsOn == true)
            {
                ElementSoundPlayer.SpatialAudioMode = ElementSpatialAudioMode.Off;
            }
        }

        private void teachingtip2(object sender, RoutedEventArgs e)
        {
            tt2.IsOpen = true;
        }
        private void HighVisibility_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.FocusVisualKind = FocusVisualKind.HighVisibility;
        }

        private void RevealFocus_Checked(object sender, RoutedEventArgs e)
        {
                Application.Current.FocusVisualKind = FocusVisualKind.Reveal;
            }
        }
    }

