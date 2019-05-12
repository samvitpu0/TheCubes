using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    [Header("Prefab of destroy effect particle system")]
    public GameObject boxDestroyParticles;

    private void OnMouseEnter()
    {
        // If two or more fingers are touching the screen then Box will not be destroyed
        if (MainController.canDestroyBlocks)
        {
            MainController.numberOfBlocks--;
            Global.Score++;
            MainController.UpdateScore();
            Instantiate(boxDestroyParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


}
