using UnityEngine;

public class Environment : MonoBehaviour
{
    [field: SerializeField] public Vector3 TranslationPerFixedUpdate { get; set; }

    private void FixedUpdate()
    {
        transform.position += TranslationPerFixedUpdate;
    }

    private void OnGameEnd()
    {
        this.enabled = false;
    }
}