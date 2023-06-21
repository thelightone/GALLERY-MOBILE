using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;
    [SerializeField]
    private TMP_Text _text;

    void Awake()
    {
        StartCoroutine(Loading());
    }

    IEnumerator Loading()
    {
        while (_slider.value > 0)
        {
            _text.text = Math.Round(100 - _slider.value * 100).ToString() + "%";
            _slider.value -= 0.005f;
            yield return null;
        }

        SceneManager.LoadScene("Gallery");

        // Для реальной загрузки сцены я бы использовал вариант ниже, но для задания он слишком быстро загружается

        // AsyncOperation load = SceneManager.LoadSceneAsync("Gallery");
        //while (!load.isDone) 
        //{
        //    slider.value = -load.progress;
        //....
    }
}

