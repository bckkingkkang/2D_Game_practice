using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Holder : MonoBehaviour
{
    // Retry ��ư Ŭ�� ��
    public void RetryBtn()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
