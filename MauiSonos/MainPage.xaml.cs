using ByteDev.Sonos;

namespace MauiSonos;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        // Sonos Play:1
        var controller = new SonosControllerFactory().Create("192.168.86.172");
        var isPlaying = await controller.GetIsPlayingAsync();
        var volume = await controller.GetVolumeAsync();
        var queue = await controller.GetQueueAsync();

        // Sonos Beam
        controller = new SonosControllerFactory().Create("192.168.86.38");
        isPlaying = await controller.GetIsPlayingAsync();
        volume = await controller.GetVolumeAsync();
        queue = await controller.GetQueueAsync();
    }
}

