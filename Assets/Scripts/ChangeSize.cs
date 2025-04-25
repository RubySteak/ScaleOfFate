using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    [SerializeField] private float modifiedScale = 2.0f;
    [SerializeField] private float changeRate = 2.0f;
    
    private Vector3 initialScale;
    private bool isScale = false;
    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, GetTargetScale(), changeRate * Time.deltaTime);
    }

    private Vector3 GetTargetScale()
    {
        return isScale ? Vector3.one * modifiedScale : initialScale;
    }

    public void ToggleScale()
    {
        isScale = !isScale;
    }
}
