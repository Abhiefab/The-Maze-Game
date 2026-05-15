using UnityEngine;

public class cameraController1 : MonoBehaviour
{
    [SerializeField] Transform followTarget;

    [SerializeField] float distance = 5f;

    [SerializeField] float minVerticalAngle = -45f;
    [SerializeField] float maxVerticalAngle = 45f;

    [SerializeField] Vector2 framingOffset;

    float mouseX;
    float mouseY;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY -= Input.GetAxis("Mouse Y");

        mouseY = Mathf.Clamp(mouseY, minVerticalAngle, maxVerticalAngle);

        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0);

        Vector3 focusPosition =
            followTarget.position +
            new Vector3(framingOffset.x, framingOffset.y, 0);

        transform.position =
            focusPosition - rotation * new Vector3(0, 0, distance);

        transform.rotation = rotation;
    }

    public Quaternion GetPlayerRotation()
    {
        return Quaternion.Euler(0, mouseX, 0);
    }
}