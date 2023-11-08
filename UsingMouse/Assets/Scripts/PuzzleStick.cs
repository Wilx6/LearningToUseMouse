using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick : MonoBehaviour
{
    Vector2 sticked;

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
        if (gameObject.CompareTag(this.gameObject.tag))
        {
            sticked = new Vector2(1.2f, 12.23f);
            Debug.Log("It's the same");
        }


    }



}
