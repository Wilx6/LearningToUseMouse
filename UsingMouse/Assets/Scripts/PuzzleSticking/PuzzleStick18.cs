using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick18 : MonoBehaviour
{
    public GameObject sticked18;
    bool final18;

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
        if (final18)
        {
            sticked18.transform.position = new Vector2(-0.1442261f, -1.98f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP18"))
        {
            final18 = true;

        }
    }
}
