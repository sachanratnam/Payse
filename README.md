# Payse

Payse is a free and open-source application specifically developed for Indian streamers. It send the donation received from Indian payment system(e.g. Paytm) to StreamLabs and provides alert for each donation.
For more info check F.A.Q. below.


## Disclaimer
I am not responsible for any kind of loss/damage occur due to Payse. Please use Payse at your own risk.


## Download

[Click here to download Payse](https://github.com/heyanush/Payse/releases/download/v1.1(beta)/PayseSetup.exe)


## Working

Payse work by monitoring the Email account on which donation messages are received. As soon as you receive an Email from payment provider(e.g. Paytm), Payse process it and sends the donation alert to StreamLabs. Payse securely connects with your Email and StreamLabs account to perform these operation.


## Guide

**NOTE : In order to use Payse, you must "not" read the emails received from payment provides, the app is designed to automatically read those emails. Also you must "not" mark them unread/read, doing this will lead to duplicate or no donation at all.**

1. Download the setup from the link above and install it on your system.
2. Launching the application for first time will take you to setup process.
3. Connect your Email account which is associated with the payment provide and your StreamLabs account.
4. After successfully finishing the setup you will be lead to dashboard.
5. Press "START" to start the application.
6. To stop the application simply press "STOP".

**Please note that only emails received after the completion of setup will be processed by the application, older emails (if any) will be ignored.**

#### Additional Settings
You can change the settings by click on "Settings" tab.

**Refresh delay** : This is the time interval at which Payse checks for new emails form payment system.

**Reconnect delay** : If the connection breaks, the application can automatically retry for connection after this time interval. You can set this to "Never", in that case Payse stops whenever it encounter an error.

**Exchange rate** : Since StreamLabs does not support INR yet, we have to convert the donation amount to supported currency. You can change the exchange rate accordingly.

**Reset Application** : By resetting application all your account will be disconnected and you have setup the application again in order to use.

**Save** : After changing Refresh delay/Reconnect delay/Exchange rate you must click "SAVE" to those settings.


## F.A.Q.

#### How secure is Payse?
Payse is open-source which means anyone can view and customise the code as per their need. Open-source nature lets contribution from various individuals which makes the application more secure and stable with the time. Although you can browse code and can report weaker or less secure section of application. Every feedback is appreciated.

#### How secure is Payse, again?
Payse uses Oauth 2.0 for authentication which is industry level standard to connect with your inbox. No extra permission are requested other than required.
Payse also employe strict policy of no in-app browser for login/authorisation purposes. Payse uses system browser for all login/authorisation process. This makes the app user experience slightly less comfortable but provides an overall cleaner, secure and trustable solution.

#### Do you store password?
NO, Neither me nor application store password in any manner.

#### What India payment provide does Payse support?
As of now Payse only support Paytm. It can be expanded for other provider as well in future.

#### What Email provider does Payse support?
As of now Payse only support Gmail. It can be expanded for other provider as well in future.

#### What are its limitations?
Since payment provider (which Payse currently support) only informs about the amount and name of the sender, therefore the alert sent to StreamLabs does not contain the message sent by the donor.

#### How can I view the message from the donor?
Unfortunately you have to manually check the app/website of that particular payment service provider.

#### I have more questions.
For addition queries you can hit me up on Twitter [@heyanush](https://twitter.com/heyanush)


## About the code
The application is coded in C# and uses .Net framework 4.5. The code itself is written in very non object oriented way (I Know!). Any contribution/suggestion towards the code are welcomed.


## About me
I am Anush, you can follow me on Twitter [@heyanush](https://twitter.com/heyanush)
