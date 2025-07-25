using UnityEngine;

public class Audio : MonoBehaviour
{
    /// <summary>
    /// The AudioSource attatched to this Bird
    /// </summary>
    public AudioSource AudioSource { get; set; }

    /// <summary>
    /// The AudioClip to play in Flap
    /// </summary>
    [field: SerializeField] public AudioClip OnFlapAudioClip { get; set; }

    /// <summary>
    /// The AudioClip to play on collision
    /// </summary>
    [field: SerializeField] public AudioClip OnGameEndAudioClip { get; set; }

    /// <summary>
    /// The AudioClip to play when a point is scored
    /// </summary>
    [field: SerializeField] public AudioClip OnPointScoredAudioClip { get; set; }

    private void Awake()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    private void OnFlap()
    {
        AudioSource.PlayOneShot(OnFlapAudioClip);
    }

    private void OnGameEnd()
    {
        AudioSource.PlayOneShot(OnGameEndAudioClip);
    }

    private void OnPointScored()
    {
        AudioSource.PlayOneShot(OnPointScoredAudioClip);
    }
}