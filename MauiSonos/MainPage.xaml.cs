using ByteDev.Sonos;

namespace MauiSonos;

public partial class MainPage : ContentPage
{
    private readonly string sonosSpeakerIP = "192.168.86.172";
    private SonosController sonosController;

    public MainPage()
    {
        InitializeComponent();
        sonosController = new SonosControllerFactory().Create(sonosSpeakerIP);
    }

    private async void OnPrevBtnClicked(object sender, EventArgs e)
    {
        await sonosController.PreviousTrackAsync();
    }

    private async void OnPlayPauseBtnClicked(object sender, EventArgs e)
    {
        var isPlaying = await sonosController.GetIsPlayingAsync();
        if (isPlaying)
            await sonosController.PauseAsync();
        else
            await sonosController.PlayAsync();
    }

    private async void OnNextBtnClicked(object sender, EventArgs e)
    {
        await sonosController.NextTrackAsync();
    }
}

