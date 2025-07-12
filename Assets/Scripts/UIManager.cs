using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public JSONLoader loader;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public GameObject buttonTemplate;
    public Transform buttonContainer;
    public BallSpawner ballSpawner;


    void Start()
    {
        titleText.text = loader.workoutData.ProjectName;

        foreach (var workout in loader.workoutData.workoutInfo)
        {
            GameObject btn = Instantiate(buttonTemplate, buttonContainer);
            btn.SetActive(true);
            btn.GetComponentInChildren<TextMeshProUGUI>().text = workout.workoutName;

            WorkoutInfo capturedWorkout = workout;
            btn.GetComponent<Button>().onClick.AddListener(() =>
            {
                descriptionText.text = capturedWorkout.description;
                ballSpawner.SetCurrentWorkout(capturedWorkout);  // ?? This connects it
            });
        }
    }

}
