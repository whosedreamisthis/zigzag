# zigzag
A 3D unity game  - walking through a Udemy course game.
# ZigZag Runner

A simple, endless runner game built in Unity, featuring dynamic platform spawning and high-score tracking, inspired by the popular mobile game *ZigZag*.

## 🌟 Features

* **One-Touch Controls:** Simple tap-to-change direction gameplay (see `BallController.cs`).
* **Dynamic Platform Spawning:** Platforms are randomly spawned along the X and Z axes to create an endless path (see `PlatformSpawner.cs`).
* **Score Tracking:** The player earns points over time. Scores and High Scores are saved locally using `PlayerPrefs` (see `ScoreManager.cs`).
* **Game Over Logic:** The game ends when the ball falls off a platform, triggering the `GameOver` state via a Raycast check (see `BallController.cs`).
* **Camera Follow:** A smooth camera system uses `Vector3.Lerp` to follow the ball (see `CameraFollow.cs`).
* **UI Management:** Clear distinction between the main menu, game state, and game over screen (see `UIManager.cs`).
* **Collectibles:** Diamonds are spawned randomly on platforms and destroyed on contact, along with a particle effect (see `PlatformSpawner.cs` and `BallController.cs`).

## 🛠️ Project Setup

This project was developed using **Unity**.

### Prerequisites

* **Unity:** Version 2021 LTS or later is recommended.
* **TextMeshPro:** Ensure the package is imported into your project (needed for score displays in `UIManager.cs`).

### Getting Started

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/whosedreamisthis/zigzag.git](https://github.com/whosedreamisthis/zigzag.git)
    ```
2.  **Open in Unity:** Open the cloned `zigzag` folder as a project in the Unity Editor.
3.  **Run the Main Scene:** Locate and open your main game scene (likely named `SampleScene` or `MainGame`).
4.  **Play:** Press the Play button in the Unity Editor to start the game.

## 📁 Core Script Breakdown

The game logic is distributed across several C# scripts:

| Script Name | Purpose | Key Functionality |
| :--- | :--- | :--- |
| **`GameManager.cs`** | Central control for game state. | Manages `gameOver` status. Triggers `StartGame()` and `GameOver()` across all relevant systems (UI, Scoring, Spawning). |
| **`BallController.cs`** | Handles player input and movement. | Detects mouse tap to start the game and switch direction. Uses a Raycast to check if the ball is on a platform. |
| **`PlatformSpawner.cs`** | Creates the endless path. | Spawns platforms randomly along the X or Z axis at a fixed interval (`InvokeRepeating`). Randomly spawns **Diamond** collectibles. |
| **`ScoreManager.cs`** | Manages scoring and persistent data. | Uses `InvokeRepeating` to increment the score over time. Saves the score and high score using `PlayerPrefs`. |
| **`TriggerChecker.cs`** | Detects when a platform should be destroyed. | Attached to platforms, it detects when the "Ball" leaves its collider and initiates the platform's destruction after a brief delay (`FallDown` function). |
| **`UIManager.cs`** | Controls all HUD and Panel displays. | Updates the score and high score displays. Manages the visibility of the start panel, game over panel, and restart functionality. |
| **`CameraFollow.cs`** | Implements the camera movement. | Calculates an initial offset from the ball and uses `Vector3.Lerp` in `Update()` to smoothly follow the ball's movement. |

## 🌐 Play the WebGL Build

You can play the latest WebGL build of this game directly in your browser here:

[**Play ZigZag Runner on GitHub Pages**](https://whosedreamisthis.github.io/zigzag/)

***
*Developed by whosedreamisthis*