using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour

{
    // 배열
    public int[] a;

    // 리스트
    public List<int> b = new List<int>();

    // 딕셔너리 <Key, Value>
    public Dictionary<string, int> c = new Dictionary<string, int>();

    private void Start()
    {
        c.Add("hello", 1);
        c.Add("Csharp", 2);
        c.Add("World", 3);

        Debug.Log(c["hello"]);

        // foreach
        foreach(var data in c)
        {
            Debug.Log(data);
            // var - 특정되지 않은 변수 선언
        }

        foreach(KeyValuePair<string, int> data in c)
        {
            Debug.Log("key : " + data.Key + ", value : " + data.Value);
        }

    }

}
