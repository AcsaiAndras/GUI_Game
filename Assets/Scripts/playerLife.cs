using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerLife : MonoBehaviour
{
    Animator anim;
    Rigidbody2D Rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Death();
        }
    }

    private void Death()
    {
        anim.SetTrigger("Death");
        Rigidbody.bodyType = RigidbodyType2D.Static;
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
