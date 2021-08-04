using UnityEngine;

public class AudioController : MonoBehaviour
{
    public void PlayButtonSound()
    {
        AudioManager.instance.PlaySound(AudioManager.BUTTON_SOUND);
    }
    public void MuteMusic()
    {
        AudioManager.instance.MuteMusic(AudioManager.BGMUSIC);
    }

    public void MuteSound()
    {
        AudioManager.instance.MuteSound(AudioManager.BUTTON_SOUND, AudioManager.GAME_OVER_SOUND, AudioManager.COLLECT_SOUND);
    }
}
