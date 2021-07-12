using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public Transform plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = plane.position + transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.position + offset;
    }
}
