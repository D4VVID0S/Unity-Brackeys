using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text GemCounterText;
    private int collectedGemsCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            Destroy(collision.gameObject);
            collectedGemsCount++;
            GemCounterText.text = "Gems: " + collectedGemsCount;
            Debug.Log(collectedGemsCount);
        }
    }
}