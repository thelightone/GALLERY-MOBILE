using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenScene : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Material image;
    [SerializeField]
    private Orientation orientation;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (image != null)
        {
            image.mainTexture= gameObject.GetComponent<Image>().sprite.texture;
            SceneManager.LoadScene("View", LoadSceneMode.Additive);
        }
    }

    public void LoadSceneGame()
    {
        SceneManager.LoadScene("Load");
    }

    public void DisactiveScene()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        SceneManager.UnloadSceneAsync("View");
    }
}
