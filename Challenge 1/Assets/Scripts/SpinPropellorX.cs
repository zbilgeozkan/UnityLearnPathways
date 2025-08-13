using UnityEngine;

public class SpinPropellorX : MonoBehaviour
{
    private float propellorSpeed = 1000.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
