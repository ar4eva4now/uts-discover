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
1) Open `file > Build Settings`
2) Switch to Android from the `Platform` menu
3) Go to `Player Settings`
4) Under `XR Settings`, make sure `Viewforia Augmented Reality` is checked
5) Under `Other Settings`, set `Bundle Identifier` to "com.AR4EVA4NOW.UTSDiscover"
6) Under `Other Settings`, make sure `Android TV` is unchecked 
7) Under `Other Settings`, make sure `Minimum API Level` is set to API Level 25 
8) Under `Build Settings` click `Build And Run`


## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)
