using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public string buttonID; // ID único que essa plataforma vai emitir

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"Botão {buttonID} pressionado");
            Channel.ButtonPressed(buttonID);
        }
    }
}