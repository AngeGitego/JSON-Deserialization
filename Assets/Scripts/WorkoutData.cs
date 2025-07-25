using System;
using System.Collections.Generic;

[Serializable]
public class WorkoutRoot
{
    public string ProjectName;
    public int numberOfWorkoutBalls;
    public List<WorkoutInfo> workoutInfo;
}

[Serializable]
public class WorkoutInfo
{
    public int workoutID;
    public string workoutName;
    public string description;
    public string ballType;
    public List<WorkoutDetails> workoutDetails;
}

[Serializable]
public class WorkoutDetails
{
    public int ballId;
    public float speed;
    public float ballDirection;
}
