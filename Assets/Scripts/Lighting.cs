using UnityEngine;

public class Lighting : MonoBehaviour
{
    public float followSpeed = 3f;

    private Transform player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        Vector3 targetPosition = player.position;

        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed);
    }
}
