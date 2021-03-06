# Sonic Generations Configuration Tool (Rewrite)
[![AppVeyor](https://ci.appveyor.com/api/projects/status/rexeqgearff4a119?svg=true)](https://ci.appveyor.com/project/PTKickass/generationsconfigtool-rewrite)

Rewriting Sonic Generations' Configuration Tool using WPF as a way to teach myself how to use it.

## Current features:

- Supports Graphics, Audio and Analytics configuration, all in the same tab
- Supports fixing the registry to avoid the `Game files either missing or corrupt please reinstall` issue
- Supports proper scaling
- Includes settings descriptions and images to better visualize the impact of each one
- Proper Nvidia Optimus support, so the config tool will always detect your high performance Nvidia GPU
- Supports changing the in-game language (requires admin rights because this is stored in LOCAL_MACHINE for some reason)
- Supports Dark Theme
- Significantly smaller file size compared to the original configuration tool (~5MB vs ~28MB)

## Current drawbacks:
- No Dinput devices support, but since Sonic Generations doesn't properly support Dinput devices to begin with, it shouldn't matter that much
- No proper 32-bit support if you have GCL (Generations Code Loader, included with HedgeModManager) installed

## Images
Light Theme            |  Dark Theme
:-------------------------:|:-------------------------:
![](https://raw.githubusercontent.com/PTKickass/GenerationsConfigTool_Rewrite/main/Images/Config.png)  |  ![](https://raw.githubusercontent.com/PTKickass/GenerationsConfigTool_Rewrite/main/Images/Config_Dark.png)
![](https://raw.githubusercontent.com/PTKickass/GenerationsConfigTool_Rewrite/main/Images/Input.png)  |  ![](https://raw.githubusercontent.com/PTKickass/GenerationsConfigTool_Rewrite/main/Images/Input_Dark.png)

## Credits
- [PTKickass](https://github.com/PTKickass) - Code and UI
- [M&M](https://github.com/ActualMandM) - Font images
- [Hyper](https://github.com/HyperBE32) - Settings descriptions
- Devil's Details - Original Configuration Tool
