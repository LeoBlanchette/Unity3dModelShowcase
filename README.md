# Unity 3d Model Showcase

This is a simple and fast solution to displaying 3d models for various needs. Some common needs that I have:

- Turntables recorded for YouTube
- Screenshots for game mods. 
- Unity Asset Store. 
- Finding fulfillment in life. 

### Installation
It installs as a complete Unity project. Simply do...
```
git clone https://github.com/LeoBlanchette/Unity3dModelShowcase.git 
```
...in a directory of your choosing. Then use the Unity "Add project from disk" option to open it.

It installs with Cinemachine and Postprocessing V2 as dependencies. Unity version 2021.3. We use HDR maps to achieve a high-quality product shot render with minimal effort. (https://polyhaven.com/a/studio_small_09)

### Controls
1. Spacebar toggles the turntable rotation.
2. Tab switches cameras.

### Screenshotting and recording workflow...

1. Set up your model as a child to the Turntable. Turn off the orange cube (it is a general demo object). Adjust as needed. 
2. Push play in the Editor. See the initial action, and adjust camera angles accordingly (see directions on camera adjustments below). 
3. When satisfied, create a build of the scene, and play it as a typical Unity app. 
4. Record the turntable using video software such as OBS Studio (https://obsproject.com/). You may also pause the turntable using [Spacebar] and take a screenshot as needed. 

### Camera positioning. 

In the scene, see Showcase/Cameras.
The three virtual cameras under that are:

- CM vcam_1
- CM vcam_2
- CM vcam_3

Beneath that you can find the system of Follow/Lookat targets Cinemachine depends on. In the scene, they can be found at:

Showcase/Cameras/CameraTracking/Cam_<x>/.
  
Adjust the Follow and LookAt gameobjects. Do not adjust the Cam_<x> prefabs.

