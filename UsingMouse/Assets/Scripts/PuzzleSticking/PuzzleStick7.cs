using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick7 : MonoBehaviour
{
    public GameObject sticked7;
    bool final7;
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
        if (final7)
        {
            sticked7.transform.position = new Vector2(-2.753235f, 0.8102417f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP7"))
        {
            final7 = true;

        }
    }
}
