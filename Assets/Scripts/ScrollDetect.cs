using UnityEngine;
using UnityEngine.UI;

public class ScrollDetect : MonoBehaviour
{
    [SerializeField]
    private Scrollbar _scrollBar;
    [SerializeField]
    private ImageDownload _images;

    public void scrollbarCallBack()
    {
        if (_scrollBar.value < 0.01f)
        {
            _images.AddLoad(2);
        }
    }
}
