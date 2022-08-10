Written By: Haley P. Currence - April 15th, 2022
Updated By: Haley P. Currence - April 15th, 2022

What is the StartUp Scene?
	The StartUp scene features the "Computer Select" menu. 
Using this menu, the user can quickly and easily connect with the current Hololens controller 
for their Hololens' application. Once a computer is selected, the scene will transition to the "Vectors" scene by default.

Features:
* Prefab: "MenuComputerSelect"
	This is the main interface for the StartUp scene. 
Depending on the button clicked, the corresponding controller's IPv4 address is passed into the project's memory. 
There are currently 3 options: "Miles' Computer", "Gabriella's Computer", and "Other Computer". 
The "Miles' Computer" button passes in the IPv4 address associated with Miles' computer as the Hololens controller address.
The "Gabriella's Computer" button passes in the IPv4 address associated with Gabriella's computer as the Hololens controller address.
The "Other Computer" button senses and pulls the IPv4 address of the connected Hololens controller.
* Script: "SaveData.cs"
	This script provides the action for the buttons on the "MenuComputerSelect" interface.
The "Miles' Computer" button passes in the IPv4 address associated with Miles' computer as the Hololens controller address.
The "Gabriella's Computer" button passes in the IPv4 address associated with Gabriella's computer as the Hololens controller address.
The "Other Computer" button pulls the IPv4 address of the connected Hololens controller from an XML file ("ControllerInfo.xml") 
generated before the project's deployment. 
* Script: "PullControllerIP.cs" or "PullControllerIP.exe"
	This script pulls the IPv4 address of the current Hololens controller before the project is built and deployed in 
Visual Studio 2019. It then saves the found IP address in an XML file to be stored on the Hololens during the project's deployment. 
* File: "ControllerInfo.xml"
	The file is generated after "PullControllerIP.exe" is run, and called on again in "SaveData.cs". It currently only contains 
the IP address of the current Hololens controller.

How to Build Your Project Using the StartUp Scene:
	In Unity:
1) In the Build menu, position the StartUp scene to be the first scene in the build. (Scene 0 in the build.)
2) If you are using the "Vectors" scene in your build, check to make sure the "SceneChange.cs" script is coded to transition to the 
proper scenes in your build. 
3) If you are not using the "Vectors" scene in your build, change the "SaveData.cs" script to transition to your desired scene.
4) Build the project in Unity.
	In VSCode 2019 or higher:
1) Open the Project Settings. ("Project" -> "Properties")
2) In the "Debugging" menu, enter the IP of the Hololens in the "Machine Name" field.
3) In the "Build Events" menu, find the "Pre-Build Event" sub-menu.
4) Find and copy the absolute address of the "PullControllerIP.exe" from its location in your Unity project. (You should find it under 
the "Scripts" folder.)
5) Paste the address of the "PullControllerIP.exe" application in the "Command Line" field in the "Pre-Build Event" menu.
5) Press "Ok". 
6) Your project is ready to deploy. Enjoy!