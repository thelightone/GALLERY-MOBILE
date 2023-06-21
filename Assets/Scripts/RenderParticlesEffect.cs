using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Camera))]
public class RenderParticlesEffect : MonoBehaviour
{
    [SerializeField] private Camera _particlesCamera;
    [SerializeField] private Vector2Int _imageResolution = new Vector2Int(256, 256);
    [SerializeField] private RawImage _targetImage;

    private RenderTexture renderTexture;

    private void Awake()
    {
        if (!_particlesCamera) 
            _particlesCamera = GetComponent<Camera>();

        renderTexture = new RenderTexture(_imageResolution.x, _imageResolution.y, 32);
        _particlesCamera.targetTexture = renderTexture;

        _targetImage.texture = renderTexture;
    }
}
