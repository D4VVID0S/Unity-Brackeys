using UnityEngine;
using UnityEngine.UI;

public class CherryCollector : MonoBehaviour
{
    [SerializeField] private Text CherryCounterText;
    private int collectedCherryCount = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CollectibleCherry"))
        {
            Destroy(collision.gameObject);
            collectedCherryCount++;
            CherryCounterText.text = "Cherries: " + collectedCherryCount;
            Debug.Log(collectedCherryCount);
        }
    }
}