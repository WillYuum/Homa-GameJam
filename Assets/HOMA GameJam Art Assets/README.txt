--  This pack is meant to be used only for the Homa IP Hypercasual Game Jam  --


Pack includes:

--Character animations (mixamo ready)
Fire
Run
Idle
Die
Reloading AK
Reloading M4
Reloading 2 WaterGuns

--Weapon animations
AK Reload
M4 Reload
WaterGuns Reload

--Pre-made animators
AK Reloading
M4 Reloading
WaterGuns Reloading

--Materials
Palette variations of all characters and most items
Facial expressions (connected to Face_Base on character Head bone)

--Prefabs
Characters with attached props (all disabled)
Accessories (with pivot point to matching bone)
Weapons + Ammo for AK and M4 guns
Miscellaneous end level props

--FX - Particle effects and trails to accompany weapon firing

--Scripts
“JerseyBoneBreaker” - (Already attached) - To be used on the jersey prefab on characters. This allows the jersey to deform with the character

--UI - Buttons and icons organized by shape and type

--Demo Scene - showcasing characters with various props and animations

----------------------

Each weapon has its own reload animation and avatar.
All the characters use the avatar of “_BASE-T-Pose_”

All character prefabs have attached to its respective bones:
Weapons              -Right hand
Gloves               -Right and left hands
Cap                  -Head
Glasses              -Head
Face mesh            -Head
Headphones           -Head
Beanie               -Head
Gloves               -Head
Jersey               -Root of character prefab


--Jersey

As the name suggests, the jersey is a simple duo color jersey that has been attached to each character prefab root (disabled by default).
Within that prefab there is an object “_Base” and an already attached script “JerseyBoneBreaker”. This allows the jersey mesh to deform and follow along the spine bones of the character it is attached to.

Everything has already been configured, but if need be:
-The script requires the “Target” Game Object to be the character's "_Base" object.


--URP workflow

In case of working in URP, make sure to update materials.
Face materials surface type should be "Transparent".