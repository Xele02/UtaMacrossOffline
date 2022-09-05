Rewrite project of UtaMacross mobile game. 

**Current version : 0.1.2**

Fonctionality : 
* Basic loading of the game with default profile
* Main menu : Only Music button works.
* Music menu : Scroll to select music and select number of diva.
* Diva select menu : Selection of diva & costume.
* Rhythm Game : No gameplay, some song can crash or load, or bug can happen. Movie video used in some song not implemented. Some shader not implemented yet.

# Requirement

* Unity version 2018.4.23f1 or 2018.4.24f1
* The game data dump with android and db directories. Game can load from encrypted or decrypted bundle, with name format like bundle.xab, bundle.xab.decrypted, bundle!sxxxxxxz!.xab, bundle!sxxxxxxz!.xab.decrypted.
* **For linux user** : Install vlc to have libvlc 3.0 avaiable :
  * Ubuntu : ```apt-get install vlc```
  * To check it'sok : ```/sbin/ldconfig -p | grep vlc``` should show libvlc and libvlccore.

# Installation

* Clone the project or extract the release zip (If you extract the zip on a older installation, remove the Unity directory before doing so).
* Launch Unity Editor 2018.4.23f1 or 2018.4.24f1 (Accept the upgrade asset popup), load the project in Unity folder.
* To tell the Editor where is the asset bundle dump, either do :
  * Copy android and db directory from the game dump into Tools/Data/
  * In the editor, open the asset Resources/EditorRuntimeSettings and change the Data Directory to where your asset dump is.
* Load the scene Scenes/Start.
* Hit play.

# Used library :

* [VGMToolbox](https://sourceforge.net/projects/vgmtoolbox/) to load acb/awb files
* [DereTore](https://github.com/OpenCGSS/DereTore) to play hca files
* [Flatbuffers](https://google.github.io/flatbuffers/) to read database
* [LitJson](https://litjson.net/) to read some json
