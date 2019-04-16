using UnityEngine;
using UnityEngine.UI;

public class ButtonsController : MonoBehaviour
{
    // GameObject fields
    public Button welcomeButton;
    public Button locationButton;
    public Button innovationButton;
    public Button statsButton;
    
    private void Start()
    {
        welcomeButton.onClick.AddListener(TaskOnClick);
    }

    
    private static void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }
}