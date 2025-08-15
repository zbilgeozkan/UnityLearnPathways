using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other) // Override a function
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
