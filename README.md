# Mission Demolition
## Course Information
Southern Illinois University Edwardsville  
**Course:** CS 382 - Game Design, Development, and Technology
<br> **Authors:** Ryan Bender and Jacob Stephens


## Project Overview
**Click to play through Unity Play:** [Mission Demolition](https://play.unity.com/en/games/937d16d3-3679-4be4-96a6-3ef80fe58078/mission-demolition)

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
&nbsp; To make the game cooler in a meaningful way, we added a Level Selection screen, because it makes the game feel less linear and more player-driven. Instead of forcing players to restart the full sequence every time, the screen lets them jump directly to any level and replay the same level repeatedly for practice. This addition makes skill-building intentional. If a player struggles with a specific castle layout or wants to improve shot efficiency, they can play that exact level over and over until they master it.

&nbsp; We also added a trophy indicator system tied to level completion. Each completed level displays a trophy icon, giving players clear visual feedback on progress and a stronger sense of achievement. This turns progression into something you can see at a glance, while still encouraging replay for improvement. Together, instant level replay plus completion trophies make the game more engaging, motivating, and meaningful than a basic “next level only” flow. Additionally, if a player wants to reset their achievements, there is a reset button that will remove the trophies, so they can earn them again.

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
#### Main Menu Screen
<img width="973" height="516" alt="Main Menu" src="https://github.com/user-attachments/assets/78009df8-f82d-4fdf-a0d1-e4fce2dd2d2e" />
<br> Play: Begins gameplay from the first level.
<br> Select Level: Opens the level selection menu.
<br> Exit: Closes the game application.

#### Level Select
<img width="1919" height="1077" alt="Level Selection" src="https://github.com/user-attachments/assets/5065de5a-2bb4-4dbd-9e53-74f457bff62f" />

#### Gameplay (Slingshot + Castle Levels)
<img width="972" height="514" alt="Level Display" src="https://github.com/user-attachments/assets/5d90f73b-f33a-42a5-9706-40255ca3a9d3" />

#### Final Win Screen
<img width="971" height="513" alt="Win Screen" src="https://github.com/user-attachments/assets/af165e3a-870b-459b-a06f-2fe8429db4df" />
<br> Appears after completing the final level
<br> Main Menu: Returns to the title screen
<br> Restart: Restarts from the first level
