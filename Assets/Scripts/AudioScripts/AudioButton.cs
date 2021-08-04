using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    public Button button;
    public Sprite on, off;
    [SerializeField] private bool isMusicButton;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void Update()
    {
        if (isMusicButton && AudioManager.isMusicMuted) button.image.sprite = off;
        else if (isMusicButton && !AudioManager.isMusicMuted) button.image.sprite = on;

        if (!isMusicButton && AudioManager.isSoundMuted) button.image.sprite = off;
        else if (!isMusicButton && !AudioManager.isSoundMuted) button.image.sprite = on;
    }
}
