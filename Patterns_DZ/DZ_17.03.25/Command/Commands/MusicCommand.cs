using Patterns_DZ.DZ_17._03._25.Command.SmartHomeElements;

namespace Patterns_DZ.DZ_17._03._25.Command.Commands;

public class MusicCommand : ICommand
{
    private MusicPlayer _musicPlayer;
    private bool _isPlaying;

    public MusicCommand(MusicPlayer musicPlayer, bool isPlaying)
    {
        _musicPlayer = musicPlayer;
        _isPlaying = isPlaying;
    }

    public void Execute()
    {
        if (_isPlaying)
            _musicPlayer.Play();
        else
            _musicPlayer.Stop();
    }

    public void Undo()
    {
        if(!_isPlaying)
            _musicPlayer.Play();
        else
            _musicPlayer.Stop();
    }
}
