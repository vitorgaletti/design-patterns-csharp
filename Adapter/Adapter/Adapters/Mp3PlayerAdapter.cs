using Adapter.Libs;

namespace Adapter.Adapters;

public class Mp3PlayerAdapter : IPlayer
{
    public void Play(string file)
    {
        var mp3Player = new Mp3Player(file);
        mp3Player.Run();
    }
}