# GPU-GEMS-Atmospheric-Scatter

This is a port of the GPU GEMS article on atmospheric scattering to Unity. 

The port was fairly straight forward but there were a few gotcha's to watch out for. This project contains two scenes. One demonstrating atmospheric scatter when viewed from space and when viewed from within the atmosphere. The view from space was the easiest to do. As the calculations are done per vertex you will need to use a sphere that has a decent resolution. The sphere primitive game object in Unity will not be suitable.

The view from within the atmosphere was a little more tricky. At first I created a sphere and placed the player in the middle like a traditional sky dome set up. This did not work however. I then realized that the player must be placed in between two spheres with the lower one representing the ground and the upper one the atmosphere.

This represents a problem however. Two get a realistic looking ground plane the sphere must be quite large or else the curvature of the earth will be unrealistic. I used a sphere with a radius of ten thousand, meaning the far plane of the camera will  have to be a tad over ten thousand. Such a large far plane will cause problems with the depth buffer and is not really practical. It also means that the terrain will have to be curved. If the terrain is flat then where the terrain meets the atmosphere will not look correct.

This is not impossible but would be quite fiddly to set up. You could of course set the atmosphere up like a normal sky dome and the ground as a normal flat terrain. Then have the shader rendering into a cube map for the sky. It would take a bit of reworking the shader but that's the standard method for these sorts of things.

You can download a Unity package [here](https://app.box.com/s/n9f1fadhb2xlmzrpyyo0d660x0d8d062).

![Atmospheric scatter from space](https://static.wixstatic.com/media/1e04d5_ec89fa9257464c8ca6c27bb9417bbca9~mv2.jpg/v1/fill/w_585,h_585,al_c,q_80,usm_0.66_1.00_0.01/1e04d5_ec89fa9257464c8ca6c27bb9417bbca9~mv2.jpg)

![Atmospheric scatter from ground](https://static.wixstatic.com/media/1e04d5_8e7ad74748e647c2b561885e002f5b6f~mv2.jpg/v1/fill/w_585,h_271,al_c,q_80,usm_0.66_1.00_0.01/1e04d5_8e7ad74748e647c2b561885e002f5b6f~mv2.jpg)

![Atmospheric scatter sun set](https://static.wixstatic.com/media/1e04d5_515ef3e06e514df1bd45018a9a400b1c~mv2.jpg/v1/fill/w_585,h_267,al_c,q_80,usm_0.66_1.00_0.01/1e04d5_515ef3e06e514df1bd45018a9a400b1c~mv2.jpg)


