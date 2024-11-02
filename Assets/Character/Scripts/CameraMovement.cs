using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    public float smooth = 5.0f;
    public Vector3 offset = new Vector3(0, 2, -5);

    void Start()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * smooth);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}