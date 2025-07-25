using TMPro;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    public int Score
    {
        get { return int.Parse(TextMeshPro.text); }
        set { TextMeshPro.text = value.ToString(); }
    }

    public TextMeshPro TextMeshPro { get; set; }

    private void Awake()
    {
        TextMeshPro = GetComponentInChildren<TextMeshPro>();
    }

    private void OnPointScored()
    {
        Score++;
    }
}