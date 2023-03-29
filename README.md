# Unity-Architecture-Samples
Samples for a gamedev project course on layered code architecture

Assets/Scenes contains two scenes.
 - SpaghettiExample, uses the components from Scripts/Spaghetti that rely on direct inspector dependencies
 - LayeredExample, utilizes layered architecture to decouple the Unity simulation from backing data and its control logic
 
 Scripts are organized into Visualization, Data and Logic directories depending on their responsibilities.
 ServiceLocator is in the Scripts directory root, and its respective ServiceContext is part of the Visualization.
 
 Scripts/Utils contains an additional script used to move the hurtbox for the sake of testing.
