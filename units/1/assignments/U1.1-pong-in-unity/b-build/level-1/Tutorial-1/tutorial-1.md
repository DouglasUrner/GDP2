# Pong in Unity - Tutorial 1: Building a prototype

## 1: Create A New Project In Unity
1. Launch Unity, you will see the launch dialog:
![Unity launch dialog, showing Learn tab](assets/001.png)
1. Click on the **New** button. The new project dialog will open with defaults filled in. You will need to change them:
![Unity new project defaults](assets/002.png)
1. Name your project and select the 2D template. Double check that the project location is not on the **C:** drive. On Windows your settings should be similar to these:
   - Name: **Pong**
   - Location: **U:\Game Design 2\Games**
   - Template: **2D**

   If you are working on macOS or Linux, you settings should be similar to the ones in the screen capture. After double checking, click on the **Create project** button and Unity will initialize your project. This will take a while, as Unity works it will relaunch itself and it will display some progress bars.
![Unity new project settings](assets/003.png)

## 2: The Unity UI (User Interface)

When Unity opens, the display will look something like this screen capture:
![Unity UI](assets/004.png)
The layout of the Unity UI is customizable, so don't worry if what you see looks different. Tutorials, especially video tutorials are easier to follow if your UI layout matches the tutorial, so the first thing we will do is explore the UI and learn how to adjust the layout.

### Major UI Elements

The Unity UI is divided into several panes, each of the panes is numbered to correspond with its description. Each of the panes serves a different purpose. Read the descriptions of each of the panes and find the panes on your computer.

![Unity UI](assets/004-annotated.png)

1. **[Hierarchy](https://docs.unity3d.com/Manual/Hierarchy.html)** - the Hierarchy pane displays a list of all of the game objects in your project. You can see the "family" (parent-child, sibling) relationships of game objects in the Hierarchy pane. When you add a game object by dragging it to the Hierarchy view, its transform is set to the origin. 
1. **[Scene](https://docs.unity3d.com/Manual/UsingTheSceneView.html)** - the Scene view pane provides a graphical display of the game objects in your project. When you add a game object by dragging it to the Scene view, its transform is set to the location where you dropped it. 
1. **[Inspector](https://docs.unity3d.com/Manual/UsingTheInspector.html)** - the Inspector pane displays the *components* and *properties* of the selected game object. You select a game object by clicking on it in the Hierarchy or Scene views. 
1. **[Project](https://docs.unity3d.com/Manual/ProjectView.html)** & **[Console](https://docs.unity3d.com/Manual/Console.html)** - the Project pane is a view of files that make up your project. You can manage them directly in the Project pane. The Console pane shows messages from Unity: compiler errors, run-time messages from calls to **[Debug.Log()](https://docs.unity3d.com/ScriptReference/Debug.Log.html)**.
1. **[Game](https://docs.unity3d.com/Manual/GameView.html)** - the Game view pane is where you test your game.
   
### Controls

The Unity **[Toolbar](https://docs.unity3d.com/Manual/Toolbar.html)** provides access to some commonly used controlls, including:

* ![](assets/Editor-TransformTools.png) - Transform Tools to control how the Scene view works.
* ![](assets/Editor-PlayButtons.png) - Play Buttons 
* ![](assets/Editor-LayoutDropDown.png) - Layout Drop Down menu for managing the arrangement of the Unity UI elements.

![Cropped view of the Unity toolbar](assets/006.png)
   
### Menus

1. Menus

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