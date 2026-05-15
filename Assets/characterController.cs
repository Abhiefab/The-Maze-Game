using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController charControl;

    public float moveSpeed = 5f;

    [SerializeField] Transform cameraTransform;

    void Start()
    {
        charControl = GetComponent<CharacterController>();
    }

    void Update()
    {
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        Vector3 moveDir =
            forward.normalized * mv +
            right.normalized * mh;

        charControl.Move(moveDir * moveSpeed * Time.deltaTime);
    }
}