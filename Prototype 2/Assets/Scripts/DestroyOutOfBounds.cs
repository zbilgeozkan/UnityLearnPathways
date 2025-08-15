using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float bottomBound = -10f;

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the player's view, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)    // When the animals get pass the player
        {
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}
