using UnityEngine;
using UnityEngine.Events;

public class DialogueText : MonoBehaviour
{
    [SerializeField] public string dialogueText = "";

    public UnityEvent OnInteract = new UnityEvent();

    private void OnEnable()
    {
        
    }

    public string GetDialogueText()
    {
        return dialogueText;
    }

    public void Interact()
    {
        OnInteract.Invoke();
    }
}
