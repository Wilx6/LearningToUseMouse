using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick19 : MonoBehaviour
{
    public GameObject sticked19;
    bool final19;

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
        if (final19)
        {
            sticked19.transform.position = new Vector2(2.35f, -2.2f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP19"))
        {
            final19 = true;

        }
    }
}
