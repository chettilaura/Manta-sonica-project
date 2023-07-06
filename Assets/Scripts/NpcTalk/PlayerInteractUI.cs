using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerInteractUI : MonoBehaviour {

    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerInteract playerInteract;
    [SerializeField] private TextMeshProUGUI interactTextMeshProUGUI;

    private void Update() {

        Debug.Log("Sto controllando!");
        if (playerInteract.GetInteractableObject() != null) {
            Debug.Log("Sto showando l'UI");
            Debug.Log(playerInteract);
            Show(playerInteract.GetInteractableObject());
        } else {
            Hide();
        }
    }

    private void Show(IInteractable interactable) {
        containerGameObject.SetActive(true);
        
        interactTextMeshProUGUI.text = interactable.GetInteractText();
    }

    private void Hide() {
        Debug.Log("Sono nella hide");
        containerGameObject.SetActive(false);
    }

}