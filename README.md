# Unit-Testing-and-Mocking-In-Unity

> [!IMPORTANT]  
> - We'll be using Unity version `2022.2.6f1`, the same version used in the subject: `Introduction To Game Development.`
> - We'll be sticking to best practices within Unity, including properly setting up our assemblies, folders and installing necessary packages
> - I will be using JetBrains Rider as my IDE, but the coding and steps will be the same regardless of your preferred IDE

> [!TIP]
> - Downloading and important the required packages **may take time**, so It's **recommended** you skip to and complete the [Unity Project Setup](#unity-project-setup) section PRIOR to coming to the workshop.

## Content
1. [Introduction](#introduction)
2. [What is unit testing and Why we use it](#what-is-unit-testing-and-why-we-use-it)
3. [Unit testing in Software: apps, web and games](#unit-testing-in-software)
4. [Unity Project Setup](#unity-project-setup)
5. [Writing your first unit test](#writing-your-first-unit-test)
6. [Runtime unit testing](#runtime-unit-testing)
7. [Writing a 'Good' unit test](#writing-a-good-unit-test)
8. [Bonus Mocking and Interfaces](#bonus-mocking-and-interfaces)
9. [Wrap up](#wrap-up)

---

## Introduction

## What is unit testing and why we use it

## Unit testing in Software

## Unity Project Setup
### Basics
1. Create a new blank Unity project using version `2022.2.6f1`. The name of the project does not matter, but take note of where the project is created, we will be modifying some files in the Unity Project's packages folder manually later.
2. Once the project is loaded, create 3 new folders in the Assets folder: `Editor`, `Runtime`, `Tests`
3. Inside `Assets/Tests`, create 2 more folders, named `Editor` and `Runtime`
4. Your folder hierarchy should be as follows:
```
Assets
- Editor
- Runtime
- Tests
    - Editor
    - Runtime
```
5. We won't be writing any editor scripts in this workshop, but we'll add the folder anyway for good practice
6. Go to `Window > Package Manager`. We will be downloading and importing some Unity packages required for testing

### Packages and Dependencies
7. Install the following packages:
> [!TIP]
> - If you can't find any of the following packages from the list, click the `+` icon in the top left of the Package Manager window, and select add package by name, then, input the Package name shown in the table below

| Display Name | Version | Package Name |
|-|-|-|
| Input System | 1.5.1^ | com.unity.inputsystem |
| Test Framework | 1.1.33^ | com.unity.test-framework |
| Custom NUnit | 1.0.6^ | com.unity.ext.nunit |
| Moq | 1.0.0^ | nuget.moq |
| Castle Core | 1.0.1^ | nuget.castle-core |

### Assembly Definitions
> [!NOTE]
> - Setting up assemblies is important, so that our testing assembly is separate from our runtime assembly - so that our exported finished game doesn't include our tests! Also because, good practice!
> - We'll now setup our Assembly Definitions, assembly definitions should be named in the format: `com.<your name>.<your game name>`. For this workshop, I'll be using `com.eren.workshop`, feel free to use the same for simplicity
8. Go to `Assets/Runtime` in the project window. Then, `Right Click` and select `Create > Assembly Definition`.
Name it, `com.eren.workshop.runtime`
9. Create an Assembly definition inside `Assets/Editor`. Name it, `com.eren.workshop.editor`
10. Create an Assembly definition inside `Assets/Tests/Runtime`. Name it, `com.eren.workshop.tests.runtime`
11. Create an Assembly definition inside `Assets/Tests/Editor`. Name it, `com.eren.workshop.tests.editor`

<insert screenshots here of settings for each asmdef>

### Modify `Packages/manifest.json` 
> [!NOTE]
> - Because we want to create runtime tests, we need to make sure we can access our Input System from our tests. This is so we can simulate user input like Keyboard, Mouse or Gamepad from our tests to ensure our characters or UI behave properly

12. Navigate to your Unity Project's root folder, either via Windows Explorer or otherwise. You can also right click in your project window and select `Show in explorer`.
13. From the root folder, go to `/Packages`
14. Right click on `manifest.json` and select `Open with Notepad` (or your code editor of choice)
15. You should see the following contents (or similar)
```
{
  "dependencies": {
    "com.unity.ai.navigation": "1.1.1",
    "com.unity.feature.2d": "1.0.0",
    ...
  }
}
```
16. Append, the following chunk to your json so that it looks like this:
17. SAVE the file, close it, and return to Unity
```
{
  "dependencies": {
    "com.unity.ai.navigation": "1.1.1",
    "com.unity.feature.2d": "1.0.0",
    ...
  },
  "testables": [
    "com.unity.inputsystem"
  ]
}
```
> [!WARNING]
> 1. Make sure you have used the quotation marks "" in the correct places
> 2. Make sure you have used SQUARE BRACKETS
> 3. Make sure you have spelt the package name correctly
> 4. make sure you include the COMMA , after the closing curly brace of dependencies
> - When you go back into Unity, Unity will rebuild your packages. Should anything go wrong, go back to step 16. and ensure you have done everything correctly

## Writing your first unit test

## Runtime unit testing

## Writing a 'Good' unit test

## Bonus Mocking and Interfaces

## Wrap up
