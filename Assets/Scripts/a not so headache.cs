using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishingLine : MonoBehaviour
{
    [Header("Specific Colliders to Monitor")]
    [SerializeField] private Collider2D colliderA;
    [SerializeField] private Collider2D colliderB;


    [Header("Game Won UI")]
    [SerializeField] private GameObject gameWonUI;

    private bool gameOverTriggered = false;
    private SpriteRenderer playerSprite;



    private void Update()
    {
        if (!gameOverTriggered && colliderA != null && colliderB != null && colliderA.IsTouching(colliderB))
        {
            TriggerWinCon();
        }
    }

    private void TriggerWinCon()
    {
        gameOverTriggered = true;

        // Play particle effect at player's position

        // Trigger Game Over UI
        if (gameWonUI != null)
        {
            gameWonUI.SetActive(true);
        }

        // Pause gameplay but keep UI functional
        Time.timeScale = 0f;
    }

 
}
