## 1: Setup
1. New project
1. Add assets
   - Download
   - Create folders
   - Move assets to folders
1. Adjust camera

## 2: Paddles
1. Create paddle prefab
1. Create paddles
1. Test
1. Edit Paddle prefab
   - Rigidbody2D so we can move it
     - Make Kinematic (lose gravity - and mass)
   - Box Collider
1. Test
1. Create Paddle script
   - Make sure it is in Paddle folder
   
## 3: Ball
1. Add ball
   - Make it a prefab
   - Add tab (be sure it goes on the prefab)
   - Adjust scale (0.5, 0.5)
   - Create and add Physics 2D material
     - Drag to Physics 2D component
   - Add BallController script

## 4: Walls
1. Create empty game object - Walls
   - Reset transform
   - Create an empty child, name it Top
   - Add a box collider
   - Adjust size of collider
   - Position collider with transform
   - Duplicate three times, Right, Bottom, Left (or N, E, S, W)
1. Test

## 5: Scoring
1. Create empty game object
   - Reset transform
   - Name it HUD
1. Game Manager Script
1. Skin
   - Select font
   - Set label size
   - Set button size
