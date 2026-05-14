using Unity.VisualScripting;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public float distance = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position - new Vector3(distance,0,0);

        
    }
}
