using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick12 : MonoBehaviour
{
    public GameObject sticked12;
    bool final12;
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
        if (final12)
        {
            sticked12.transform.position = new Vector2(-2.475708f, -0.7499695f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP12"))
        {
            final12 = true;

        }
    }
}
