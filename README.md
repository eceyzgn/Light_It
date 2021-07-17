# Light_It
## GAME STORY 
The world has come to an end and zombies have appeared. But these zombies are sensitive to 
light, not sound. Therefore, within the given time, the player has to turn on all the lamps in the 
room before the zombies come. If the player does not turn on all the lights in time, they will be 
killed by zombies.
### Design
• Splash Scene

While this scene was being made, the logo of the game was added to the raw image in an 
animated way. After the animation is finished, it is passed to the Main menu

![splash](https://user-images.githubusercontent.com/59119008/126046980-a3a706ef-e626-4d61-9ed0-aa6a32467e95.png)

• Main Menu Scene

While designing this scene, the wall and floor were created with the 3d cube. 3d cylinder has 
been added to the top of the wall. Cylinder is shaped like an eye with Texture and then 
animation is added. Buttons have been made two buttons as room 1 and Quit. It is designed to 
change color when hovered and clicked. Two torches have been added to be compatible with 
the game. Torches are provided free of charge as an asset

![mainmenu](https://user-images.githubusercontent.com/59119008/126047039-c77b7f64-4330-4c2f-8b77-fe389c28752e.png)

• Game Scene

While designing the game scene, the room where the game takes place is completely shaped 
using cubes. Ready Texture is used for the colors of the walls and floors. All of the objects in 
the room were collected from different assets and placed. (For example, bed object from asset1, 
table object from asset2, etc.) The sizing and design of the room (excluding the objects used) 
is entirely my own. The torches that emerged as a result of the successful conclusion of the 
game were taken as ready assets, but the lighting design was made with the particle effect to 
give light to the room.

• Game Over Scene

The ending scene is designed on a canvas in an animated way with writing “Game over. You 
Are Dead” and with a black-red theme.

![gameover](https://user-images.githubusercontent.com/59119008/126047066-caf182af-ee58-4a63-90a4-512be1daa0f2.png)

#### GamePlay

As the game starts, the 3 minutes given to the player starts. It is first given by the light hint 
given to the player. The user is trying to locate the light according to this clue. When found, it 
turns the light back on with the E key. When it releases, the player is given the 2nd light and a 
clue about it. Likewise, this time the player finds the location of the second light and places the 
light there. There are a total of 5 lights given to the player in this way.

Success: 

As a result of the player placing all the lights within 3 minutes, the torches are lit in the room 
and the game is completed successfully.

Fail: 

If the player does not place the lights within 3 minutes, zombies appear in the room in the last 
10 seconds and the Game Over scene is played when the second is over
