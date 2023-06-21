using UnityEngine;

public class MusicTransition : MonoBehaviour
{
    private static MusicTransition Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
            Destroy(gameObject);
    }
}
