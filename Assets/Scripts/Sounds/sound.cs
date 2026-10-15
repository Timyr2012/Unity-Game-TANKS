using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [Space]
    [SerializeField] private AudioClip jumpscare;
    [SerializeField] private AudioClip siren;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _audioSource.clip = siren;
            _audioSource.Play();
            Debug.Log(_audioSource.clip.name);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _audioSource.clip = jumpscare;
            _audioSource.Play();
            Debug.Log(_audioSource.clip.name);
        }
    }
}
