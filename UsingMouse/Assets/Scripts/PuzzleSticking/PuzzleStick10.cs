using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick10 : MonoBehaviour
{
    public GameObject sticked10;
    bool final10;
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
        if (final10)
        {
            sticked10.transform.position = new Vector2(4.775879f, 0.8074341f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP10"))
        {
            final10 = true;

        }
    }
}
