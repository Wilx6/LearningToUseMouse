using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick11 : MonoBehaviour
{
    public GameObject sticked11;
    bool final11;
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
        if (final11)
        {
            sticked11.transform.position = new Vector2(-4.411255f, -0.7323608f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP11"))
        {
            final11 = true;

        }
    }
}
