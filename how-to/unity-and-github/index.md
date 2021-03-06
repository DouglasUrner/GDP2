---
---
# Setting Up A Unity Project On GitHub

## Somebody in the group

### Create a new Git repository for the project

* Launch GitHub Desktop.
* From the **File** menu, choose **New repository...**
  - Make sure you:
    - Tick the **Initialize the repository with a README** checkbox.
    - Add a .gitignore for Unity.
    - If you skip these steps you will not be able to clone the repository until some content has been added to it.
    
  <img src="images/GH-Desktop-new-repository.png" width="600px">

### Create a new Unity project and push it to GitHub.

* If necessary, launch Unity, then from the **File** menu choose **New Project...**
* In the new project dialog, set up a new project:
  - Give the project the same name that you used for the Git repository.
  - Select the same location that you chose for the Git repository in GitHub Desktop.
* Click the **Create Project** button.
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
      
### Invite collaborators

* Go to the GitHub web site.
* Click on the **Settings** tab.
* From the left-hand sidebar choose **Collaborators.**
* Invite them by their GitHub user name.
  
## Everybody in the group

### Accept your invitation to collaborate

1. Before you can contribute to the project, you need to accept your invitation to collaborate - so do that now. If you have a verified e-mail address associateed with your GitHub account you will have an e-mail invite and can accept by clicking on the link in your e-mail. If you don't, you can go to the URL:

   ```https://github.com/<GitHub User Name>/<Repository Name>/invitations```
   
   and accept the invitation there.
   
   Replace ```<GitHub User Name>``` with the GitHub name of the person who created the repository, and replace ```<Repository Name>``` with the name of the repository - in case that wasn't obvious...

### Clone and test the repository

1. Launch GitHub Desktop.
1. Search for and clone the project repository (the clone will become your working copy).
1. Launch Unity and open the project in the cloned repository.

### Create a branch for your work and practice working with branches

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
   
## Learning More

* [Git Immersion](http://gitimmersion.com) - "a guided tour that walks through the fundamentals of Git, inspired by the premise that to know a thing is to do it."
