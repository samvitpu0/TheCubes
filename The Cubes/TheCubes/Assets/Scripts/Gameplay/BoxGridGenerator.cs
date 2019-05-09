using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGridGenerator : MonoBehaviour
{
    /// <summary>
    /// Parent under which all the boxes will be created 
    /// </summary>
    public Transform gridParent;

    /// <summary>
    /// Instance of one box, change in this will reflect to all the boxes in the grid
    /// </summary>
    public GameObject boxInstance;

    /// <summary>
    /// Defines the number of boxes on each axism, for testing purpose its set to default value of 5
    /// </summary>
    private int _gridOrder = 5;

    // Start is called before the first frame update
    void Start()
    {
        GenarateGrid();
    }
    
    /// <summary>
    /// Generates Grid of Boxes according to _gridOrder 
    /// </summary>
    private void GenarateGrid()
    {
        for(int i = 0; i < _gridOrder; i++)
        {
            for(int j = 0; j < _gridOrder; j++)
            {
                for(int k = 0; k < _gridOrder; k++)
                {
                    var _box = Instantiate(boxInstance, new Vector3(i,j,k),Quaternion.identity, gridParent) as GameObject;
                    MainController.numberOfBlocks++;
                }
            }
        }

        gridParent.transform.position = new Vector3(-2f, -2f, -2f);
    }

}
