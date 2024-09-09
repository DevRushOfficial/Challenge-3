using UnityEngine;

public class PlayerBoundaries : MonoBehaviour
{
    public PlayerControllerX playerControllerX;

    private float _limitTopBoundary = 14.4f;
    private float _floatForce = 4f;

    void Start() => playerControllerX = GetComponent<PlayerControllerX>();

    void Update()
    {
        if (transform.position.y > _limitTopBoundary)
        {
            transform.position = new Vector3(transform.position.x, _limitTopBoundary, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            playerControllerX.playerRb.AddForce(Vector3.up * _floatForce, ForceMode.Impulse);
        }
    }
}
