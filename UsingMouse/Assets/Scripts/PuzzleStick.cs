using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick : MonoBehaviour
{
    public GameObject sticked;
    bool final;

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
        if (final)
        {
            sticked.transform.position = new Vector2(-2.39f, 0.9899999f);

        }

    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("PP1"))
            {
                final = true;
            }
        }
    }

