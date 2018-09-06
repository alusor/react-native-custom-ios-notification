
# react-native-custom-notification

## Getting started

`$ npm install react-native-custom-notification --save`

### Mostly automatic installation

`$ react-native link react-native-custom-notification`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-custom-notification` and add `RNCustomNotification.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNCustomNotification.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNCustomNotificationPackage;` to the imports at the top of the file
  - Add `new RNCustomNotificationPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-custom-notification'
  	project(':react-native-custom-notification').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-custom-notification/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-custom-notification')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNCustomNotification.sln` in `node_modules/react-native-custom-notification/windows/RNCustomNotification.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Custom.Notification.RNCustomNotification;` to the usings at the top of the file
  - Add `new RNCustomNotificationPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNCustomNotification from 'react-native-custom-notification';

// TODO: What to do with the module?
RNCustomNotification;
```
  