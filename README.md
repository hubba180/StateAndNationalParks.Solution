<h1 align="center"><strong>The State and National Parks API</strong></h1>

##### By _**Kyle Hubbard**_  


## **Description**
This is an API and affiliated database that contains seeded information on all National Parks and select State Parks. It has been built using C#/ASP.Net and offers full CRUD and search functionality.

## **💻SETUP**

_NOTICE: The following instructions rely on the intended user to have mySQL Community server and Workbench installed in order to utilize SQL's local server. If mySQL is not installed, users may find a download for the SQL installer [here](https://dev.mysql.com/downloads/file/?id=484914) to install the latest version of Community server and Workbench. Keep track of your local server's password, it will need to be appended to the appsettings.json after "pwd= {Please Insert yor password here}"_. 

copy this url to clone this project to your local system:
```html
https://github.com/hubba180/StateAndNationalParks.Solution
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link as shown in the image below.

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif "Cloning from Github within VSCode")

<br>

With the project open to the root directory, navigate to the production directory with the following command in your terminal.
```js 
cd StateAndNationalParksAPI
```

Then, install the necessary packages with the following command
```js 
dotnet restore 
```
Build with the following command
```js 
dotnet Build
```

Next, apply the SQL database to your local workbench with the following command
```js 
dotnet ef database update
```

Finally, you can start the program with this command.
```js 
dotnet run 
```

<!-- ![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/dotnet-readme.gif "How to clone repo")

[w-top]:https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/windows-pass-sm.png "↓ Windows Compatibility Status ↓"
[l-top]:https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/linux-pass-sm.png "↓ Linux Compatibility Status ↓"
[m-top]:https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/mac-pass-sm.png "↓ macOS (OSX) Compatibility Status ↓" -->
## **PROTECTING YOUR DATA**

#### **Step 1: From within VSCode in the root project directory, we will create a .gitignore file**

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/mac-pass-sm.png)
```js 
touch .gitignore 
```

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/windows-pass-sm.png)

```js 
ni .gitignore 
```

#### Step 2: commit that .gitignore file (this prevents your sensitive information from being shown to others). **⚠️DO NOT PROCEED UNTIL YOU DO!⚠️**

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/entity-readme-image.png "Set up instructions")

#### Step 3: **To commit your .gitignore file enter the following commands**

```js
git add .gitignore
```
```js
git commit -m "protect data"
```

#### Step 4: **Then, you need to update your username and password in the appsettings.json file.**

_by default these are set to user:root and an empty password. if you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)

<br>

<h1 align="center"><strong>API Documentation</strong></h1>

### **Routing Conventions:**

### The following end points have been tailored to the National Parks. In order to access state park objects,

  * *Method* GET: ```http://localhost:5000/api/nationalpark```
      * Returns a list of the first 25 National Parks
      * Json Response Format: 
      ```
      {
        "NationalParkId": ##
        "Name": "Example"
        "State": "Example State"
        "Region": "Example Region"
      }
      ```
  * *Method* GET: ```http://localhost:5000/api/nationalpark/search/?name=Glacier```
      * Returns a search result based on park name
      * Json Response Format: 
      ```
      {
        "nationalParkId": 35,
        "name": "Glacier",
        "state": "Montana",
        "region": "Northwest"
      }
      ```
      * *Method* GET: ```http://localhost:5000/api/nationalpark/25```
      * Returns a single object based on Id
      * Json Response Format: 
      ```
      {
        "nationalParkId": 25,
        "name": "Rocky Mountain",
        "state": "Colorado",
        "region": "Southwest"
      }
      ```
      * *Method* POST: ```http://localhost:5000/api/nationalpark...```
      * Posts a new national park object to the database
      * Json Response Format: 
      ```
      {
        "NationalParkId": ##
        "Name": "Sample"
        "State": "Sample State"
        "Region": "Sample Region"
      }
      ```
      * *Method* PUT: ```http://localhost:5000/api/nationalpark/{id}```
      * Upadates an old entry with new information
      * Json Response Format: 
      ```
      {
        "NationalParkId": ##
        "Name": "Updated Name"
        "State": "Updated State"
        "Region": "Updated Region"
      }
      ```
      * *Method* DELETE: ```http://localhost:5000/api/nationalpark/{id}```
      * Deletes a national park object from the database

