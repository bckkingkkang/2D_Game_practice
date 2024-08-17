using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour

{
    public GameObject a;

    private void Start()
    {
   
        /*a.SetActive(false);*/
        a.GetComponent<SpriteRenderer>().color = Color.yellow;
    }


}
