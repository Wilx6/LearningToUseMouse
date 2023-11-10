using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick16 : MonoBehaviour
{
    public GameObject sticked16;
    bool final16;

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
        if (final16)
        {
            sticked16.transform.position = new Vector2(-4.834961f, -2.004517f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP16"))
        {
            final16 = true;

        }
    }
}
