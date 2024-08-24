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

    /*c.Add("hello", 1);
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
        }*/

    /*
    - Life Cycle 생명주기
      : 일정한 흐름에 따라 함수가 호출

    Awake -> OnEnable -> Start : play 버튼을 눌렀을 경우 최초 한 번만 실행
    FixedUpdate -> Update -> LateUpdate : 플레이 버튼을 눌렀을 경우 매 프레임마다 호출
    OnApplicationAuit -> OnDisable -> OnDestroy : 게임이 종료되었을 때 호출

    OnEnable, OnDisable 은 각 오브젝트가 활성화, 비활성화 되었을 때 한 번씩 호출

    OnApplicationQuit -> 게임이 종료되었을 때
    OnDisable -> 오브젝트가 비활성화되었을 때
    OnDestroy -> 오브젝트가 파괴되었을 때

    */

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // play 버튼을 눌렀을 경우 최초 한 번만 실행
    private void Start() // 생명주기 Life Cycle 함수
    {
        Debug.Log("Start");
    }

    // play 버튼을 눌렀을 경우 매 프레임마다 호출
    private void Update()
    {
        /*Debug.Log("Update");*/
    }

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
