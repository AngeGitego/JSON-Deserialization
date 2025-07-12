Objective
This project will enhance your understanding of JSON deserialization, dynamic UI generation, and coroutines in Unity using C#. You will load data from a JSON file, dynamically create UI elements, and implement gameplay mechanics based on the deserialized data.

Project Requirements
1. JSON File Setup
Use the JSON file set up hereLinks to an external site..
Add a new attribute to the JSON file:
"ProjectName": "Isiaq JSON Project"
The ProjectName attribute should follow the format: Your Name + "JSON Project".
Include the JSON file in your Unity project and load it dynamically using Unity’s TextAsset or file handling methods.
2. Unity Project Setup
Create a new Unity project.
Add a Canvas GameObject to the scene.
Create a Title Text UI element that displays the ProjectName from the JSON file.
3. Dynamic Button Generation
Deserialize the workoutInfo array from the JSON file.
Dynamically generate UI buttons based on the number of objects in workoutInfo.
Display the workoutName on each button.
(Bonus) Generate buttons at runtime and assign functionalities dynamically.
4. Workout Selection & Ball Spawning
Add a single Play/Pause button to manage ball spawning.
Default text: "Play".
Clicking "Play" should:
Start spawning balls based on the selected workout.
Change the button text to "Pause".
Clicking "Pause" should:
Stop the ball spawning coroutine.
Change the button text back to "Play".
When switching workouts, ensure:
Any active coroutine stops.
The Play/Pause button resets to "Play".
5. Workout Description Display
Add a Text UI element with the default text "Workout Description here".
When a workout button is clicked, update the text box with the description of the selected workout.
6. Ball Prefab, Rigidbody & Movement
Create a ball prefab (either a textured sphere or an imported 3D model).
Attach a Rigidbody component to the ball.
Clicking a workout button should spawn the number of balls defined in workoutDetails.
Each ball must spawn one at a time, not all at once.
Use coroutines to introduce a 2-second delay between spawns.
The ballDirection attribute should map as follows:
"right" → 0.5f
"center" → 0f
"left" → -0.5f
Move the ball using AddForce() on the Rigidbody component, applying force in the correct direction.
