# WSLemonway : webservices instructions

## Solution content

The solution WSLemonWay.sln gathers 3 projects :
- WSLemonWay
- AppelConsole
- AppelForms

### WSLemonWay

This project contains the two webservices demanded :
- Fibonacci(int n) which returns the value of nth position of the Fibonacci suite as an integer.
- XmlToJson(string xmlString) which returns xmlString converted to Json formatas a string.
Both webservices can be called with soap or Json requests. 

### AppelConsole
This project runs a console application that calls the Fibonacci webservice from localhost to get the 10th value of the suite and display it, then waits for you to press any key before automatically closing.


### AppelForms
This project runs a desktop application that has one only button which calls the Fibonacci webservice from localhost to get the 10th value of the suite and deliver it in a popup while displaying a "Please wait..." message and a loading bar.

## Setup
To allow the AppelConsole and AppelForms to access the webservices via localhost, you shall run the webservices project, then right click on the application you wish to launch, click ```Debug``` then ```Start new instance```.

## Logs
All calls, handled errors and returns of both webservices can be consulted in the file : ```WSLemonWay\webservices.log```


## References

### WSLemonWay

This project uses the following libraries :
- log4net to manage logs.
- Newtonsoft.Json to parse xml to Json.

All libraries needed are included in the delivered solution.


## Author and purpose
This project is developped by Jérémy ALLOUIS in the context of a technical recruiting test. March 2020.
