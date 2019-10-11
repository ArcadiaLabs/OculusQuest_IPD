/*
NOTE #1: Be sure to assign an object on which the skysphere should stay centered 
        (via the "Other Game Object" property of the "Keep Position In Sync With Other Object" component).

NOTE #2: Be sure to scale the skysphere to be large enough to feel distant.

NOTE #3: Be sure that the far planes of your camera(s) are at least a little bit larger (~10%) larger than the skysphere's size.

NOTE #4: The skysphere is best sitting by itself and not a child of any other object that might change position/rotation/scale.

NOTE #5: If LateUpdate isn't good enough to keep the skysphere centered on your view, you can simply go into "Project Settings" -> "Script Execution Order" and 
         add the "Keep Position In Sync With Other Object" script so that it is the last script that executes in each frame's LateUpdate().

NOTE #6: The included background texture is meant to be replaced with something that looks better. :)   
         For best results, replace with a very high resolution texture that is twice as wide as it is tall.
         
NOTE #7: This is only meant to be a basic skysphere.  For better looking results you may want to look into one that supports cubemaps (6-sided skybox).
*/