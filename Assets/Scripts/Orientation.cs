using System.Collections;
using UnityEngine;

public class Orientation : MonoBehaviour
{

    public enum scrOrientation
    {
        Portrait,
        Any
    }    
    public scrOrientation screenOrientation;

    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    private void FixedUpdate()
    { 
        switch (screenOrientation)
        {
            case scrOrientation.Portrait:

                Screen.orientation = ScreenOrientation.AutoRotation;

                Screen.autorotateToPortrait = Screen.autorotateToPortraitUpsideDown = true;
                Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = false;

                break;

            case scrOrientation.Any:

                Screen.autorotateToPortrait = Screen.autorotateToPortraitUpsideDown = true;
                Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = true;

                break;
        }
    }
}
