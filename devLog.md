# Development Log

This log is meant to keep a track of the development process of this project. It is meant to be a reference for myself and others to see how the project has evolved over time. 

### 2023-10-29
- Fixed a problem with the reward structure script.
- Added a new set of Ray Perceptions to detect the opponent vehicles.
- Retrained the agent on Left Oval track.
- Trained the agent on Right Oval track for 3M steps as well.
- Added a new Circuit
- Made Prefabs for creating circuits faster.

### 2023-10-28
- Created Right Oval Track to train the Agent to take right turns.
- Structured the Rewards in a single Script for ease in future.

### 2023-10-27
- Updated Reward Function to a better one.
- Changed a few controls -> brake is discrete and throttle is only forwards now.
- Updated the Config file for training using Imitation Learning for Left Oval Track.
- Added a demo for Imitation Learning.
- Used Imitation Learning to speed up the learning process of AI on Left Oval Track. *.onnx* saved in Models folder.

### 2023-10-26
- Updated behaviour script to reset the car position, rotation and velocity on ResetEnv()
- Made Walls (red) and Checkpoints (green) translucent in the game view.
- Added 2 Ray perception sensors to the Car. One for detecting Walls and other to detect the Checkpoints.
- Added DetectCollision script to detect collisions with Wall and Checkpoint for rewarding/punishing the agent.
- Added Demo for Imititation Learning. (early stage and will be updated)
- Added Speed of the car as an observation which was earlier giving an error.

### 2023-10-25
- Added track walls and checkpoints to the first oval track.
- Added behaviour script for the car. (Only OnActionRecieved() and Heuristics() are set as of now)

### 2023-10-24
- Set up car the car controls. Yet to add it in the game.
- Choose the track layouts for curriculum learning. Yet to add it in the game.
- Added 2 Oval tracks to the project for curriculum learning.
- Added Car to the game which can be controlled by the **Player**.
- Camera follows the car when in play mode.

### 2023-10-23
- Initialized the Project, set up git and github.
- Added ML_Agents20 package. Was supposed to use ML_Agents21 but it was giving error while installing dependencies.