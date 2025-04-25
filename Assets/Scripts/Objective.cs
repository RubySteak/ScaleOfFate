using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{
    [SerializeField] private Text objectiveDisplay;
    
    [SerializeField] private string objectiveText = "Objective Text";
    [SerializeField] private string completedText = "Objective Done";

    public UnityEvent onCompleteObjective = new UnityEvent();

    private void OnEnable()
    {
        objectiveDisplay.text = objectiveText;
    }

    public void CompleteObjective()
    {
        if (gameObject.activeSelf)
        {
            objectiveDisplay.text = "";

            onCompleteObjective.Invoke();
        
            gameObject.SetActive(false);
        }
    }
}
