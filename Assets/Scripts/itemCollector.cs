using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    int pineappleCollected = 0;

    [SerializeField] Text pineappleCounter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            Destroy(collision.gameObject);
            pineappleCollected++;
            pineappleCounter.text = $"Pineapples: {pineappleCollected}";
        }
    }

}
