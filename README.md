# IMod
![Github Stars](https://img.shields.io/badge/build-1.0.0-blue)
![GitHub Repo stars](https://img.shields.io/github/stars/Moomerator46/IMod?style=flat&color=yellow)

IMod is a tool that is planned to have an ability that you can make mods for [my games](https://moomerator.itch.io/).

# How do you set up IMod?
To set up IMod, just run the exe, and it will create a folder named: "cfil".
That folder is where all of your files will go.

# How do you make a mod?
You will need to install [Visual Studio](https://visualstudio.microsoft.com/) before you start programming. Also be sure to download the .NET framework.

Create a new project. Choose the "Empty Project (.NET Framework)" template. Name it whatever you like.
Right click on the **Solution Explorer** on the right.

<img width="342" height="452" alt="image" src="https://github.com/user-attachments/assets/855d58af-e56c-41d5-809d-b2b42e177aff" />

Click Add.

<img width="349" height="617" alt="image" src="https://github.com/user-attachments/assets/2cfb7cc7-f9f7-4d1c-949d-a086f832fa0f" />

Click New Item.

<img width="344" height="398" alt="image" src="https://github.com/user-attachments/assets/b8e08405-b9d7-43f4-8c6b-5ff24ee8822d" />

Name it whatever you like, just keep the .cs at the end.

<img width="391" height="118" alt="image" src="https://github.com/user-attachments/assets/02ba6c85-e3b2-4cb0-91de-846d0ade4584" />

And then click "Add".

## Step 2: Making the Mod
Right click on References in the Solution Explorer.

<img width="123" height="21" alt="image" src="https://github.com/user-attachments/assets/b3eed01e-dc52-4b4a-8934-dcecdfe1c8a1" />

Click Add Reference.

<img width="316" height="190" alt="image" src="https://github.com/user-attachments/assets/84115ef5-7f67-4fb1-827a-d70a9fa46ffe" />

Click Browse. (On the bottom)

<img width="784" height="545" alt="image" src="https://github.com/user-attachments/assets/3ecb6171-3c8e-4917-8b48-aef4d30506c2" />

Find `IModPlugin.dll` in the IMod folder you downloaded. (First extract the zip file into a folder)

<img width="604" height="24" alt="image" src="https://github.com/user-attachments/assets/85b8596e-b8d1-4aaf-897f-4e3a0e60953e" />

Click OK.

<img width="787" height="543" alt="image" src="https://github.com/user-attachments/assets/6a57d861-0d42-41c1-9558-7974de0c0813" />

Head back into your code, and start it with this:

```cs
using System

public class YourModName : IModPlugin
{
  public void Run()
  {
    // Your code here
  }
}
```

## Step 3: Compiling your mod.
Be sure to go into both tabs, and to Ctrl+S to save them.

Right Click on Your project (underneath the solution) in the Solution Explorer.

Click on Properties.

Click the dropdown menu called Output type.

Change it from Console Application to Class Library.

Click on Build on the top.

Click Build Solution.

Now if you have any errors, the build will fail until you fix them.

If it was succesful, open File Explorer, and go to the path `C:/Users/your username/source/repos/your project name/your project name/bin/Debug`. You will find a file called `yourfilename.dll`.

# How do you load the file?
To load the file, put your dll file into the `cfil` folder.
Then you can run IMod.exe.
It should say it scanned a mod and it will give you a code. Enter the code, and then it will run!

<img width="979" height="477" alt="image" src="https://github.com/user-attachments/assets/58fc9974-9c36-4354-b1aa-5f6ed92dc0ba" />
