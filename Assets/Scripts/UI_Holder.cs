using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Holder : MonoBehaviour
{
    // Retry 버튼 클릭 시
    public void RetryBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
