using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPlayerOnSpecificCollision : MonoBehaviour
{
    [Header("Specific Colliders to Monitor")]
    [SerializeField] private Collider2D colliderA;
    [SerializeField] private Collider2D colliderB;

    [Header("Player Reference")]
    [SerializeField] private GameObject player;

    [Header("Effect")]
    [SerializeField] private ParticleSystem destroyEffect;

    [Header("Game Over UI")]
    [SerializeField] private GameObject gameOverUI;

    private bool gameOverTriggered = false;
    private SpriteRenderer playerSprite;

    private void Start()
    {
        if (player != null)
        {
            playerSprite = player.GetComponent<SpriteRenderer>();
        }
    }

    private void Update()
    {
        if (!gameOverTriggered && colliderA != null && colliderB != null && colliderA.IsTouching(colliderB))
        {
            TriggerDestruction();
        }
    }

    private void TriggerDestruction()
    {
        gameOverTriggered = true;

        // Play particle effect at player's position
        if (destroyEffect != null && player != null)
        {
            Instantiate(destroyEffect, player.transform.position, Quaternion.identity);
        }

        // Hide player's sprite (but keep object for camera)
        if (playerSprite != null)
        {
            playerSprite.enabled = false;
        }

        // Trigger Game Over UI
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }

        // Pause gameplay but keep UI functional
        Time.timeScale = 0f;
    }

 
}
