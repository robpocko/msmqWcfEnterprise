This is one part of a two-part suite for a service using MSMQ bindings for WCF, that will be posted in IIS

This part constitutes the server

Steps taken:

1.	Create msmqEnterpriseContract. It is an ordinary Class Library project.
	1.	Add reference to System.ServiceModel
	2.	Rename Class1.cs as ImsmqEnterpriseContract.cs
	3.	Change the definition to an Interface.
	4.	The code is as you find it! Note the [ServiceContract] and [OperationContract(IsOneWaty)] decorations

2.	Create msmqEnterpriseLibrary. It is also an ordinary Class Library project.
	1.	Add nuGet package Net4Log
	2.	Rename Class1.cs as TimeLogger.cs
	3.	The code is as you find it

3.	Create msmqEnterpriseService. It is a WCF Service Application project
	1.	Add a reference to msmqEnterpriseContract
	2.	Add a reference to msmqEnterpriseLibrary
	3.	Delete IService1.cs
	4.	Rename Service1.svc to msmqEnterpriseService.svc. Will have to manually change the name of the class in code. It should also
		implement ImsmqEnterpriseContract. Also change the value of Service in the services mark-up (right-click on service and choose 'View Markup').
		Remove the boiler-plate code. The code should be as you find it
	5.	Configure it to run under Local IIS. Don't forget to Create Virtual Directory

4.	Create MSMQ
	1.	Run Computer Management Console
	2.	Add new Private Queue
		*	name is msmqEnterpriseService/msmqEnterpriseService.svc
		*	check 'Transactional'
		*	add MARBLE\IIS_IUSRS to users. Ensure that 'Recieve Message', 'Peek Message' and 'Send Message' are all checked

5.	Run IIS Console
	1.	Change the Enabled Protocols for the web service to 'http,net.msmq' (Advanced Settings)

6.	Add build event to msmqEnterpriseContract project
	1.	Ensure that there is a build event to copy the *.dll to a folder that is available to the client solution
