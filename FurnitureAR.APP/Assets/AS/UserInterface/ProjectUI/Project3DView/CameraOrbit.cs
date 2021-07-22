using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
 
    private Vector3 currentMouse;
    private Vector3 mouseDelta;
    private Vector3 lastMouse;
 
    public static bool activeRotate = false;
    public Transform pivot; //

    public bool _enabled = false;

    public float distance = 3.0f;

    private Vector3 zoomVector;

    private Vector3 startPosition;

    private void Awake()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        mouseDelta = lastMouse - currentMouse;

        if (_enabled)
        {
            if (Input.GetMouseButtonDown(0))
            {
                activeRotate = true;
            }

            if (Input.GetMouseButtonUp(0))
            {
                activeRotate = false;
            }

            distance += Time.deltaTime * Input.mouseScrollDelta.y;

            if (Input.touchCount == 2)
            {
                var tZero = Input.GetTouch(0);
                var tOne = Input.GetTouch(1);
                distance += Vector2.Distance(tZero.deltaPosition, tOne.deltaPosition);
                if (distance < 0.5f)
                {
                    distance = 0.5f;
                }
            }

            currentMouse = Input.mousePosition;

            mouseDelta = lastMouse - currentMouse;
        }
    }

    public void Invalidate()
    {
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
        currentMouse = Vector3.zero;
        lastMouse = Vector3.zero;
        mouseDelta = Vector3.zero;
        distance = 3.0f;
    }
 
    void LateUpdate ()
    {
        if (pivot)
        {
            if (activeRotate)
            {
                transform.RotateAround(pivot.position, Vector3.up, mouseDelta.x * -.1f);
                transform.RotateAround(pivot.position, transform.right, mouseDelta.y * .1f);
            }

            transform.position = transform.position.normalized * distance;

            lastMouse = Input.mousePosition;
        }
    }
}
