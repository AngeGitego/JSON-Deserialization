using UnityEngine;

public class JSONLoader : MonoBehaviour
{
    public WorkoutRoot workoutData;

    void Awake()
    {
        TextAsset jsonText = Resources.Load<TextAsset>("WorkoutInfoJSONAssignment");
        workoutData = JsonUtility.FromJson<WorkoutRoot>(jsonText.text);

        Debug.Log("Loaded Project: " + workoutData.ProjectName);
    }
}
