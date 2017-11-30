# Unity 2017 Mobile Game Development
This is the code repository for [Unity 2017 Mobile Game Development](https://www.packtpub.com/game-development/unity-2017-mobile-game-development?utm_source=github&utm_medium=repository&utm_campaign=9781787288713), published by [Packt](https://www.packtpub.com/?utm_source=github). It contains all the supporting project files necessary to work through the book from start to finish.
## About the Book
Unity has established itself as an overpowering force for developing mobile games. If you love mobile games and want to learn how to make them but have no idea where to begin, then this book is just what you need. This book takes a clear, step-by-step approach to building an endless runner game using Unity with plenty of examples on how to create a game that is uniquely your own.

Starting from scratch, you will build, set up, and deploy a simple game to a mobile device. You will learn to add touch gestures and design UI elements that can be used in both landscape and portrait mode at different resolutions. You will explore the best ways to monetize your game projects using Unity Ads and in-app purchases before you share your game information on social networks. Next, using Unity’s analytics tools you will be able to make your game better by gaining insights into how players like and use your game. Finally, you’ll learn how to publish your game on the iOS and Android App Stores for the world to see and play along.

## Instructions and Navigation
All of the code is organized into folders. Each folder starts with a number followed by the application name. For example, Chapter02.



The code will look like the following:
```
/// <summary>
/// Update is called once per frame
/// </summary>
void Update ()
{
   // Check if target is a valid object
   if (target != null)
   {
      // Set our position to an offset of our target
      transform.position = target.position + offset;

      // Change the rotation to face target
      transform.LookAt(target);
   }
}  
```

Throughout this book, we will work within the Unity 3D game engine, which you can download from http://unity3d.com/unity/download/. The projects were created using Unity 2017.2.0f3, but the project should work with minimal changes in future versions of the engine.

For the sake of simplicity, we will assume that you are working on a Windows-powered computer when developing for Android and a Macintosh computer when developing for iOS. Though Unity allows you to code in C#, Boo, or UnityScript, for this book we will be using C#.

## Related Products
* [Mastering Unity 2017 Game Development with C# - Second Edition](https://www.packtpub.com/web-development/mastering-unity-2017-game-development-c-second-edition?utm_source=github&utm_medium=repository&utm_campaign=9781788479837)

* [Unity 2017 Game Optimization - Second Edition](https://www.packtpub.com/game-development/unity-2017-game-optimization-second-edition?utm_source=github&utm_medium=repository&utm_campaign=9781788392365)

* [Mastering Unity 5.x](https://www.packtpub.com/game-development/mastering-unity-5x?utm_source=github&utm_medium=repository&utm_campaign=9781785880742)

### Suggestions and Feedback
[Click here](https://docs.google.com/forms/d/e/1FAIpQLSe5qwunkGf6PUvzPirPDtuy1Du5Rlzew23UBp2S-P3wB-GcwQ/viewform) if you have any feedback or suggestions.
