# Independent Realtor Web Application
### CIS174 Final Project for Brody Boell, Cole Cooley, Anthony Hamlin

Project Description: <br />The is an independent realtor web application utilizing C# ASP.NET MVC Core, and provides a way to share to the public information about the realtor and their property listings.  A realtor can have many properties listed and a realtor can have many public users interested in the realtor's property listings. The independent realtors is the admin and the admin can authorize and set access level roles for other agents/employees to use portions of the app. The primary functionality available through the site, but not limited to, will be login authentication, authorization-access restrictions, Session/cookie handing, Admin area and CRUD actions to manage the content and will be deployed to azure.

## Final Project Requirements as of April 5, 2024 Provided by Instructor
### Due May 1, 2024 11:59PM
* You will submit your URL to your deployed web application and Web API(probably the same URL for both), and if you did a desktop app or Unity application submit a zipped file with compiled executable. (This means I should be able to double click it and run the application without opening visual studio or anything else)
* You will submit a valid username, password, and connection string for your database so I can log in and look at your database and modify data, the same one your app uses is fine.
* You will submit the URL for your teams Github Repository, if it is private make sure you add my account which you can find by my dmacc email emhennis@dmacc.edu. This MUST be the repo for your whole group so I should see everyone's commits. If I don't see a group member's name on any commits or a somewhat even number of them I will be questioning if those members actually did anything. 
* You will submit your video presentation(Preferably a link rather than a giant file) if this is an online only course, for the web blended course the presentation is done in class on July 27th. 
* You will submit a zipped file with your peer evaluation for each member of your group. Be honest, if I have reason to believe that your group is not being honest I will remove points for all members. If you started with a group and ended up on your own I expect you to write a honest self evaluation. Again if you think that you can just give yourself all the points I will give you no points.
* Make sure you also submit anything else I would need to connect to your web application and/or web api so any accounts that I should use with password or any keys that I need for the web api.
* Submit the names of all team members. Each team member will submit their own version of this since they will be submitting different evaluations and such. However things like the project, and URLs should be the same for each group member.

### The grading will work as below, but the general rule of thumb is that you need to display use of every concept in the course in order to get full points. 
* Make sure you are following all patterns and practices learned in the course and following industry standards. 
* Also you can expect if you have gotten feedback earlier in the course saying that I wasn't counting points off but I would later that those types of things will definitely be counted off this time.

## 250 points Total:
* **(150 pts)Final project: Features, functionality, user experience, code style, and coding syntax.**
  - (10) Proper routing techniques, route templates for website and attribute routing for web api. 
  - (20) Using binding models and validating all user input in a logical manner to give the users a good experience and keep your application safe.
  - (10) Use tag helpers to create your forms in your web application for a nice user experience.
  - (20) Create and utilize a SQL Server database using at least one data context and entity framework core to access the database. Do all your database interactions in services. You should have examples of creates, reads, updates, and deletes
  - (10) Use MVC filters to clean up your code and remove code redundancy. You should not have repetitious code in the controllers/actions.
  - (10) You should use user accounts, registration, login all using Identity.
  - (10) You should use authorization to limit access to parts of your application for people that do not have access to them. You should also have Razor elements that are shown or hidden based on authorization.
  - (10) Create and utilize state management through Sessions or Cookies
  - (10) Create and utilize proper error handling techniques including having a custom error handling view
  - (20)  Unit test your code. You should have tests around all your business logic so everything in your services and such should be tested. I am expecting 100% coverage on your business logic since your sites are relatively small applications.
  - (20) Azure works 
* **(50 pts) Project presentation**
  - (20) Project demo, you should show all the functionality of your project in the demo
  - (10) What went well during your project, successes and things you are proud of, and things you learned while doing it.
  - (10) What did not go well during your project, challenges and things you struggled with, and how you would improve it if you were to do it again today.
  - (10) Length of the presentation. You are targeting 5 minutes for this presentation.
* **(50 pts) Peer review**
  - You will complete a form for each other person in your group, unless you ended up alone by the end. 
  - The grades will be based on your honesty and how you were evaluated. 

  <br />
