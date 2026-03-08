# Mission Demolition
## Course Information
Southern Illinois University Edwardsville  
**Course:** CS 382 - Game Design, Development, and Technology
<br> **Authors:** Ryan Bender and Jacob Stephens


## Project Overview
**Click to play through Unity Play:** [https://play.unity.com/en/games/937d16d3-3679-4be4-96a6-3ef80fe58078/mission-demolition](url)

Mission Demolition is a physics-based projectile game where the player uses a slingshot to launch projectiles at castle targets.
Each level challenges the player to land accurate shots, trigger the goal, and progress through the full set of castles.

<br>The game demonstrates foundational Unity concepts, including:
- Scene management and UI flow
- Physics-based projectile mechanics
- Camera tracking and view switching
- Level progression and completion states
- Persistent progress tracking with PlayerPrefs
- Menu systems (Main Menu, Level Select, Win Screen)

## Added Element - "To Make the Game Cooler in a Meaningful Way"
To make the game cooler in a meaningful way, 


## Game Aspect Notes
When loaded into Unity, the Game view may default to Free Aspect.
For the best visual layout and UI alignment, use 16:9 or Full HD (1920 x 1080) in the Game view.
Built versions should scale correctly, but the editor viewport does not always automatically switch aspect ratios.

## Gameplay
### How to Play
- Click and hold on the slingshot to spawn and pull back a projectile.
- Drag to aim your shot.
- Release the mouse to fire.
- Hit the level goal with a projectile to complete the level.
- Progress through all available levels to reach the final win screen.
- Track performance using the on-screen Shots Taken counter.

### Level Progression
- Starting from the Main Menu begins at Level 1.
- Completing a level advances to the next level automatically.
- Level Select allows players to jump directly to specific levels.
- Completed levels are saved and shown with trophy indicators.
- Progress can be reset from the Level Select screen.

## Screens
### Main Menu Screen
<img width="973" height="516" alt="Main Menu" src="https://github.com/user-attachments/assets/78009df8-f82d-4fdf-a0d1-e4fce2dd2d2e" />

### Level Select
<img width="1919" height="1077" alt="Level Selection" src="https://github.com/user-attachments/assets/5065de5a-2bb4-4dbd-9e53-74f457bff62f" />

Gameplay (Slingshot + Castle Levels)
<img width="972" height="514" alt="Level Display" src="https://github.com/user-attachments/assets/5d90f73b-f33a-42a5-9706-40255ca3a9d3" />


Final Win Screen
Main Menu
Start: Begins gameplay from the first level.
Select Level: Opens the level selection menu.
Exit: Closes the game application.
Level Select
Choose from the available level buttons.
View completion trophies for finished levels.
Reset saved level completion progress.
Return to Main Menu.
Win Screen
Appears after completing the final level.
Main Menu button returns to the title screen.
Restart button restarts from the first level.
