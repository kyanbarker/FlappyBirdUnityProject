using UnityEngine;

public class Bird : MonoBehaviour
{
    /// <summary>
    /// The rotation to rotate towards on ascent
    /// </summary>
    [field: SerializeField] private Quaternion AscentTargetRotation { get; set; }

    /// <summary>
    /// The rotation to rotate towards on descent
    /// </summary>
    [field: SerializeField] private Quaternion DescendentTargetRotation { get; set; }

    /// <summary>
    /// The value of Rigidbody2D.velocity.y set in Flap
    /// </summary>
    [field: SerializeField] private Vector2 JumpForce { get; set; }

    /// <summary>
    /// The max number of degrees by which this Bird may rotate per FixedUpdate
    /// </summary>
    [field: SerializeField] private float MaxDegreesDelta { get; set; }

    /// <summary>
    /// The Rigidbody2D component attatched to this Bird
    /// </summary>
    private Rigidbody2D Rigidbody2D { get; set; }

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        RotateTowardsTargetRotation();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Main.Instance.BroadcastMessage("OnGameEnd");
    }

    private void OnFlap()
    {
        Rigidbody2D.velocity = JumpForce;
    }

    private void OnGameEnd()
    {
        this.enabled = false;
        GetComponent<Animator>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Main.Instance.BroadcastMessage("OnPointScored");
    }

    private void RotateTowardsTargetRotation()
    {
        bool isDescending = Rigidbody2D.velocity.y < 0;
        Quaternion targetRotation = isDescending ? DescendentTargetRotation : AscentTargetRotation;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, MaxDegreesDelta);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Main.Instance.BroadcastMessage("OnFlap");
        }
    }
}