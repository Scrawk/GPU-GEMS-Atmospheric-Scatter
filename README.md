# GPU-GEMS-Atmospheric-Scatter

This is a port of the GPU GEMS article on atmospheric scattering to Unity. 

The port was fairly straight forward but there were a few gotcha's to watch out for. This project contains two scenes. One demonstrating atmospheric scatter when viewed from space and when viewed from within the atmosphere. The view from space was the easiest to do. As the calculations are done per vertex you will need to use a sphere that has a decent resolution. The sphere primitive game object in Unity will not be suitable.

The view from within the atmosphere was a little more tricky. At first I created a sphere and placed the player in the middle like a traditional sky dome set up. This did not work however. I then realized that the player must be placed in between two spheres with the lower one representing the ground and the upper one the atmosphere.

This represents a problem however. Two get a realistic looking ground plane the sphere must be quite large or else the curvature of the earth will be unrealistic. I used a sphere with a radius of ten thousand, meaning the far plane of the camera will  have to be a tad over ten thousand. Such a large far plane will cause problems with the depth buffer and is not really practical. It also means that the terrain will have to be curved. If the terrain is flat then where the terrain meets the atmosphere will not look correct.

This is not impossible but would be quite fiddly to set up. You could of course set the atmosphere up like a normal sky dome and the ground as a normal flat terrain. Then have the shader rendering into a cube map for the sky. It would take a bit of reworking the shader but that's the standard method for these sorts of things.


![Atmospheric scatter from space](./Media/AtmoScatter1.jpg)

![Atmospheric scatter from ground](./Media/AtmoScatter2.jpg)

![Atmospheric scatter sun set](./Media/AtmoScatter3.jpg)

List of atmoshere projects

[Brunetons-Improved-Atmospheric-Scattering](https://github.com/Scrawk/Brunetons-Improved-Atmospheric-Scattering)\
[Brunetons-Atmospheric-Scatter](https://github.com/Scrawk/Brunetons-Atmospheric-Scatter)\
[GPU-GEMS-Atmospheric-Scatter](https://github.com/Scrawk/GPU-GEMS-Atmospheric-Scatter)\
[Proland-To-Unity](https://github.com/Scrawk/Proland-To-Unity)


