# Baltimore Fishackathon

* Bryan Connor
* Dana Hanna	
* Eric Whitaker
* Eugene Zhuravel
* Matt Sullivan
* Seth Rudesill

## Philippines Problem Statement
The field Enumerators need to be able to collect more accurate data in a more expedient and efficient manner in order to monitor more gear landings across a wider area. 

## Solution
We've built a mobile application designed to help Enumerators enter data quickly and efficiently in the field, aided by 21st century platforms. This data is sent to a centralized platform where it can be used in a number of different ways. We've built one example that uses collected data to display a time-based heat map of recorded catch data. 

![alt tag](https://raw.github.com/thesoftwarejedi/fishackathon/master/collector.png)

## Assumptions
Enumerators would have access to an Android phone that could run an application and occasionally have access to a mobile network of some kind. If the device has a camera, the collector app could also take advantage of that. We also assume that Enumerators might have limited access to a mobile network so the app loads up and stores all data locally until a network is found.

## Product / Tool
The tool is a mobile application that stores data collected by Enumerators when recording in the field and sends it to a central service when connected network. The data is collected in a form specifically designed to record the data required to maintain sustainable fisheries. 

## Innovation 
Digitizing and streamlining the data collection process will help ensure that more data is captured and that the data is of better quality. 

## Interface
The interface is a single scrolling form that is easily manipulated on mobile devices. Fields are designed for quick entry. The interface also features an interactive map for fishers to point to their catch sites and record the latitude and longitude. There's also a method for Enumerators to upload any associated photos which could help fill in missing fields (vessel type, fish species, etc.). 

## Impact
The potential impact could be a more uniform, complete and flexible set of data for policy makers and other key stakeholders to analyze. By making catch locations more readily available and by enabling Enumerators to capture digital photos of catches, this application will enrich data in ways previously impossible. Similar technology could eventually be extended to fishers (with proper incentive structures) to scale and distribute the role of data recording. 

## Implementability
With the State Department providing mobile phone support, Enumerators will have access to platforms that can run our mobile data recorder. The tool uses the same attributes as the paper recorders currently in use and would require little additional training. The app would support local storage and could be used with intermittent network connectivity 

## Other Remarks 
The data is being collected in a centralized web service which can open data to any number of potential applications and stakeholders who might want to use it for different purposes. The form can be easily customized to support additional data or tailored for specific users (such as the fishers themselves). Because it's all collected and stored digitally this data can be transformed and optimized for its final destination and hopefully be made useful for sustaining small scale fisheries in the Philippines and beyond. 
