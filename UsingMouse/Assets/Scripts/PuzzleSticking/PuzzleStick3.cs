using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick3 : MonoBehaviour
{

    public GameObject sticked3;
    bool final3;
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
        if (final3)
        {
            sticked3.transform.position = new Vector2(-0.06097412f, 2.323578f);

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP3"))
        {
            final3 = true;

        }
     
    }
}
