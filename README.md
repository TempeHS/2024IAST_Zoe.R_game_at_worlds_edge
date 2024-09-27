# At World's Edge
[insert logo here (and maybe background or something idk)]
# User Documentation
## Controls
![](readme_images/readme_conrols_1.png)

Left and right arrow keys - moves the player left and right respectively

Space bar - allows the player to jump

The game has no mouse controls other than clicking on buttons to activate them

![](readme_images/ezgif-7-9cb5ebf1fc.gif)

## Objectives and Walkthrough
In a world powered by an unstable machine, the fabric of reality is slowly being destroyed by the very thing that gives it life. The tears caused by the machine have led to 'glitches' in the world's environment, which range from inconvenient to outright dangerous for it's residents. 

You play as Pilot, a rouge android who's mission is to restore an older machine, which runs much more sustainably. However, their quest is easier said than done, as the parts of the machine have been scattered throughout the world, and it will take them a journey of traversing the world and getting to know the people threatened by it's destruction, all while confronting their past, in order to save it. 

As the player, your objective is to traverse through various environments, ranging from grassy plains to abandoned factories to bustling towns, exploring the environment using mechanics such as climbing in order to maneuver in the corrupted environment, and interacting with various NPCs in order to find and collect the different parts of this old machine.

![](readme_images/ezgif-7-e4bd7f297d.gif)

