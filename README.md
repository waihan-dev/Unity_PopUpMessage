# PopUp Notification System for Unity

Welcome to the PopUp Notification System for Unity, a versatile and easy-to-use solution designed to enhance user interaction within your Unity applications. This system allows you to display notifications with custom messages, icons, and actions, making it an ideal tool for a wide range of applications, from games to interactive applications.

## Features
1. Customizable Notifications: Tailor your notifications with custom titles, descriptions, and button actions to fit the needs of your application.
2. Icon Support: Enhance the clarity and visual appeal of your notifications with support for icons, including distinct icons for general, warning, success, and error notifications.
3. Color Schemes: Easily customize the appearance of your notifications with predefined color schemes that visually differentiate between general, warning, success, and error messages.

## Notification Types
Our system includes four primary types of notifications, each designed to convey a specific level of urgency or information:

1. General Notifications - Ideal for general information and announcements. 
2. Warning Notifications - Use these to caution users or warn them of potential issues. 
3. Success Notifications - Celebrate achievements or successful operations. 
4. Error Notifications - Alert users to errors or problems that need attention.

## Supporting Platforms
1. Standalone Builds
2. Android
3. iOS
4. WebGl
5. and more..

⚠️ NOTE! :
Does not supported VR mode yet.

## Getting Started
### Step 1: Import the Notification System
Ensure you have cloned or downloaded the PopUp Notification System into your Unity project's Assets folder.

⚠️ NOTE! : No need to add any prefab to the scene

### Step 2: Configure the Notification Service
In your scripts, ensure you include the namespace to access the notification service:
```
using PopUpMessage.Service;
```

### Step 3: Displaying a Notification
To display a notification, use one of the static methods provided by the NotificationService. Here's how to display each type of notification:

#### General Notification
```
NotificationService.ShowGeneral(
    "Welcome!", 
    "Thank you for using our application.", 
    "OK", 
    () => Debug.Log("General notification confirmed.")
);
```
#### Warning Notification
```
NotificationService.ShowWarning(
    "Attention Needed", 
    "Please check your settings.", 
    "Review", 
    () => Debug.Log("Warning notification confirmed.")
);
```
#### Success Notification
```
NotificationService.ShowSuccess(
    "Success!", 
    "Your operation was completed successfully.", 
    "Great!", 
    () => Debug.Log("Success notification confirmed.")
);
```

#### Error Notification
```
NotificationService.ShowError(
    "Error Encountered", 
    "An error has occurred. Please try again.", 
    "Retry", 
    () => Debug.Log("Error notification confirmed.")
);
```
