using System.Collections;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    /// <summary>
    /// True if this Pipe is TargetDeltaPositionX units from StartPosition, else false
    /// </summary>
    public bool CanInstantiatePipe
    {
        get
        {
            float deltaPositionX = Mathf.Abs(StartPosition.x - transform.position.x);
            return deltaPositionX > TargetDeltaPositionX;
        }
    }

    /// <summary>
    /// The max value of transform.position.y that a Pipe may have.
    /// Note: Determine in editor
    /// </summary>
    [field: SerializeField] public float MaxPositionY { get; set; }

    /// <summary>
    /// The min value of transform.position.y that a Pipe may have
    /// Note: Determine in editor
    /// </summary>
    [field: SerializeField] public float MinPositionY { get; set; }

    /// <summary>
    /// The position of this Pipe on Awake
    /// </summary>
    public Vector3 StartPosition { get; set; }

    /// <summary>
    /// The delta position x from StartPosition this Pipe must have in order to be eligible to spawn a pipe
    /// Note: Determine in editor
    /// </summary>
    [field: SerializeField] public float TargetDeltaPositionX { get; set; }

    /// <summary>
    /// Note: Awake may not be a coroutine
    /// </summary>
    private void Awake()
    {
        StartPosition = transform.position;
    }

    /// <summary>
    /// Instantiate this Pipe.
    /// The instance's StartPosition.x will be that of this Pipe's StartPosition.x.
    /// The instance's StartPosition.y will belong to [MinPositionY, MaxPositionY]
    /// </summary>
    private void InstantiatePipe()
    {
        Vector3 position = StartPosition;
        position.y = Random.Range(MinPositionY, MaxPositionY);
        Instantiate(gameObject, position, Quaternion.identity, transform.parent);
    }

    /// <summary>
    /// Destroy this Pipe when it is no longer visible
    /// </summary>
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// Wait until CanInstantiatePipe is true to invoke InstantiatePipe.
    /// Note: Start may be a coroutine
    /// </summary>
    private IEnumerator Start()
    {
        yield return new WaitUntil(() => CanInstantiatePipe);
        InstantiatePipe();
    }
}