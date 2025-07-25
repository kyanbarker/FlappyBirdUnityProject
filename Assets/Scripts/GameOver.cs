using System.Collections;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [field: SerializeField] public Vector3 DesiredPosition { get; set; }
    [field: SerializeField] public float MaxDistanceDelta { get; set; }

    private IEnumerator MoveTowardsDesiredPosition()
    {
        while (Vector3.Distance(transform.position, DesiredPosition) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, DesiredPosition, MaxDistanceDelta);
            yield return new WaitForFixedUpdate();
        }
    }

    private void OnGameEnd()
    {
        StartCoroutine(MoveTowardsDesiredPosition());
    }
}