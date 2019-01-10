# HPC.ACM - the C# library for the HPC Web API

Preview

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CsharpDotNet2ClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id
            var job = new JobUpdate(); // JobUpdate |  (optional) 

            try
            {
                // Cancel a clusrun
                apiInstance.CancelClusrunJob(id, job);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CancelClusrunJob: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**CancelClusrunJob**](docs/DefaultApi.md#cancelclusrunjob) | **PATCH** /clusrun/{id} | Cancel a clusrun
*DefaultApi* | [**CancelDiagnosticJob**](docs/DefaultApi.md#canceldiagnosticjob) | **PATCH** /diagnostics/{id} | Cancel a diagnostic test run
*DefaultApi* | [**CreateClusrunJob**](docs/DefaultApi.md#createclusrunjob) | **POST** /clusrun | Create a clusrun
*DefaultApi* | [**CreateDiagnosticJob**](docs/DefaultApi.md#creatediagnosticjob) | **POST** /diagnostics | Create a diagnostic test run
*DefaultApi* | [**GetClusRunJobSummary**](docs/DefaultApi.md#getclusrunjobsummary) | **GET** /dashboard/clusrun | Get summary of ClusRun jobs
*DefaultApi* | [**GetClusrunJob**](docs/DefaultApi.md#getclusrunjob) | **GET** /clusrun/{id} | Get a clusrun
*DefaultApi* | [**GetClusrunJobAggregationResult**](docs/DefaultApi.md#getclusrunjobaggregationresult) | **GET** /clusrun/{id}/aggregationResult | Get aggregation result of a clusrun job
*DefaultApi* | [**GetClusrunJobs**](docs/DefaultApi.md#getclusrunjobs) | **GET** /clusrun | Get a list of clusruns
*DefaultApi* | [**GetClusrunOutput**](docs/DefaultApi.md#getclusrunoutput) | **GET** /output/clusrun/{key}/raw | Get the whole output of a task
*DefaultApi* | [**GetClusrunOutputInPage**](docs/DefaultApi.md#getclusrunoutputinpage) | **GET** /output/clusrun/{key}/page | Get partial output of a task
*DefaultApi* | [**GetClusrunTask**](docs/DefaultApi.md#getclusruntask) | **GET** /clusrun/{id}/tasks/{taskId} | Get a task of a clusrun
*DefaultApi* | [**GetClusrunTaskResult**](docs/DefaultApi.md#getclusruntaskresult) | **GET** /clusrun/{id}/tasks/{taskId}/result | Get a task result of a clusrun
*DefaultApi* | [**GetClusrunTasks**](docs/DefaultApi.md#getclusruntasks) | **GET** /clusrun/{id}/tasks | Get tasks of a clusrun
*DefaultApi* | [**GetDiagnosticJob**](docs/DefaultApi.md#getdiagnosticjob) | **GET** /diagnostics/{id} | Get a diagnostic test run
*DefaultApi* | [**GetDiagnosticJobAggregationResult**](docs/DefaultApi.md#getdiagnosticjobaggregationresult) | **GET** /diagnostics/{id}/aggregationResult | Get aggregation result of a diagnostic job
*DefaultApi* | [**GetDiagnosticJobSummary**](docs/DefaultApi.md#getdiagnosticjobsummary) | **GET** /dashboard/diagnostics | Get summary of diagnostic jobs
*DefaultApi* | [**GetDiagnosticJobs**](docs/DefaultApi.md#getdiagnosticjobs) | **GET** /diagnostics | Get a list of diagnostic test runs
*DefaultApi* | [**GetDiagnosticTask**](docs/DefaultApi.md#getdiagnostictask) | **GET** /diagnostics/{id}/tasks/{taskId} | Get a task of a diagnostic test run
*DefaultApi* | [**GetDiagnosticTaskResult**](docs/DefaultApi.md#getdiagnostictaskresult) | **GET** /diagnostics/{id}/tasks/{taskId}/result | Get a task result of a diagnostic test run
*DefaultApi* | [**GetDiagnosticTasks**](docs/DefaultApi.md#getdiagnostictasks) | **GET** /diagnostics/{id}/tasks | Get tasks of a diagnostic test run
*DefaultApi* | [**GetDiagnosticTests**](docs/DefaultApi.md#getdiagnostictests) | **GET** /diagnostics/tests | Get available diagnostic tests
*DefaultApi* | [**GetMetricCategories**](docs/DefaultApi.md#getmetriccategories) | **GET** /metrics/categories | Get node metric categories
*DefaultApi* | [**GetMetricsOfCategory**](docs/DefaultApi.md#getmetricsofcategory) | **GET** /metrics/{category} | Get node merics in a category
*DefaultApi* | [**GetNode**](docs/DefaultApi.md#getnode) | **GET** /nodes/{id} | Get a node
*DefaultApi* | [**GetNodeEvents**](docs/DefaultApi.md#getnodeevents) | **GET** /nodes/{id}/events | Get events of a node
*DefaultApi* | [**GetNodeJobs**](docs/DefaultApi.md#getnodejobs) | **GET** /nodes/{id}/jobs | Get jobs of a node
*DefaultApi* | [**GetNodeMetadata**](docs/DefaultApi.md#getnodemetadata) | **GET** /nodes/{id}/metadata | get metadata of a node
*DefaultApi* | [**GetNodeMetricHistory**](docs/DefaultApi.md#getnodemetrichistory) | **GET** /nodes/{id}/metricHistory | Get metric history of a node
*DefaultApi* | [**GetNodeScheduledEvents**](docs/DefaultApi.md#getnodescheduledevents) | **GET** /nodes/{id}/scheduledEvents | get scheduled events of a node
*DefaultApi* | [**GetNodeSummary**](docs/DefaultApi.md#getnodesummary) | **GET** /dashboard/nodes | Get summary of nodes
*DefaultApi* | [**GetNodes**](docs/DefaultApi.md#getnodes) | **GET** /nodes | Get a list of nodes
*DefaultApi* | [**SyncScripts**](docs/DefaultApi.md#syncscripts) | **POST** /sync | Sync diagnostic and metric scripts from GitHub


<a name="documentation-for-models"></a>
## Documentation for Models

 - [HPC.ACM.Model.DiagnoticTest](docs/DiagnoticTest.md)
 - [HPC.ACM.Model.Event](docs/Event.md)
 - [HPC.ACM.Model.IpV4](docs/IpV4.md)
 - [HPC.ACM.Model.IpV6](docs/IpV6.md)
 - [HPC.ACM.Model.Job](docs/Job.md)
 - [HPC.ACM.Model.JobState](docs/JobState.md)
 - [HPC.ACM.Model.JobSummary](docs/JobSummary.md)
 - [HPC.ACM.Model.JobType](docs/JobType.md)
 - [HPC.ACM.Model.JobUpdate](docs/JobUpdate.md)
 - [HPC.ACM.Model.MacAddress](docs/MacAddress.md)
 - [HPC.ACM.Model.Metrics](docs/Metrics.md)
 - [HPC.ACM.Model.MetricsValues](docs/MetricsValues.md)
 - [HPC.ACM.Model.Node](docs/Node.md)
 - [HPC.ACM.Model.NodeGpu](docs/NodeGpu.md)
 - [HPC.ACM.Model.NodeJob](docs/NodeJob.md)
 - [HPC.ACM.Model.NodeMetadata](docs/NodeMetadata.md)
 - [HPC.ACM.Model.NodeMetadataCompute](docs/NodeMetadataCompute.md)
 - [HPC.ACM.Model.NodeMetadataNetwork](docs/NodeMetadataNetwork.md)
 - [HPC.ACM.Model.NodeMetadataNetworkInterface](docs/NodeMetadataNetworkInterface.md)
 - [HPC.ACM.Model.NodeMetadataNetworkIpv4](docs/NodeMetadataNetworkIpv4.md)
 - [HPC.ACM.Model.NodeMetadataNetworkIpv4IpAddress](docs/NodeMetadataNetworkIpv4IpAddress.md)
 - [HPC.ACM.Model.NodeMetadataNetworkIpv4Subnet](docs/NodeMetadataNetworkIpv4Subnet.md)
 - [HPC.ACM.Model.NodeMetadataNetworkIpv6](docs/NodeMetadataNetworkIpv6.md)
 - [HPC.ACM.Model.NodeMetrics](docs/NodeMetrics.md)
 - [HPC.ACM.Model.NodeMetricsData](docs/NodeMetricsData.md)
 - [HPC.ACM.Model.NodeMetricsMetricItems](docs/NodeMetricsMetricItems.md)
 - [HPC.ACM.Model.NodeNetwork](docs/NodeNetwork.md)
 - [HPC.ACM.Model.NodeRegistration](docs/NodeRegistration.md)
 - [HPC.ACM.Model.NodeSummary](docs/NodeSummary.md)
 - [HPC.ACM.Model.ScheduledEvent](docs/ScheduledEvent.md)
 - [HPC.ACM.Model.ScheduledEvents](docs/ScheduledEvents.md)
 - [HPC.ACM.Model.Task](docs/Task.md)
 - [HPC.ACM.Model.TaskOutput](docs/TaskOutput.md)
 - [HPC.ACM.Model.TaskResult](docs/TaskResult.md)
 - [HPC.ACM.Model.TaskState](docs/TaskState.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="aad"></a>
### aad

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: N/A

