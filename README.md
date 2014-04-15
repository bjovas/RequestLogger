RequestLogger
=============

Simple Asp.Net webapp that uses log4net to log any incoming requests

Often times, a customer is sending requests which they don't really know the contents off, and they want us to receive them and handle them in some way. Instead of the cumbersome process of setting up a session where you can use tools like Wireshark to check the requests, it is very simple to deploy this application online, supply the URL to the customer, and check the logfile at your leisure to see if any requests has been received.

Thanks to Sam Shiles for the extension method: http://stackoverflow.com/a/9630999/29397
