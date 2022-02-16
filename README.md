# BEIER360 Interview Test

### Setup
To complete the test, you will be creating your own private repository from this template.

1. On GitHub, view this repository and click "Use this template".
2. Make sure the "Owner" is set to your **personal GitHub account**.
3. Make sure the "Visibility" is set to **Private**.
4. Give it a name and click "Create repository from template".
5. Lastly, make sure to go to "Settings > Collaborators > Add people", and add Ashley to your repository to review it.
    - Username: `ashleyswanson360`
    - Email: `ashley.swanson@beier360.com`

## Project Structure
The app is a modified version of the default Xamarin.Forms project. The solution consists of five projects.

- **InterviewApp:**
The cross-platform Xamarin.Forms project, containing all shared code.

- **InterviewApp.Android:**
The platform specific project for Android. This is the project you run when developing for Android.

- **InterviewApp.iOS:**
The platform specific project for iOS. This is the project you run when developing for iOS.

- **Libraries/InterviewApp.Basic:**
This is a cross-platform library that contains some common code. Defines the `Item` model and the `IDataStore` interface.

- **Libraries/InterviewApp.Advanced:**
This is a cross-platform library that provides an EF Core implementation of the `IDataStore` interface.

### App Features
The app currently has three main features.

- **About:**
A simple page that has a button to open Xamarin documentation, and a label to display the device's make and model.

- **Items:**
A list of items, each with a title and description. Each item can be opened in it's own detail page, and you can add new items.

- **Login:**
By logging out, you are taken to a login page and are unable to navigate to other pages in the app. Logging in returns you to the About page.

## Tasks
There are four tasks to complete.

1. **Fix:**
When pressing the Update button on the About page, to load the device's make and model, the app crashes. You need to debug and solve this issue.

2. **Improve:**
Make an improvement to any of the three existing features. This could be cleaning or optimising the code, or improving the user experience.

3. **Implement:**
Add a new feature to the app. Make sure you adhere to any third-party licences, and attribute any work that is not your own.
It should not require any preparation from us to test it. We should be able to download and immediately run your app.

4. **Advanced (optional):**
By default, the Items feature does not persist changes between sessions. The `InterviewApp.Advanced` library provides an implementation of the data store that persists the items to the device using EF Core and a SQLite database.
You can switch to use this advanced data store by defining the `ADVANCED` compilation symbol in the `InterviewApp` project settings. (Or you can uncomment the `DefineConstants` line when manually editing the `InterviewApp.csproj` file).
When using this advanced data store, the app will log an error when opening the Items page and will crash when trying to add a new item. You need to debug and solve this issue.
	
Please document your work and your thought-process, through commits, comments or just a log in a .txt file.

## Contact
If you need any help or guidance, contact Ashley by emailing him at `ashley.swanson@beier360.com`, or through the recruitment agency.
