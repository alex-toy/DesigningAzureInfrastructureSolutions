# Designing Azure Infrastructure Solutions

- Application Insights and working with Application Insights
- Microsoft Defender for Cloud
- Azure Policies
- Azure Blueprints
- Azure AD Application Proxy
- Azure AD Privileged Identity Management - Azure AD Privileged Identity Management - Access Reviews
- Containers - Deploy a web application onto Azure Kubernetes with the use of containers - How to deploy containerized-based applications.
- Active-geo replication and Auto-Failover groups when it comes to redundancy for Azure SQL databases
- Overview and simple working on Azure Synapse Analytics and Azure Databricks.
- How to transfer data using Azure Data Factory.
- Azure Event Grid and Azure Event Hubs.
- Azure DevOps set of tools.



## Design Monitoring

### Run App Locally
<img src="/pictures/monitoring3.png" title="run app locally"  width="900">

### Create Resources

- virtual machine
<img src="/pictures/monitoring.png" title="create vm"  width="900">

- SQL Database
<img src="/pictures/monitoring1.png" title="create sql database"  width="900">

- Storage Account
<img src="/pictures/monitoring2.png" title="create storage account"  width="900">

### Run App Locally with Resources on Azure

- create storage account and upload local images
<img src="/pictures/monitoring4.png" title="storage account"  width="900">

- populate the Azure SQL Database
<img src="/pictures/monitoring5.png" title="storage account"  width="900">

- run the app locally again. This time, images and other data are retrieved from the cloud

### Run App Locally with Resources on Azure

- on the *Server Manager* / *Dashboard*, clic *Add Roles and Features*
<img src="/pictures/deploy_vm.png" title="deploy app on VM"  width="900">

- add *Web Server IIS*
<img src="/pictures/deploy_vm1.png" title="deploy app on VM"  width="900">

- add *Management Service*
<img src="/pictures/deploy_vm2.png" title="deploy app on VM"  width="900">

- turn off *Enhanced Security Configuration*
<img src="/pictures/deploy_vm3.png" title="deploy app on VM"  width="900">

- download and install *.NET 6.0 Hosting Bundle*
<img src="/pictures/deploy_vm4.png" title="deploy app on VM"  width="900">

- download and install *Web Deploy 3.6*
<img src="/pictures/deploy_vm5.png" title="deploy app on VM"  width="900">

- configure IIS (enable remote connections)
<img src="/pictures/deploy_vm6.png" title="deploy app on VM"  width="900">
Don't forget to start the service
<img src="/pictures/deploy_vm7.png" title="deploy app on VM"  width="900">

- configure IIS Manager Permissions
<img src="/pictures/deploy_vm71.png" title="deploy app on VM"  width="900">
<img src="/pictures/deploy_vm72.png" title="deploy app on VM"  width="900">

- add inbound rule
<img src="/pictures/deploy_vm8.png" title="deploy app on VM"  width="900">

- add DNS
<img src="/pictures/deploy_vm9.png" title="deploy app on VM"  width="900">

- publish app to the VM
<img src="/pictures/deploy_vm91.png" title="deploy app on VM"  width="900">
<img src="/pictures/deploy_vm92.png" title="deploy app on VM"  width="900">



## Design Data Storage

### Connect to Storage Account using Access Keys
<img src="/pictures/sa.png" title="storage account"  width="900">
<img src="/pictures/sa1.png" title="storage account"  width="900">
<img src="/pictures/sa2.png" title="storage account"  width="900">

### Connect to Storage Account using Shared Access Signature

- generate SAS with only read access for only the blobs
<img src="/pictures/sas.png" title="shared access signature"  width="900">
<img src="/pictures/sas1.png" title="shared access signature"  width="900">
<img src="/pictures/sas2.png" title="shared access signature"  width="900">

- see that with our generated SAS, we are not able to upload or delete a file, and only the blobs are visible
<img src="/pictures/sas3.png" title="shared access signature"  width="900">
<img src="/pictures/sas4.png" title="shared access signature"  width="900">

### Connect to Storage Account using Azure Active Directory

- add Role Assignment
<img src="/pictures/ad.png" title="active directory"  width="900">
<img src="/pictures/ad1.png" title="active directory"  width="900">
<img src="/pictures/ad2.png" title="active directory"  width="900">
<img src="/pictures/ad3.png" title="active directory"  width="900">

- now you can signin with azure
<img src="/pictures/ad4.png" title="active directory"  width="900">

- now you are able to access resources from your subscription
<img src="/pictures/ad5.png" title="active directory"  width="900">
