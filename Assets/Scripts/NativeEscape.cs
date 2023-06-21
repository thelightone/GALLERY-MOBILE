using UnityEngine;

public class NativeEscape : MonoBehaviour
{
    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        {
           Application.Quit();
        }  
    }
}
