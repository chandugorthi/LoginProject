# LoginProject

This is demo application where a normal user/ admin can login.
A normal user can view/edit his profile and view his transaction details. 
An admin can view/edit his own profile, create new user, view all the user details and can view all the transactions of all the users.

This application has 3 screens
1. Login Screen : 
    a.This is the first screen when that apprears when the application is launched.
    b.Facilitates user/admin to login, to enter the main screen or to Signup.
    c.Admin Credentials- UserName:haritha ; Password: haritha
    d.Sample Normal user Credentials- UserName: chandu ; Password: chandu

2. SignUp screen:
   a. This screen is shown when the user clicks on SignUp button in Login screen.
   b. To create his/her account user needs to provide, username, password and Account Number.

3. Main Screen(Citi User Info):
   Has 2 items in the menu bar. 
    a.The first menu item has 2 submenu items(Profile, logout).
      Profile: 
        i. Normal User:Can view his own details.
                       Can edit his profile by clicking 'Update My Profile button' and can save his details.
        ii. Admin:Can view his own details.
                  Can edit his profile by clicking 'Update My Profile button' and can save his details.
                  Can create profile for new user on 'new' button click and save the same.Here the system would automatically generate user id and password for the new user, if id and password for that user are not created earlier.
      Logout:
        Logs out from the application.
    b.The second menu item also has 2 submenu items(User Details and Transaction Details). 
       User Details: 
          This menu item is available only to admin, so that admin can view details of all the users.
       Transaction Details:
         i. Normal user: Can view only his transactions.
         ii. Admin: can view the transaction details of all the users.


 
 
