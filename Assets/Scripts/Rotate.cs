using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speed = 2f;


    private void Update()
    {
        transform.Rotate(0,0,306 * speed * Time.deltaTime);
    }

}
