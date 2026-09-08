using UnityEngine;

public class PressSound : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.Instance.Play(AudioManager.SoundType.Press);
    }
}
