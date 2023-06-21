using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class ImageDownload : MonoBehaviour
{
    [SerializeField]
    private Image _image;
    [SerializeField]
    private GameObject _canvasContent;

    private float _imageNumber = 0;

    private void Awake()
    {
        AddLoad(4);
    }

    IEnumerator DownloadImage(string MediaUrl)
    {
        Image newImage = Instantiate(_image);
        newImage.transform.SetParent(_canvasContent.transform, false);
        newImage.transform.localScale = new Vector3(1, 1, 1);

        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);

        UnityWebRequestAsyncOperation async = request.SendWebRequest();
        while (!async.isDone) { yield return null; }
        //yield return request.SendWebRequest();

        if (
            request.result == UnityWebRequest.Result.ConnectionError
            || request.result == UnityWebRequest.Result.ProtocolError
            )
            Debug.Log(request.error);
        else
        {
           Texture2D texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
           newImage.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        }
    }


    public void AddLoad(float iterations)
    {
        for (int i = 0; i < iterations; i++)
        {
            if (_imageNumber < 66)
            {
                _imageNumber++;
                StartCoroutine(DownloadImage("https://data.ikppbb.com/test-task-unity-data/pics/" + _imageNumber + ".jpg"));
            }
        }
    }
}
