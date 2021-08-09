using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class AudioButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Sprite on, off;
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
