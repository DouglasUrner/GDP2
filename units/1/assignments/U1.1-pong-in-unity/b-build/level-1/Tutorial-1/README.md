# Pong in Unity - Tutorial 1: Building a prototype

![](https://media.wired.com/photos/59fccff22d3f5732c7d5aa15/master/w_582,c_limit/Pong-TA-B1C1YX.jpg)

This is the first of a four part series of tutorials for building your own version of the classic arcade game [Pong][] in [Unity][].

* Tutorial 1: build a prototype to test and tune the core mechanic of the game.
* [Tutorial 2][tutorial2]: turn the prototype into a playable game with scoring and a restart button.
* [Tutorial 3][tutorial3]:
* [Tutorial 4][tutorial4]:

The examples use the [JetBrains Rider IDE][rider] for editing Unity's [C#][] scripts, but you can use any editor that you prefer. The tutorials build on each other, so it makes sense for everyone to start at the beginning.

[pong]: https://en.wikipedia.org/wiki/Pong
[unity]: #
[rider]: #
[c#]: #

[tutorial2]: #
[tutorial3]: #
[tutorial4]: #

Inspriration comes from a number of Pong in Unity tutorials, including:

* [Noobtuts: Unity 2D Pong Game][noobtuts]
* [Awesome Inc U: Make A Pong Game With Unity 2D][awesome]
* Vincent Quarles: Building a Pong Clone in Unity:
  - [Part 1: Retro Revolution: Building a Pong Clone in Unity][quarles1]
  - [Part 2: Building a Pong Clone in Unity: UI and Gameplay][quarles2]

[noobtuts]: https://noobtuts.com/unity/2d-pong-game/
[awesome]: https://www.awesomeincu.com/tutorials/unity-pong/
[quarles1]: https://www.sitepoint.com/retro-revolution-building-a-pong-clone-in-unity/
[quarles2]: https://www.sitepoint.com/building-a-pong-clone-in-unity-ui-and-gameplay/

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

## 2: Learn Your Way Around The Unity UI (User Interface)

When Unity opens, the display will look something like this screen capture:
![Unity UI](assets/004.png)
The layout of the Unity UI is customizable, so don't worry if what you see looks different. Tutorials, especially video tutorials are easier to follow if your UI layout matches the tutorial, so the first thing we will do is explore the UI and learn how to adjust the layout.

### Major UI Elements

The Unity UI is divided into several panes, each of the panes is numbered to correspond with its description. Each of the panes serves a different purpose. Read the descriptions of each of the panes and find the panes on your computer.

![Unity UI](assets/004-annotated.png)

1. **[Hierarchy](https://docs.unity3d.com/Manual/Hierarchy.html)** - the Hierarchy pane displays a list of all of the game objects in your project. You can see the "family" (parent-child, sibling) relationships of game objects in the Hierarchy pane. When you add a game object by dragging it to the Hierarchy view, its transform is set to the origin. 
1. **[Scene](https://docs.unity3d.com/Manual/UsingTheSceneView.html)** - the Scene view pane provides a graphical display of the game objects in your project. When you add a game object by dragging it to the Scene view, its transform is set to the location where you dropped it. 
1. **[Inspector](https://docs.unity3d.com/Manual/UsingTheInspector.html)** - the Inspector pane displays the *components* and *properties* of the selected game object. You select a game object by clicking on it in the Hierarchy or Scene views. 
1. **[Project][]** & **[Console](https://docs.unity3d.com/Manual/Console.html)** - the Project pane is a view of files that make up your project. You can manage them directly in the Project pane. The Console pane shows messages from Unity: compiler errors, run-time messages from calls to **[Debug.Log()](https://docs.unity3d.com/ScriptReference/Debug.Log.html)**.
1. **[Game](https://docs.unity3d.com/Manual/GameView.html)** - the Game view pane is where you test your game.

[project]: https://docs.unity3d.com/Manual/ProjectView.html
   
### Controls

The Unity **[Toolbar](https://docs.unity3d.com/Manual/Toolbar.html)** provides access to some commonly used controlls, including:

* ![](assets/Editor-TransformTools-small.png) - Transform Tools to scale and move game objects in the Scene view.
* ![](assets/Editor-PlayButtons.png) - Play Buttons allow switching between Unity's Edit and Play (testing) modes.
* ![](assets/Editor-LayoutDropDown.png) - Layout Drop Down menu for [customizing your workspace][customizing].

[customizing]: https://docs.unity3d.com/2018.3/Documentation/Manual/CustomizingYourWorkspace.html

![Cropped view of the Unity toolbar](assets/006.png)

#### Configure Your Workspace

Before you go on, take some time read the section of the [Unity Manual]() on [Customizing Your Workspace][customizing] and set up your workspace to match the example above. This will make it easier to follow these tutorials. If you are planning to use a different tutorial, you may prefer to use its workspace layout as your model.

Once you have your workspace customized, save your layout.
   
### Menus

Unity's **menu bar** at the top of the Unity window gives you access to most Unity commands without needing to know their keyboard shortcuts. Some of the menus are probably familiar to you - but some, for example **Assets, Game Objects,** and **Components** are probably not. Take some time to check them out as you could use them to create all of the elements that you add to your game.

Because you use those functions so often, Unity has multiple ways to access them. In addition to the menu bar, you can also:

* **Right-click** in a pane to get a context menu.
* Use the **Create** drop-down menu in the Project and Hierarchy panes.
* Use the **Add Component** button in the Inspector.

That's enough for now. Let's start building the game.

## 3: Make A Plan

* Collect our assets
* Paddles
* The Ball
* Edges

## 4: Collect & Organize the Game Assets

Take a look at the [Project pane][project], it provides you with a "tidy" view of the files that define your project. It should look like the example below:

![](assets/4-ProjectPaneDetail-1C.png)

If it does not, but looks like this one instead, you missed the part about changing the Project pane to **1 Column Layout** - you want to do this, it makes it much easier to navigate.

![](assets/4-ProjectPaneDetail-2C.png)

Ok, let's go:

### Create a Sprites and a Scripts folder

Even on a small project it can help to have your assets well organized, for big projects it is essential. We know that we are going to be adding sprites and creating scripts. Let's make folders for them:

1. Click on the **Assets** folder to select it.
1. Right-click to bring up the Project pane context menu.
1. Select **Create** at the top of the menu, then left-click on **Folder** on the resulting fly-out menu.
1. Rename the new folder from **New Folder** to **Sprites.**

![](assets/4-CreateFolders-1.png)
![](assets/4-CreateFolders-2.png)
![](assets/4-CreateFolders-3.png)

That's one way to create a folder in the Project pane. There are two more ways. To create the Scripts folder we'll use the Project pane's **Create** drop-down:

1. Note that creating a folder leaves it selected.
1. Select the **Assets** folder again - we don't want to create our **Scripts** folder in the **Sprites** folder. Not that it hasn't been done…
1. Click on the **Create** drop-down menu just above the **Assets** folder in the Project pane.
1. Select **Folder**.
1. Rename the new folder from **New Folder** to **Scripts.**

![](assets/4-CreateFolders-4.png)

When you are done, the Project pane should look like this. The absence of *reveal triangles* to the left of the **Scripts** and **Sprites** folders tells you that they are currently empty.

![](assets/4-CreateFolders-5.png)

The third way to create a folder in Unity is from the **Assets** menu on the menubar. Useful if you forget the other methods, but otherwise I find it too cumbersome for regular use.

### Download Paddle and Ball images

Our sprites will start off as simple images in **P**ortable **N**etwork **G**raphics (PNG) format. We could also use JPEG images, but PNGs have the advantage of supporting transparency. Use PNGs. Most image editing software can save images in PNG format (and also export images from other formats to PNG).

The only sprites we *need* for Pong are a white circle and a white square. You could easily create them yourself in Photoshop or Piskel or any other image editor, or you can download them from here - since they are white, and the page background is white, they are not much to look at. Use these links to download the **Circle** and **Square** sprites:

* **[Circle][]**
* **[Square][]**

To download the linked images:

1. Right click on the link and choose **Download Linked File As…**.
1. Navigate to the Sprites folder in your Unity project.
1. If you want, change the file name.
1. Click **Save**

![](assets/4-DownloadSprites-1.png)
![](assets/4-DownloadSprites-2.png)

After downloading the Circle and Square images, your Unity Sprites folder should look like this:

![](assets/4-DownloadSprites-3.png)

### Check the sprite import settings

Notice that each of the sprites, Circle and Square, has a reveal triangle to the left of it. The images that you downloaded have become sprites. Before we move on, let's investigate them a bit:

1. Notice that each sprite has a small icon of itself.
1. Click on the reveal triangle to open the sprite folder.
1. Inside you will find the image file that you downloaded. If you had downloaded an animated sprite the animation frames would all be stored together in the folder.
1. In the **Inspector** pane the properties of the selected sprite are displayed along with a preview. There are a few things to notice/check:
   - **Texture Type** should be set to **Sprite (2D and UI)**, if it is not your project may have been created with a 3D template. Read the Unity manual section on [2D and 3D Settings][3Dto2D] to learn how to switch your project into 2D mode (or you could start over, it would be quick, and it would be good practice).
   - **Pixels Per Unit** should be **100**, this setting scales images to the game world. Decreasing it makes the sprite larger and vice versa.
   - **Filter Mode** should be changed from the default of **Bilinear** to **Point (no filter)** for the Square, it can be left at the default for the Circle. The bilinear setting may result in fuzzy edges which will look bad on the paddles or if we use the square to form edges or the center line.

![Inspector pane displaying sprite](assets/4-DownloadSprites-4.png)

[circle]: https://github.com/DouglasUrner/GDP2/raw/master/units/1/assignments/U1.1-pong-in-unity/b-build/level-1/Tutorial-1/assets/Circle.png
[square]: https://github.com/DouglasUrner/GDP2/raw/master/units/1/assignments/U1.1-pong-in-unity/b-build/level-1/Tutorial-1/assets/Square.png
[3Dto2D]: https://docs.unity3d.com/2018.3/Documentation/Manual/2DAnd3DModeSettings.html

## 5: Set Up The Paddles

### Place the first paddle and set its transform

### Make it a Paddle prefab

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
   
## 6: The PaddleController Script
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
   
## 7: The Ball
1. Drag Ball sprite to Hierarchy
   - Make it a prefab
   - Add tag (be sure it goes on the prefab)
   - Adjust scale (0.5, 0.5)
   - Create and add Physics 2D material
     - Drag to Physics 2D component
   - Add BallController script
   
## 8: The BallController Script

## 9: Edges
1. Create empty game object - Edges
   - Reset transform
   - Create an empty child, name it Top
   - Add a box collider
   - Adjust size of collider
   - Position collider with transform
   - Duplicate three times, Right, Bottom, Left (or N, E, S, W)
1. Test
