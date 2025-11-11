using UnityEngine;

public class CameraAspectFixer : MonoBehaviour
{
    [SerializeField] private float targetAspect = 16f / 9f; // Target aspect ratio

    private Camera cam;
    private float initialSize;

    void Start()
    {
        cam = GetComponent<Camera>();
        initialSize = cam.orthographicSize;
    }

    void Update()
    {
        float currentAspect = (float)Screen.width / (float)Screen.height;

        // Adjust size based on aspect ratio difference
        if (currentAspect < targetAspect)
        {
            cam.orthographicSize = initialSize * (targetAspect / currentAspect);
        }
        else
        {
            cam.orthographicSize = initialSize;
        }
    }
}