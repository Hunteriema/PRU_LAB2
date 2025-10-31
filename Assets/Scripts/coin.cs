using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1; // how much this coin is worth

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin collected!");


            Destroy(gameObject);
            coinCounter.coinValue += 1;
        }
    }
    private void Update()
    {
   
    }
}
