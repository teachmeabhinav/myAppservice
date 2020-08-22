Assumptions:
1. Edge devices are configured
2. Azure Iot hub is set
3. Eventhub namespace and Lib is in place
=====================================================

TODO List:
1. Team need to add eventhub library service in startup.cs @ line 25
2. Team need to add subscribe to an event in startup.cs @ line 55
3. Team need to add eventhub library service in startup.cs @ line 25
4. Team need to remove AngleController before production 
5. Team need to add database call for saving data in database by following the Datamodel given.

=====================================================

Design:
1. Design diagram is @ Documents/Clock to Angle-Design
2. Design as follow
	a. IOT is connect to device.
	b. It will send data to Eventhub topic.
	c. Service will listen to that event by subscribing the topic.
	d. Save it to the database.

CI/CD:
1. We will use CI with Git 
2. For branching we will use Git flow
3. We do CD with Git action

For Prduction below are modification need to be done
When Pr is raised for the code 
1.  Unit test cases should be pass
2.  Sonar Cube should be passed 
3.  We will implement slot depl. for App service




