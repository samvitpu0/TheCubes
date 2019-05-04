using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    private void OnMouseEnter()
    {
        Destroy(gameObject);
    }
}
