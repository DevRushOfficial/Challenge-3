using UnityEngine;

public class PlayerBoundaries : MonoBehaviour
{
    private float _limitBoundary = 14.4f;

    void Update()
    {
        if (transform.position.y > _limitBoundary)
        {
            transform.position = new Vector3(transform.position.x, _limitBoundary, transform.position.z);
        }
    }
}
