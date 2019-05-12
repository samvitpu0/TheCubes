using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    public static Action UpdateScore;

    /// <summary>
    /// The value will be changed to false when 2 fingers are touching the screen, if false the Grid Boxes
    /// cannot be destroyed. Set back to true when only one finger is touching the screen.
    /// </summary>
    [HideInInspector]
    public static bool canDestroyBlocks = true;

    /// <summary>
    /// This will hold total number of Boxes genarated in the level
    /// </summary>
    [HideInInspector]
    public static int numberOfBlocks = 0;

    /// <summary>
    /// Gameobject of the Trail Particle System
    /// </summary>
    [Header("Gameobject of the Trail Particle System")]
    public GameObject fingerTrail;

    /// <summary>
    /// Root Gameobject of the Grid
    /// </summary>
    [Header("Root Gameobject of the Grid")]
    public GameObject grid;

    /// <summary>
    /// speed by which the Box Grid will be rotated (-)ve value is used 
    /// to rotate the grid in the direction of finger swipe
    /// </summary>
    private float rotationSpeed = -0.5f;

    void Update()
    {
        // To eneable the finger trail only when one finger is touching the screen
        if (Input.GetMouseButton(0) && Input.touchCount == 1)
        {
            // To make sure trail appears at the posision where finger start touching
            fingerTrail.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            fingerTrail.SetActive(true);
        }
        else
        {
            fingerTrail.SetActive(false);
        }

        /**
         * Determines if the Boxes can be destroyed or not and
         * also used to rotate the object with 2 finger swipe action
         **/
        if(Input.touchCount > 1)
        {
            canDestroyBlocks = false;

            var _touch = Input.touches[0];

            if(_touch.phase == TouchPhase.Moved)
            {
                grid.transform.RotateAround(new Vector3(0f, 0f, 0f),Vector3.up, rotationSpeed * _touch.deltaPosition.x);
            }

        }
        else
        {
            canDestroyBlocks = true;
        }

        if(numberOfBlocks <= 0)
        {
            Global.Level++;

            //TODO For Testing
            CurrencyController._instance.CreditCoins(10);
            SceneManager.LoadScene("Main");
        }
    }
}
