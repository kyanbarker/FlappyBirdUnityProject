using System.Linq;
using UnityEngine;

/// <summary>
/// Implementations of OnBecameVisible and OnBecameInvisible methods were not invoked upon their respective events.
/// VisibilityObserver restores functionality of OnBecameVisible and OnBecameInvisible methods
/// </summary>
public class VisibilityObserver : MonoBehaviour
{
    /// <summary>
    /// True if any Renderer in Renderers is visible, else false
    /// </summary>
    public bool IsVisible
    {
        get
        {
            // https://docs.unity3d.com/ScriptReference/GeometryUtility.TestPlanesAABB.html
            return Renderers.Any(renderer => GeometryUtility.TestPlanesAABB(Planes, renderer.bounds));
        }
    }

    public Plane[] Planes { get; set; }

    /// <summary>
    /// All Renderers child to this GameObject
    /// </summary>
    public Renderer[] Renderers { get; set; }

    /// <summary>
    /// True if visibility changed since the previous frame
    /// </summary>
    public bool VisibilityChanged
    {
        get
        {
            return WasVisible != IsVisible;
        }
    }

    /// <summary>
    /// The value of IsVisible on the previous frame
    /// </summary>
    public bool WasVisible { get; set; }

    private void Awake()
    {
        Planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
        Renderers = GetComponentsInChildren<Renderer>();
    }

    private void Update()
    {
        if (VisibilityChanged)
        {
            SendMessage(IsVisible ? "OnBecameVisible" : "OnBecameInvisible", SendMessageOptions.DontRequireReceiver);
        }
        WasVisible = IsVisible; // Store IsVisible to WasVisible so visibility across frames can be compared
    }
}