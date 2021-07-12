using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    private Vector3 offset;

    void Start()
    {
        offset = player.position + transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}

