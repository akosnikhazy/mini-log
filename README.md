# mini-log
A small application for keeping and reading logs. I made this for personal use, so I can keep logs faster (I done it by hand for a long time). It is not developed too far, very basic in many aspects. Feel free to develop it more.

If you make a release version of it you need to put an user.txt file in the ini folder. It should contain one line username;sha256(salt+password+salt);salt

I am sure nobody will use this, but if you do and security is important there is two things to keep in mind:
1. I made this for my personal use, I am not keeping secrets in it. In the Encryption.cs file you can see I only base64 encode the log. It might be good against layperson eyes, but anyone half knowledgeable about computing could figure it out. Also the login screen is only for keeping random users posting logs in the Application. So you can and you should write your own encryption methods.
2. This version uses the a sha256(salt+password+salt) method for checking password hash. If security is important to you DO NOT leave it like this. Come up with your own salting and keep it secret. Knowing the salting algorithm makes it easy to brute force the password.
