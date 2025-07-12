using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    private WorkoutInfo currentWorkout;

    private Coroutine spawnRoutine;
    private bool isSpawning = false;

    public void SetCurrentWorkout(WorkoutInfo workout)
    {
        // Stop any ongoing spawning
        if (isSpawning && spawnRoutine != null)
        {
            StopCoroutine(spawnRoutine);
            isSpawning = false;
        }

        currentWorkout = workout;
    }

    public void ToggleSpawning()
    {
        if (currentWorkout == null)
        {
            Debug.LogWarning("No workout selected.");
            return;
        }

        if (!isSpawning)
        {
            spawnRoutine = StartCoroutine(SpawnBalls());
            isSpawning = true;
        }
        else
        {
            StopCoroutine(spawnRoutine);
            isSpawning = false;
        }
    }

    IEnumerator SpawnBalls()
    {
        foreach (WorkoutDetails detail in currentWorkout.workoutDetails)
        {
            Debug.Log("Spawning ball with ID: " + detail.ballId);  // ?? ADD THIS

            GameObject ball = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);


            Rigidbody rb = ball.GetComponent<Rigidbody>();

            Vector3 direction = new Vector3(detail.ballDirection, 0, 1).normalized;
            rb.AddForce(direction * detail.speed, ForceMode.Impulse);

            yield return new WaitForSeconds(2f);
        }

        isSpawning = false;
    }
}
