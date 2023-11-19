# Dino Massacre - VR Game using Unity

## VR Game where the user stands their ground and uses a gun to shoot down waves of dinosaurs to survive

I made this project during my last semester at Cal State LA (Jan 2023 - May 2023) for a course I took on VR Game Design. I used pre-existing assets
for the dinos, gun, and other decorations, as well as pre-existing sounds, but designed the game and coded the behaviors myself. I also made use of
Unity's tools to create the spawning behavior for dinosaurs and resources. I learned a lot about Unity throughout this course and had lots of fun 
making this game and seeing my classmates play it.

Below is a link to a video demo of me playing the game:

https://www.youtube.com/watch?v=oBZnK3yLLqY

## Test Footage

https://github.com/coder-monroy/dino-massacre/assets/97262622/1c68b05b-29a5-48c3-b20c-f6e42d7a3ec2

## Some Action Shots

https://github.com/coder-monroy/dino-massacre/assets/97262622/3ca8c09a-20db-41bb-8038-67baf6dfc380

https://github.com/coder-monroy/dino-massacre/assets/97262622/86702bb9-9c86-408f-9373-3edc4ab93fb3

## More about this project

Below is the project report I submitted as part of the final for the VR Game Design course:

My project is called Dino Massacre. It is a game in which the user stands in place in a prehistoric jungle and has to survive a wave of dinosaurs. The user has access to a gun and unlimited ammo, which they can use to shoot and kill dinosaurs that approach them. The most complex part of the game is the gun mechanics. Although the user has access to unlimited ammo, they still have to reload the gun. The user must grab a magazine, each with 8 bullets, and place it in the gun, then pull the slide (top part of the gun) to load the gun. When the user runs out of bullets, they have to remove the magazine, grab another, and repeat the reload process. I implemented the gun this way to make the player learn to manage their ammo efficiently and to make users feel anxiety. Some dinosaurs also take more shots to kill than others, and so the user must decide when to reload and may feel rushed when they notice dinosaurs approaching. The player has to last 3 minutes to win and has 200 health. These figures are displayed to the user. Health goes down when dinosaurs reach the player and attack them, and depending on the dinosaur some attacks may be stronger than others.  If the player’s health reaches 0, they lose the game.

Grabbing the gun and magazines is done with the bottom trigger, while navigating menus, pressing buttons, and shooting is done with the top trigger of the controllers. There is a tutorial screen which allows the users to practice reloading and shooting the gun. There is also an “easter egg” in the game which is not very hidden. Behind the player there’s a little radio with a toggle button. When pressed, a rap song plays, which may help the user focus when shooting. 
 
I faced many challenges while developing this game. Perhaps the biggest challenge was getting the gun to work. I followed a tutorial that showed how to code a realistic gun. However, the tutorial was outdated and the code that was shown no longer worked. It was frustrating to realize that the task was more complicated than I thought, but I decided to spend time researching documentation on my own and managed to create my own code to make it work. The next big challenge was the process of shooting and killing the dinosaurs. The gun tutorial did not cover bullets shooting targets, so I struggled to implement this. After further research, I realized mesh colliders, which I had been using to detect bullets colliding, did not work well with the nav mesh that the dinosaurs had. To solve this issue, I opted for using child objects (spheres, cubes, etc.) in each dinosaur as their colliders. Once I overcame these issues, the rest of the development process went smoothly. I found the dinosaur’s built in Wander scripts, which had their stats, behavior patterns, and animations coded, and modified it so that they would act how I wanted them to in my game. 
 
One thing I would improve is the hitboxes on the gun. When people tested my game, many struggled with the slide and the reload process. One thing I learned during development is that reading through documentation, looking at examples, and understanding it is essential.
