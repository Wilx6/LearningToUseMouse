using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick17 : MonoBehaviour
{
    public GameObject sticked17;
    bool final17;

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
        if (final17)
        {
            sticked17.transform.position = new Vector2(-2.503479f, -2.239685f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP17"))
        {
            final17 = true;

        }
    }
}
