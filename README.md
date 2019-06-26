# UTS Discover
UTS Discover is an augmented reality (AR) experience for mobile devices that aims to promote the UTS Faculty of Engineering and IT (FEIT) to prospective international students. The AR4EVA4NOW team built the application in the UTS Software Studio as a real, client-driven project for the FEIT, utilising agile development practises. The app, built in Unity, uses AR target-recognition to display video content and 3D models, as well as gyroscopic data to deliver a 360 image tour of UTS campus.

## Deployment & Builds

### Deploying to iOS

Once the project is on an OSX device, open the project in Unity and follow the following steps:

1) Open `file > Build Settings`
2) Switch to iOS from the `Platform` menu
3) Make sure the main scene is in `Scenes in Build`
4) Run in Xcode as "Latest Version"
5) Go to `Player Settings`
6) Under `XR Settings`, make sure `Viewforia Augmented Reality` is checked
7) Under `Other Settings`, set `Bundle Identifier` to "com.AR4EVA4NOW.UTSDiscover"
8) Make sure `Target minimum iOS version` is set to below your phone's iOS version
9) Set `Camera Usage Description` to "Camera access required for target detection and tracking"
10) Under `Build Settings` click `Build And Run`

Xcode should open and build the app. If it asks for a `Provisioning Profile`, set it to `Automatically Manage Signing`.

### Deploying to Android

Once the project is on a device with Android SDK (25>) installed, open the project in Unity and follow the following steps:

1) Open `file > Build Settings`
2) Switch to Android from the `Platform` menu
3) Make sure the main scene is in `Scenes in Build`
4) Go to `Player Settings`
5) Under `XR Settings`, make sure `Viewforia Augmented Reality` is checked
6) Under `Other Settings`, set `Bundle Identifier` to "com.AR4EVA4NOW.UTSDiscover"
7) Under `Other Settings`, make sure `Android TV Compatability`, is unchecked
8) Under `Other Settings`, make sure `Minimum API Level` is set to API Level 25
9) Under `Build Settings` click `Build And Run`

Make sure your Android phone is connected to your device, have USB Debugging enabled and accept the pop-up prompt. 

## Contributing
### Branches
Branches should be named by `epic-name/ticket-name` using dashes where necessary. Ideally, each contributor should have their own branch per-ticket.

### Pull-Requests
When merging functionality at the end of a branch cycle, please:
1) Create a pull-request with a description of the indended changes and functionality
2) Inform another team member to pull and build it to confirm that it works as intended
3) On confirmation of the working state, the testing team member will confirm and merge the request

_Note: ideally the testing team member should have access to a platform other than yours (i.e. iOS, Android, Windows, OSX)_

## License
[MIT](https://choosealicense.com/licenses/mit/)
