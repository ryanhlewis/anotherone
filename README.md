[![kNNmdD.png](https://dc626.4shared.com/img/gfFVQabOea/s24/176ab1b9018/Another_One?async&rand=0.10187313229242556)](https://dc626.4shared.com/img/gfFVQabOea/s24/176ab1b9018/Another_One?async&rand=0.10187313229242556)


For a better visual experience, go here: [Another One Website](https://ryanhlewis.github.io/anotherone)

Another One is a game I was working on before I had to pause for college applications.

It is designed to be a puzzle shooter, and I was planning to incorporate multiplayer as well. However, all I managed to get done before college applications put me on a hiatus was the first person aspect, as well as a very basic regeneration system, sine wave idle system, and some basic enemies.


However, the entire project is available here, and I will briefly describe the systems I set up-

## Regeneration System
Similar to how Destiny does their regeneration, I wanted health only to appear when a player was hurt, and fade away when they are not taking damage for a period of time. It would also regenerate after a specified amount of time from the damage, and if a player was hurt again while regenerating, it would stop again, and regenerate in due time.

This was all done using simple if and boolean statements, where it would check for damage done, and set a boolean to true, and then check for if the player was damaged again and stop regeneration to repeat the function. This code is present in AnotherOne/Assets/FPS/Scripts/PlayerCharacterController.cs at lines 176-330.

It looks like this in action:

<iframe width="560" height="315"
src="https://drive.google.com/file/d/1t_fhTazIT2PExwBG4WMd3pm9say6nFR_/view" 
frameborder="0" 
allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" 
allowfullscreen></iframe>

## Sine Wave Idle System
I wanted to avoid typical animations for this game, and instead have math determine things like leg positions, arms, and so on. The Unity animation system is just a little bit too buggy for me, especially when I was setting up the enemy characters. So, I thought that a sine wave would perfectly imitate how a person idles, and it does.

The code for this was pretty complex, unfortunately. I had to do multiple algorithms and multiply sin by time in order to make it progress in the function, and then add that amount to the value that the arms and weapon bob to horizontally and vertically. This code can be found in AnotherOne/Assets/FPS/Scripts/PlayerWeaponsManager.cs at lines 345-455.

It looks like this:

<img src="https://media3.giphy.com/media/P23glzARPG0aaS7YYD/giphy.gif" width="400" />
<img src="https://media3.giphy.com/media/OVnswtJDEJwcfEdCPN/giphy.gif" width="400" />

## Basic Enemies
I wished I had used math instead of Unity's animation system, because these little guys are buggy as all hell. They work, though. To make these scary mushroom zombies, all I needed was a random walk around script, and a detect and chase function provided to me by Unity's own FPS Sample. The programming for the attack was simple enough, but sometimes the animation does not play along with it, making this look weird. Anyhow, the code is available in AnotherOne/Assets/FPS/Scripts/EnemyController.cs and I made a lot of changes, so there's not really one line segment to point to.

However, I also added an array function that guarentees a random drop chance of an item as well. These items can be set up from Unity's GUI, and I thought the feature was pretty useful, as you could type in your RNG amount, and specify the prefab to instantiate, and if RNG was on your side- the enemy would drop that on their death. That code is found within the same file at 74, 509-520, and 430-442.

Here's it working:

<img src="https://media4.giphy.com/media/IukEsrlyJZ3bEHnDr1/giphy.gif" width="400" />

## CONTROLS

WASD to move around

MOUSE to aim

LEFT CLICK to shoot

RIGHT CLICK to Aim Down Sights

CTRL to crouch



(The game asset I used is provided free by Unity themselves, so here it is. Feel free to use it too! )

- FPS Microgame provided by Unity Technologies


Here is the link to the asset- 

https://learn.unity.com/project/fps-template


Unfortunately, I used another paid asset as well in the creation of this game in order to make the scenery (rocks, trees, some textures). So, I had to take it out in order to make this open source on Github. Don't worry, this does not affect gameplay nor any of my code, but does affect how the scene will look on your end.



