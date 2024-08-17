using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour

{
    public GameObject a;
    public Transform b;

    public Vector3 b_position;
    public Vector3 b_rotation;
    public Vector3 b_scale;

    private void Start()
    {
   
        a.GetComponent<SpriteRenderer>().color = Color.yellow;

        b.position = b_position;
        b.eulerAngles = b_rotation;
        b.localScale = b_scale;

        a.transform.position = b_position;
        b.gameObject.SetActive(true);
    }

    


}
