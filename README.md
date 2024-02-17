# Eternal Evasion

## Introduction

The objective was to create a game using Unity Engine. “Eternal Evasion” is the name I gave to my game. It is endless path traversing game. In other words a never ending dodging game which one play to their heart’s content. But only those with tranquil minds will persevere as certain twists will make the game impossible for those who do not show unrequited attention and focus. The slightest agitation and it is curtains for the player. The main goal is to avoid obstacles, and try to go further and further with each try. The game gets progressively more difficult as we go further. The goal is to get as high a score as possible. The game is made more challenging through glitch effects, low coefficients of friction and much more. Note that the glitch effects are done on purpose, they are not an actual glitch in the game. It is just to disorient the player and make the game more challenging. Other surprise elements in our game occur as we progress further into the course. The gaps keep getting smaller as we move onwards and the screen flips or rotates after certain intervals to make it more challenging for the player.

## Methodology

### Algorithms, Languages and Tools Employed

After first coming up with the concept of our game, we learned C# and the workings of Unity, then made the game scene. With the time we had left, to make the experience more enjoyable, we added surrounding scenes, music, final touches and branding. 

The programming language used in this project was C#. The softwares used were Unity Engine for the game development and Visual Studio for writing our C# scripts. For supporting material such as brand logo and intro clip, Adobe Photoshop and Adobe Premiere were used. 

## Concepts of OOP Used

C# is a general purpose object oriented language. Many core concepts of object oriented programming are integrated in C# as well as Unity Engine itself. Many concepts of object oriented programming have been applied to our project. Some of the more prominent ones have been listed below.

### 1. Inheritance
MonoBehaviour is the base class from which every Unity script derives. When you use C#, you must explicitly derive from MonoBehviour. To elaborate, MonoBehaviour is a parent or superclass of sorts which Unity itself provides. It preexists in every project on Unity that you create. The multiple C# scripts we write each contain a derived class. They derive or inherit from the base class MonoBehaviour. They inherit all precoded method functions. This saves time as we only have to write code specific to that derived class and all general purpose methods are inherited. 
In Unity all the objects that you will create in your scene whether there are empty or not, will be instances of the class GameObject. The class GameObject is therefore the parent (or base class) for any object added to the scene. Also note that the class GameObject provides static functions that can be used to deal with objects; for example, the method GameObject.Find can help to look for a particular object in your scene.

### 2. Encapsulation
Each script acts a derived class as it contains only one class derived from MonoBehaviour. In those classes, data members are bundled with method functions. Different levels of access have been granted to different data members and method functions, thereby restricting direct access to some of object’s components. Some components we want that they can be altered outside C# script i.e. inside Unity so we declare them as public. Otherwise, we restrict their access.  We cannot directly access every function through object.

### 3. Abstraction
Abstraction has been implemented by the use of different access specifiers for different data members. This way only essential information is displayed, and details and background implementation are hidden. Some data members have been declared as private as we do not want anyone to access or modify them, not even Unity. The ones we do want to be modified or displayed publicly in Unity or to user have been set to public. 

### 4. Classes and Objects
Each file contains a class with its own data members and member functions. The thing we connect the scripts to inside Unity is their instance or object. The object we create are from derived classes but the base class MonoBehaviour has objects of its own. One such object is the scene manager. It controls the arrangement of scenes in the game, the order in which they occur and much more.


## Code

Code has been split up into multiple files, 10 in total. There are multiple reasons for this. It is to make code more neat and ordered. If case of an error, we can more quickly trace it. C# scripts are attached to different objects in Unity, thereby making them instances of that script or derived class. Some code may not be as relevant for an object as it is for another. So it is more suitable to split up code into multiple files and then see which piece is relevant for which object, rather than creating one large file and attaching it to every object. Doing so could have side effects.

## Future Recommendations

This project can be improved in some ways in the future. Due to a limited time frame, we could not include some functionalities. Different additions can be made to the game.
Firstly more levels can be added to the game. Currently the game has one never ending level. It could be broken up into multiple levels with varying difficulty. 
Secondly to further supplement the game, checkpoints could be added to the game. Doing so would not restart player from start of level but somewhere in between. 
The variety of obstacles could be increased. New elements such as teleportation portals could be introduced.

## Conclusion

This project was a good learning experience for me. Not only did we learn a different programming language i.e. C#, we also learned the workings of a game engine and how exactly a game is made. We learned of the magnitude of effort that goes into producing a game of any scale. Game development is a vast and interesting field. This project served as a practical application of the concepts taught to us in OOP. If OOP was not used, then learning it would have been redundant. We also observed that C++ has some limitations and that if we were to build a game using it, all necessary methods would need to be developed from the ground up. C# is a language more geared towards game development and is supported by Unity Engine, hence less code would need to written there. But since both languages are similar and only their syntax differs, learning C# is not that difficult if you are already familiar with C++.  
