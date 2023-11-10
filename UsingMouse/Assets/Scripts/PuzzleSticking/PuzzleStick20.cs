using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick20 : MonoBehaviour
{
    public GameObject sticked20;
    bool final20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp()
    {
        if (final20)
        {
            sticked20.transform.position = new Vector2(4.78f, -2f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP20"))
        {
            final20 = true;

        }
    }
}
