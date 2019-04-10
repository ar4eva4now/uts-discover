# UTS Discover
UTS Discover is a promotional AR app for UTS Engineering & IT International. 

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
