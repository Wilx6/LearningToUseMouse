using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick2 : MonoBehaviour
{
    public GameObject sticked2;
    bool final2;
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
        if (final2)
        {
            sticked2.transform.position = new Vector2(-2.461853f, 2.026978f);

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP2"))
        {
            final2 = true;

        }
    }








}

