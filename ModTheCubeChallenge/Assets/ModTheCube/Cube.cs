using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public Vector3 startPosition = new Vector3(3, 4, 1);
    public float scale = 1.3f;
    public Color cubeColor = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    public Vector3 rotationSpeed = new Vector3(10.0f, 0.0f, 0.0f);

    // Pulse effect
    public bool pulseScale = true;
    public float pulseSpeed = 2f;
    public float pulseAmount = 0.3f;

    private Vector3 baseScale;

    void Start()
    {
        baseScale = Vector3.one; // base scale

        // Starting values
        transform.position = startPosition;
        transform.localScale = baseScale * scale;

        Material material = Renderer.material;
        material.color = cubeColor;
    }

    void Update()
    {
        // Rotate the cube
        transform.Rotate(rotationSpeed * Time.deltaTime);

        // Keep position fixed
        transform.position = startPosition;

        // Apply pulse scale effect
        if (pulseScale)
        {
            float scaleFactor = 1 + Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;
            transform.localScale = baseScale * scale * scaleFactor;
        }
        else
        {
            transform.localScale = baseScale * scale;
        }

        // Change color in play mode
        Renderer.material.color = cubeColor;
    }

    void OnMouseDown()
    {
        // Change color when clicked
        cubeColor = new Color(Random.value, Random.value, Random.value, Random.Range(0.3f, 1f));
        Renderer.material.color = cubeColor;
    }
}
