using UnityEngine;

public class Background : MonoBehaviour
{
    /// <summary>
    /// Destroy this Background when it is no longer visible
    /// </summary>
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// Instantiate this Background when it becomes visible.
    /// Position the instance tangent to this Background's right
    /// </summary>
    private void OnBecameVisible()
    {
        Vector3 positionOffset = new Vector3(6, 0, 0); // 6 is the width of a Background
        Instantiate(gameObject, transform.parent).transform.position += positionOffset;
    }
}