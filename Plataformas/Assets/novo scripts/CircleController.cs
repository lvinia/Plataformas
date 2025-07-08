using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CircleController : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    [Header("Listening to...")] 
    public VoidEventChannel circleColorEvent;
    public ColorEventChannel circleSpecificColorEvent;

    private void Awake()
    {
            _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        circleColorEvent.OnEventRaised += MudaCor;
        circleSpecificColorEvent.OnEventRaised += MudaCorEspecifica;
    }

    private void OnDisable()
    {
        circleColorEvent.OnEventRaised -= MudaCor;
        circleSpecificColorEvent.OnEventRaised -= MudaCorEspecifica;
    }
    public void MudaCor()
    {
        _spriteRenderer.color = Random.ColorHSV();
    }

    private void MudaCorEspecifica(Color corEspecifica)
    {
        _spriteRenderer.color = corEspecifica;
    }
}
