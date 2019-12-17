using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepUp : MonoBehaviour
{
    private GameObject enemyObj;
    // Start is called before the first frame update
    void Start()
    {
        enemyObj = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        enemyObj.transform.rotation = Quaternion.identity; ;
    }
}
