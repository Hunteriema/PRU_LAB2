using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SnowboarderController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float torqueAmount = 10f;
    [SerializeField] private float boostSpeed = 30f;
    [SerializeField] private float normalSpeed = 20f;
    [SerializeField] private float brakeSpeed = 10f;

    [Header("Effects")]
    [SerializeField] private ParticleSystem boostParticles; // Assign in Inspector

    private Rigidbody2D rb;
    private SurfaceEffector2D surfaceEffector;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector = FindFirstObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        ControlSpeed();
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            rb.AddTorque(torqueAmount);
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            rb.AddTorque(-torqueAmount);
    }

    void ControlSpeed()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = boostSpeed;

            if (!boostParticles.isPlaying)
                boostParticles.Play(); // Start particles
        }
        else
        {
            surfaceEffector.speed = normalSpeed;

            if (boostParticles.isPlaying)
                boostParticles.Stop(); // Stop particles
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            surfaceEffector.speed = brakeSpeed;
    }
}
