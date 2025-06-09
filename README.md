# Limapp Template
This is a Unity Project template with the Liminal SDK installed.

## Requirements
- [Git setup correctly in your environment path](https://github.com/LiminalVR/LiminalSdk-UnityPackage/blob/develop/README.md#setup-git)

## TO DO
- Change the Company Name
- Change app name
- Change package name, com.company.myapp

## Examples
Go to Examples -> Scenes -> Example
- A way to interact with Unity UI using the pointer
- A way to interact with 3D objects using the pointer
- Ending Experience
- Fading the screen

## Project Settings
- Android ready
- Oculus VR Ready
- Graphics & Quality settings to Liminal's standards

## Notes
The first time you open the project may take up to 5 minutes, Unity will give you a window
> Unity Package Manager - Resolving packages... 

## Troubleshooting
- Unable to open Unity due to Package Manager Manifest issues
  - Chances are your git is not setup properly.

# Support For Internal Development
The project uses assets from the Stylised Forest asset pack found in Assets/Stylized Forest. Lighting and post-processing is also found in Stylized Forest/Demo/Demo_2. There is shader issues which cause graphical artifacts when using optimised shaders, so we recommend using the non optimised variants.
All work was done in the scene Snow, not Main, so any continue'd development should be in the Snow scene. We've imported the light weight render pipeline but we used the built-in render pipeline, so changing pipelines may not be a smooth transition. There will only be a few additional scripts pertaining to the snow particles and snow piling mechanisms.
The project was developed for Oculus and has not been for Steam VR.
