# WifiSpyCode
Scripts I created for the game demo Wifi Spy in Unity.  Meant to be attached to Unity Objects in the
context of a level.

Enemy A is the script for the standard enemy.  Has variable stats like health and speed, 
as well as a lane variable.  The enemy tracks the player, and if the player shoots when the 
enemy is in the same range, the enemy takes damage.  The enemy is also constantly moving twoard 
the central "core".  If the core takes too much damage, the player loses

Spawner0 is one of the individual spawner scripts that determine when and how enemies spawn.  
It also tracks how many enemies are in the current lane, so enemies in the back don't get 
destroyed when enemies in the front get hit.  Spawns different variations with different avatars, 
like a "fast enemy" which moves faster than the rest, and a "strong enemy"  Which has more health

PM_V2 determines player movement, and moves the avatar around the screen accordingly.

Enemies are moving towards the core, and the core controller tracks core health.  
If enemies touch the core too many times, the player loses.
