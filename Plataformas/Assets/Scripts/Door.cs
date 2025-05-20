using UnityEngine;

public class Door : MonoBehaviour
{
    public string buttonID; // ID que essa porta escuta

    private void OnEnable()
    {
        Channel.OnButtonPressed += CheckButton;
    }

    private void OnDisable()
    {
        Channel.OnButtonPressed -= CheckButton;
    }

    private void CheckButton(string pressedID)
    {
        if (pressedID == buttonID)
        {
            Debug.Log($"Porta associada ao botão {buttonID} abrindo...");
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        // Aqui você pode desativar o sprite, o collider ou fazer animação
        gameObject.SetActive(false); // Simplesmente desativa a porta
    }
}