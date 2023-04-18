# Jumper-Frog-Game

Welcome to Jumper Frog! This is a simple 2D game where the player controls a frog that needs to cross the road while avoiding the driving cars.

![Alt text](Assets/Screenshots/midgameScreenshot.png)
# Play
[Play on itch.io](https://barakdf.itch.io/frog-jump)

# Gameplay
The objective of the game is to help the frog cross the road and the river by avoiding the moving cars. The game ends in failure when the frog gets hit by a car, or in success if the frog gets to the other side.

# Game Controls

The controls for the game are as follows:

- W: Move the frog upwards
- A: Move the frog to the left
- S: Move the frog downwards
- D: Move the frog to the right

# Screenshots

![Alt text](Assets/Screenshots/WinScreenshot.png)
![Alt text](Assets/Screenshots/LoseScreenshot.png)

# Code

This is the following scripts I used for thie implementation:
- [TimeSpawner](Assets/Scripts/TimedSpawner.cs) and [Mover](Assets/Scripts/Mover.cs) for the cars spawn.
- [PlayerMovement](Assets/Scripts/PlayerMovement.cs) for the frog movement on the map.
- [DestroyOnTrigger2D](Assets/Scripts/DestroyOnTrigger2D.cs) for handling collision between frog and cars.
- [WinDirect](Assets/Scripts/WinDirect.cs) for directing the player to the winner scene.