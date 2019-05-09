using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    private void OnMouseEnter()
    {
        // If two or more fingers are touching the screen then Box will not be destroyed
        if(MainController.canDestroyBlocks)
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        MainController.numberOfBlocks--;
    }
}
