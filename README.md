# Bodied 0.1
Networked full body VR avatars in Unity using Final IK and Normcore.

Currently does not track fingers.

This has not been extensivenly tested, recommended for testing and exploration only.

# Requirements
Unity >= 2020.3: https://unity.com/

Normcore >= 2.0: https://normcore.io/

Final IK >= 2.0: https://assetstore.unity.com/packages/tools/animation/final-ik-14290

Oculus Integration >= 25.0: https://developer.oculus.com/downloads/package/unity-integration/

# Use

Install the requirements

Import the Unity Package: https://drive.google.com/file/d/17IqL-CvScJwebg3Wut6JT1R2JtKhFwf3/view?usp=sharing

To make a networked VRIK avatar:
* Add a "Bodied Avatar" component to a Humanoid rigged model with an Animator component.
* Right click on the Bodied Avatar component, click on "Configure Full Body Tracked"
* Put the avatar in a networked player prefab (An example is provided)
* Have the networked player prefab call "RequestOWnershipForAllTransforms" on the avatar at Start.

# Examples

Install the requirements

Run the "Demo" scene in the Assets/BodiedExamples/Scenes folder.

Put a Normal App Key into the Realtime object.

Press play
