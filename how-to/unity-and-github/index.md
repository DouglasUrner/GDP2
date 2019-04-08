---
---
# Setting Up A Unity Project On GitHub

## Somebody in the group

* Create a new repository on GitHub for the project.
  - Make sure you:
    - Tick the **Initialize the repository with a README** checkbox.
    - Add a .gitignore for Unity.
    - If you skip these steps you will not be able to clone the repository until some content has been added to it.
  - If you will have collaborators, send them invitations.
* Start a new Unity project and push it to GitHub.
  - Once Unity is done (open), close it (Unity does not like you moving a project while it is open).
  - Using GitHub Desktop, clone the project repository to your computer.
  - Move the folders from the Unity project into the cloned repository.
    - Use the **Show in Explorer** button in GitHub Desktop to go to the folder you just cloned.
    - Type **Control-N** to open a new Explorer window, then go to the folder holding the Unity project that you just created.
    - Drag the folders to your cloned repository. Make sure you are getting all five of the folders that Unity uses to build and store your project.
      <img src="images/Unity-project-folders-in-Explorer.png" width="600px">
  - In GitHub Desktop, add a summary and commit the changes. Double check that the number of changed files is relatively small - 20 to 30 is about right, 100s or 1000s is definitely wrong. If the nubmer is too high you forgot to add a **.gitignore** file, do that now before committing your changes.
    <img src="images/GitHub-Desktop-with-Unity-folders-added.png" width="600px">
  - Push the changes back to GitHub.
  
## Everybody in the group

1. Accept your invitation to collaborate - if you have a verified e-mail address associateed with your GitHub account your can accept by clicking on the link in your e-mail. If you don't, you can go to the URL: **https://github.com/<GitHub User Name>/<Repository Name>/invitations** and accept the invitation there.
1. Launch GitHub Desktop.
1. Search for and clone your project repository (the clone will be your working copy).
1. Create a branch for your work.
   - The **Current branch** is displayed just below the menu bar at the top of the GitHub Desktop window. Unless you have changed it the current branch should be **master**.
     <img src="images/GH-Desktop-menu-bar.png" width="600px">
1. Commit something useful to the branch and push it. Ideas:
   - A list of sprites (or create the Sprites folder and add some placeholders - or even final sprites).
   - Update the work breakdown.
   - Notes on your tasks.
   - Make a note about naming conventions and rename the SampleScene.
1. Fetch the origin (check for changes contributed by your collaborators).
   - Pull if necessary.
