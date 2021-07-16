# MATPicker
This tool enables you to retrieve the Material (.mat), Texture Object (.tobj) and Texture files (.dds) used by Prism Model Descriptor (.pmd) objects and to export them to a chosen location.
PMD is a binary file format used by SCS Software to describe their 3D models. The file format is used in both Euro Truck Simulator 2 and American Truck Simulator.

#### Motivation
A smooth conversion of the SCS models to mid-format using [ConverterPIX](https://github.com/mwl4/ConverterPIX) requires all material and texture files to be in the folder that is subject to conversion.
When working with large mod archives, this is often not the case. We have gone through the process of manually picking the missing files way to many times and conclude that it is such a waste of time. 
Therefore, we decided to create a user friendly tool to automate this process and to make the conversion process to mid-format easier. 

#### Functionality
With the MATPicker tool, one can specify a specific PMD file or a folder that includes any number of them. The tool examines and picks the material, texture object and texture files that the PMD are depending on. 
Next to a mod folder, where the program will start its search, one can specify multiple base folders in which the program continues the search for these files.
After selecting which files to copy and specifying their destination folder, the program automatically builds a parallel folder structure in the export folder including all the picked files.  
The Log section gives a sorted overview of the picked files and informs the user about files that could not be located in neither the mod nor the given base folders.

The tool can pick the following files:
* MAT files; the Material files included in the selected PMDs.
* TOBJ files; the Texture Object files included in the Materials.
* DDS files; the Textures included in the TOBJs.
* PMD/PMG/PMC files; the selected PMDs, as well as their PMG and PMC siblings following the same naming scheme.

![image](https://user-images.githubusercontent.com/55321868/125977971-f04b2ec6-74c4-4af6-96ad-3ad5312430c2.png)

#### Usage

* There are multiple ways to select a Mod, PMD or Export folder. One can either click the dedicated "Open" button to select the file using the Windows File Explorer, 
drag and drop the folders to the corresponding textboxes or use these textboxes to manually enter the filepath.
* When choosing the "Single PMD" option for the PMD selection, the Windows File Explorer will only show PMD files to choose from.
* To select base folders, one can either drag and drop them to the corresponding textbox or open them individually using the "Open" button. 
* There is the possibility to "Export empty folders" in case the program could not find the files they ought to contain, so that users can easily paste in the missing files manually.
* The log is sorted both alphabetically and based on file format to give a better overview of missing and picked files.
* To see keep the log comprehensive, once can "Clear" it at any point and choose to "Display errors only".
* One can use tab to move between the different UI elements, the arrow keys to change the selection value of radio buttons as well as the checkbox list and space to check and uncheck textboxes.  


#### Installation/Compatibility
This program is written in C# using the .NET framework and aimed at Windows operating systems.
To use this program, simply download the executable file and save it on a location of your preference.

#### Contribute to this project
Feel free to open issues here on GitHub when you happen to find any bug, so that we can solve them as soon as possible!

#### Credits
This tool is created by Nico and Matthijs, both developer of the ProMods team.
