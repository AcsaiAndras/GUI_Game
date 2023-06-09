using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    //int pineappleCollected = 0;
    
    [SerializeField] Text pineappleCounter;
    [SerializeField] AudioSource collectSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pineapple"))
        {
            collectSound.Play();
            Destroy(collision.gameObject);
            //pineappleCollected++;
            CounterKeeping.counter++;
            //pineappleCounter.text = $"Pineapples: {pineappleCollected}";
            pineappleCounter.text = $"Pineapples: {CounterKeeping.counter}";
        }
    }

}