# Developer Documentation
## Multimedia
As a part of my assignment for both multimedia and IST, I created both the sprites and the assets for this game. Not all of the assets I created made it into the final game due to time issues, so the remaining assets (such as dialogue sprites, the sprites for an addtional character and the full songs used in the game) can be found [here](https://drive.google.com/drive/folders/1HdMhIlvTp0ZFqxSIFVgHfe8dJTwGUf1K?usp=sharing)

## Features
For quite a few of the features coded into my game I used [these tutorials](https://www.youtube.com/playlist?list=PLgOEwFbvGm5o8hayFB6skAfa8Z-mw4dPV), either for the complete code (this was usually when it came to the basic movement code, as I was still getting used to using C# and Unity at the time, and the tutorials were very beginner friendly), or for the basic code for the feature, which I then modified to better fit what I wanted for the game. 
### Movement and Jumping
For the movement and jumping code, I followed the tutorials listed above, since these were the first features I added to the game. I had little to no trouble when it came to errors in the code, as most of them were due to typos I made while coding. 
### Wall jumping
Wall jumping was a little harder for me to code, as I was continously encountering issues unrelated to the code, meaning I couldn't look through the tutorial to try to fix them. Almost all of these issues were related to the hitboxes and colliders of various game objects, which made the bugs much harder to find, as this wasn't something I initially thought to check. 
### Hazards and Health
![](readme_images/uh.png)

For the hazards and health, I decided to modify the code and features in the tutorial, as what I wanted for the health system in my game was slightly different to what the tutorial presented. These modifications were mainly minor things, such as changing the amount of maximun health that the player had from 3 to 5, which I changed for two reasons. The first reason being that I wanted to make the game more accessible to players who might not be as experienced with platformers, since I myself am not the greatest at them, and the second being that I intended for my levels to be a lot longer than those shown in the tutorial, with a lot more environmental hazards that the player must avoid (as this is related to the main plot of the game). 

I also changed the type of hazard added in as a base, in order to better fit the aesthetic and worldbuilding of my game. 
### Parallax Background
The parallax background effect is arguably one of my favourite features which I added to the game. Not only does it make the gameplay experience much more immersive by adding a more realistic effect to the background, but it was also the biggest feature which I figured out a simple solution to without using a tutorial, and was surprisingly simple to do. 

I initially had a tutorial saved for my parallax background effect, however that tutorial was very short and didn't really involve any actual coding, as the code was copied and pasted from somewhere else. I did try it, however the backgrounds were extremely laggy when I tried playing using that code (and I knew this was the code, as nothing else in Unity was lagging on my laptop). After that, I didn't feel like following another tutorial, as I knew the logic which was required to code the parallax, and just needed to figure out how to code it in. 

After some thinking I realised that the logic I wanted to use for the parallax background was very similar to the code used for the camera movement, as they were both taking an object and making it follow the player. I tried adding the camera movement script to the individual background layers, and it worked quite well as a base, as the background was now following the player rather than remaining in one position. However, I knew I wanted to modify it into an actual parallax code, as it still looked quite unnatural. 

The first idea I had for making it into a proper parallax was to find a camera movement code which allowed the camera to look further ahead when the player moved left and right. This way, the background would move at a different speed to the player when they were moving. Thinking back on it, this very likely wouldn't have produced the effect I wanted for the background, however I didn't end up getting to the point of actually coding this in anyway as many of the examples I was looking at were much more complex than my base camera movement code. 

While skimming through a few tutorials, I found a devlog which mentioned that parallax backgrounds are simply the different elements of the background moving at different speeds, which gave me a new idea for how to create the parallax background. After browsing a few more forum posts and a few more compilation errors, I had the idea to simply subsitute the code for the player's speed into the section controlling camera movement, which ended up working extremely well once I figured out how to properly set the speed of different objects (which was to set the background's speed to 1, and lower the speed slightly the closer to the foreground the objects were). 

![](readme_images/yeagh.png)

### Menus and levels
As this was another skill I did not know how to do initially, I used [this tutorial](https://www.youtube.com/watch?v=E25JWfeCFPA) to learn how to switch between scenes and [this tutorial](https://www.youtube.com/watch?v=DX7HyN7oJjE) to learn how to use buttons in unity, as well as certain UI functions and how to quit the game. I only used these for the main menu and level transitions, as everything else I had learned how to do by that point. 

Initially for the ending screen, which sent the player back to the first level, my code was much more complex than it needed to be. The code utilised a different public void in the scene controller script, then utilised an if statement so that if the level's build index was equal to that of the ending screen, the player would be sent back to the start. I coded this in before I added the buttons (which had a line of code that sent the player to a specific level), so I ended up deleting it as what I added in the final game was a lot more efficient. 



## Bug Fixing
![](readme_images/goofy.png)

### Collider and Hitbox Issues (Wall Jumping)
As I mentioned in the features section of the developer documentation, the feature which I had the most trouble with while adding (and was considering scrapping altogether). A large majority of these bugs were due to collider issues, which were easy enough to fix once I found them, however they were quite hard to actually find in the first place, as I was basically still a complete beginner when coding this, and the colliders were the last thing that I thought to check. 

The first major issue I had with wall jumping was laughably easy to fix once I actually found the source of the issue. The tutorial which I was following had a part where it tested whether or not the player was on the wall in order to make sure the initial code was working before proceeding to adding the acutal walls. The idea was that the console would print 'true' if the player was touching the wall, and 'false' if they weren't. It was pretty simple, however my game kept returning true even when I wasn't near the wall. 

The root of the problem turned out to be that I had duplicated the tilemap of the floor when creating the wall, as I wanted to make sure I didn't miss adding any important properties (as the only real difference between the floor and wall was that one of them was classified as a well and one wasnt). However in doing this, I completely forgot to remove the tiles which belonging to the initial floor tilemap, causing the floor to be a part of the wall. This was probably the worst bug out of all of my code, as it was an extremely simple fix, yet it took several weeks to fix, since I didn't even think to check that part. 

After this, there was only one other big issue I had with the colliders, where the collider I was using for the wall was causing the player to get stuck to the wall, however changing the collider and messing around with the settings seemed to fix this. 

### Collider and Hitbox Issues (Health and Damage)
When it came to the health and damage I only had one small issue with the hitboxes, very similar to the problem I was having with the wall jumping. Due to making the hazards one large tilemap with a box collider, the player would only take damage at certain points when entering and exiting the collider. This issue was a relatively easy fix, I just adjusted the collider for the test run (and in the final game, applied a tilemap collider instead). 

### Wall and Floor Issues
When I was actually setting up the final obstacles for the platformer, I ran into an issue that I realised I hadn't adressed. The issue in question being that the player was unable to climb up a wall and then jump on top of it, as the block would either have to be a wall (meaning the player couldn't walk on it) or a floor (meaning the player couldn't climb on it). Though the issue could likely have been fixed through code, I fixed this issue by creating a new ground object and placing it behind and slightly above the walls, so that the player could walk on top of them without issue. 

## The Future of the Game
Though I have a basic playable version of this game, there are still a lot of features I want to add. Some of these include
### Features to Add (gameplay-wise)
Gameplay-wise, some of the features I plan on adding include: 
- The ability for the player to double jump
- Actual settings for the options menu
- An actual dialogue system
- Checkpoints
- Cutscenes
- Multiple levels
- Collectibles (other than the health ones)
- NPCs and quests
- Particle effects
- Dynamic lighting for certain levels
- Different types of hazards
- Additional levels
- The ability for the player to fly in the final level

### Features to add (experience-wise)
Experience-wise some of the features I plan on adding include: 
- A proper main storyline for the game
- A different tileset for different levels
- A full soundtrack for the game, including level-specific tracks to help with the atmosphere of the game
- Easter eggs and references to other games
- A larger map for levels, as well as secrets to be discovered, to encourage the player to explore the area
- Sound effects

In future, I hope I can take the skills I learned when creating this game, and utilise them to help with further developing both this game and other games I create in future. 

![](readme_images/end-notext.png)
