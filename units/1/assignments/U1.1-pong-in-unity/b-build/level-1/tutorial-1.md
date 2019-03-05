## 1: Creating A New Project In Unity
1. New project
   - Name
   - Location
   - Template

## 2: The Unity UI

## 3: Game Assets
1. Create folders:
   - Sprites
   - Scripts
1. Download Paddle and Ball images
   - Save to Sprites folder

## 4: The Camera
1. Test
1. Adjust camera
1. Test

## 5: Paddles
1. Create a paddle by dragging the Paddle sprite into the Scene view - notice that the transform gets set to the location where you drop the sprite.
1. Use the cog menu to reset the paddle sprite to the origin.
1. Delete the paddle.
1. Create another paddle by dragging the Paddle sprite to the Hierarchy view - notice that the transform is set to the origin.
1. Using the scrubbers in the transform *component* place the paddle on the left hand side of the game.
1. Create a Paddle *prefab*:
   - Create a Prefabs folder in the Project pane.
   - Drag the paddle from the hierarchy to the Prefabs folder.
   - Notice how the icon changes.
   - Delete the paddle game object from the Hierarchy pane. Note: prefabs are often created dynamically in scripts, so it is common to delete the game object after creating the prefab - but you don't have to. This is an occasion where it would be reasonable to leave the game object in the game, we are deleting it so that we can see how the behavior differs when we create a game object from a prefab.
1. Create two paddles by dragging in the Paddle prefab twice.
   - The first time, drag it into the Hierarchy pane. What do you expect to see as the position value in the transform?
   - The second time, drag it into the Scene pane. What do you see as the transform?
   - Name each paddle.
   - Set the postion of each paddle.
1. Edit Paddle prefab
   - Rigidbody2D - so we can move it
   - Box Collider - so the ball will bounce off it
1. Test
1. Adjust Rigidbody2D settings
   - Set gravity to 0
   
## 6: The Paddle Script
There are a number of ways to create a script.

Rules for naming scripts:
* Capitalize the file name.
* No spaces.
* Check that the file name **exactly** matches the class name.

1. Create Paddle script
   - Make sure it is in Script folder - or move it there.
1. Attach the script to the Paddle prefab.
1. Test.

### Moving the paddles
   
## 7: Ball
1. Drag Ball sprite to Hierarchy
   - Make it a prefab
   - Add tag (be sure it goes on the prefab)
   - Adjust scale (0.5, 0.5)
   - Create and add Physics 2D material
     - Drag to Physics 2D component
   - Add BallController script

## 8: Edges
1. Create empty game object - Edges
   - Reset transform
   - Create an empty child, name it Top
   - Add a box collider
   - Adjust size of collider
   - Position collider with transform
   - Duplicate three times, Right, Bottom, Left (or N, E, S, W)
1. Test
