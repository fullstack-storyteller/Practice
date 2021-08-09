# Ensuring the security

In our previous section we saw that we can now make api calls of both http and https using our employee api. We also saw how to ensure that the `localhost` certificate is recognized by the browser when using https Uri Scheme. This was achieved by importing the `localhost` certificate into the `Trusted Root Certification Authorities` in `mmc.exe` utility.

Now, our goal is to ensure that even when http api call is made, the user is redirected to the https version of the webapi. Currently we have the below project properties (click `F4` on the project selection)

![properties](./images/14.PNG)
