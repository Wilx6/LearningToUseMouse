using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick5 : MonoBehaviour
{
    public GameObject sticked5;
    bool final5;
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
        if (final5)
        {
            sticked5.transform.position = new Vector2(4.387329f, 2.308777f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP5"))
        {
            final5 = true;

        }
    }
}
