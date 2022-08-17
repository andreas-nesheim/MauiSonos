using ByteDev.Sonos;

namespace MauiSonos;

public partial class MainPage : ContentPage
{
    private readonly string sonosPlay1IP = "192.168.86.172";
    private readonly string sonosBeamIP = "192.168.86.172";
    private SonosController sonosPlay1Controller;
    private SonosController sonosBeamController;

    public MainPage()
    {
        InitializeComponent();
        sonosPlay1Controller = new SonosControllerFactory().Create(sonosPlay1IP);
        sonosBeamController = new SonosControllerFactory().Create(sonosBeamIP);
    }

    private async void OnPrevBtnClicked(object sender, EventArgs e)
    {
        await sonosPlay1Controller.PreviousTrackAsync();
    }

    private async void OnPlayPauseBtnClicked(object sender, EventArgs e)
    {
        var isPlaying = await sonosPlay1Controller.GetIsPlayingAsync();
        if (isPlaying)
            await sonosPlay1Controller.PauseAsync();
        else
            await sonosPlay1Controller.PlayAsync();
    }

    private async void OnNextBtnClicked(object sender, EventArgs e)
    {
        await sonosPlay1Controller.NextTrackAsync();
    }
}

