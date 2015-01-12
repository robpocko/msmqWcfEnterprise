This is one part of a two-part suite for a service using MSMQ binding for WCF, that will be posted in IIS

This part constitutes the client

Steps taken:

1.	Create EnterpriseWcfClient. It is a Windows Forms Application project

2.	Add the 'Libraries' folder to this project. 

3.	Compile the server solution, which will copy msmqEnterpriseContract.dll into the Libraries folder

4.	Add reference to this dll

5.	Add reference to System.ServiceModel

6.	Add MsmqEnterpriseContractClient class to project. This inherits from ClientBase<IMsmqEnterpriseContract> and implements IMsmqEnterpriseContract 

7.	Need to config endpoints for client. Update app.config