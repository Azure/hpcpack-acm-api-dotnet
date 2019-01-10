# HPC.ACM.Api.DefaultApi

All URIs are relative to *https://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelClusrunJob**](DefaultApi.md#cancelclusrunjob) | **PATCH** /clusrun/{id} | Cancel a clusrun
[**CancelDiagnosticJob**](DefaultApi.md#canceldiagnosticjob) | **PATCH** /diagnostics/{id} | Cancel a diagnostic test run
[**CreateClusrunJob**](DefaultApi.md#createclusrunjob) | **POST** /clusrun | Create a clusrun
[**CreateDiagnosticJob**](DefaultApi.md#creatediagnosticjob) | **POST** /diagnostics | Create a diagnostic test run
[**GetClusRunJobSummary**](DefaultApi.md#getclusrunjobsummary) | **GET** /dashboard/clusrun | Get summary of ClusRun jobs
[**GetClusrunJob**](DefaultApi.md#getclusrunjob) | **GET** /clusrun/{id} | Get a clusrun
[**GetClusrunJobAggregationResult**](DefaultApi.md#getclusrunjobaggregationresult) | **GET** /clusrun/{id}/aggregationResult | Get aggregation result of a clusrun job
[**GetClusrunJobs**](DefaultApi.md#getclusrunjobs) | **GET** /clusrun | Get a list of clusruns
[**GetClusrunOutput**](DefaultApi.md#getclusrunoutput) | **GET** /output/clusrun/{key}/raw | Get the whole output of a task
[**GetClusrunOutputInPage**](DefaultApi.md#getclusrunoutputinpage) | **GET** /output/clusrun/{key}/page | Get partial output of a task
[**GetClusrunTask**](DefaultApi.md#getclusruntask) | **GET** /clusrun/{id}/tasks/{taskId} | Get a task of a clusrun
[**GetClusrunTaskResult**](DefaultApi.md#getclusruntaskresult) | **GET** /clusrun/{id}/tasks/{taskId}/result | Get a task result of a clusrun
[**GetClusrunTasks**](DefaultApi.md#getclusruntasks) | **GET** /clusrun/{id}/tasks | Get tasks of a clusrun
[**GetDiagnosticJob**](DefaultApi.md#getdiagnosticjob) | **GET** /diagnostics/{id} | Get a diagnostic test run
[**GetDiagnosticJobAggregationResult**](DefaultApi.md#getdiagnosticjobaggregationresult) | **GET** /diagnostics/{id}/aggregationResult | Get aggregation result of a diagnostic job
[**GetDiagnosticJobSummary**](DefaultApi.md#getdiagnosticjobsummary) | **GET** /dashboard/diagnostics | Get summary of diagnostic jobs
[**GetDiagnosticJobs**](DefaultApi.md#getdiagnosticjobs) | **GET** /diagnostics | Get a list of diagnostic test runs
[**GetDiagnosticTask**](DefaultApi.md#getdiagnostictask) | **GET** /diagnostics/{id}/tasks/{taskId} | Get a task of a diagnostic test run
[**GetDiagnosticTaskResult**](DefaultApi.md#getdiagnostictaskresult) | **GET** /diagnostics/{id}/tasks/{taskId}/result | Get a task result of a diagnostic test run
[**GetDiagnosticTasks**](DefaultApi.md#getdiagnostictasks) | **GET** /diagnostics/{id}/tasks | Get tasks of a diagnostic test run
[**GetDiagnosticTests**](DefaultApi.md#getdiagnostictests) | **GET** /diagnostics/tests | Get available diagnostic tests
[**GetMetricCategories**](DefaultApi.md#getmetriccategories) | **GET** /metrics/categories | Get node metric categories
[**GetMetricsOfCategory**](DefaultApi.md#getmetricsofcategory) | **GET** /metrics/{category} | Get node merics in a category
[**GetNode**](DefaultApi.md#getnode) | **GET** /nodes/{id} | Get a node
[**GetNodeEvents**](DefaultApi.md#getnodeevents) | **GET** /nodes/{id}/events | Get events of a node
[**GetNodeJobs**](DefaultApi.md#getnodejobs) | **GET** /nodes/{id}/jobs | Get jobs of a node
[**GetNodeMetadata**](DefaultApi.md#getnodemetadata) | **GET** /nodes/{id}/metadata | get metadata of a node
[**GetNodeMetricHistory**](DefaultApi.md#getnodemetrichistory) | **GET** /nodes/{id}/metricHistory | Get metric history of a node
[**GetNodeScheduledEvents**](DefaultApi.md#getnodescheduledevents) | **GET** /nodes/{id}/scheduledEvents | get scheduled events of a node
[**GetNodeSummary**](DefaultApi.md#getnodesummary) | **GET** /dashboard/nodes | Get summary of nodes
[**GetNodes**](DefaultApi.md#getnodes) | **GET** /nodes | Get a list of nodes
[**SyncScripts**](DefaultApi.md#syncscripts) | **POST** /sync | Sync diagnostic and metric scripts from GitHub


<a name="cancelclusrunjob"></a>
# **CancelClusrunJob**
> void CancelClusrunJob (int? id, JobUpdate job)

Cancel a clusrun

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class CancelClusrunJobExample
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 
 **job** | [**JobUpdate**](JobUpdate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceldiagnosticjob"></a>
# **CancelDiagnosticJob**
> void CancelDiagnosticJob (int? id, JobUpdate job)

Cancel a diagnostic test run

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class CancelDiagnosticJobExample
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
                // Cancel a diagnostic test run
                apiInstance.CancelDiagnosticJob(id, job);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CancelDiagnosticJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 
 **job** | [**JobUpdate**](JobUpdate.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createclusrunjob"></a>
# **CreateClusrunJob**
> Job CreateClusrunJob (Job job)

Create a clusrun

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class CreateClusrunJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var job = new Job(); // Job |  (optional) 

            try
            {
                // Create a clusrun
                Job result = apiInstance.CreateClusrunJob(job);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateClusrunJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job** | [**Job**](Job.md)|  | [optional] 

### Return type

[**Job**](Job.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="creatediagnosticjob"></a>
# **CreateDiagnosticJob**
> Job CreateDiagnosticJob (Job job)

Create a diagnostic test run

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class CreateDiagnosticJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var job = new Job(); // Job |  (optional) 

            try
            {
                // Create a diagnostic test run
                Job result = apiInstance.CreateDiagnosticJob(job);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateDiagnosticJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job** | [**Job**](Job.md)|  | [optional] 

### Return type

[**Job**](Job.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusrunjobsummary"></a>
# **GetClusRunJobSummary**
> JobSummary GetClusRunJobSummary ()

Get summary of ClusRun jobs

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetClusRunJobSummaryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                // Get summary of ClusRun jobs
                JobSummary result = apiInstance.GetClusRunJobSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClusRunJobSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**JobSummary**](JobSummary.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusrunjob"></a>
# **GetClusrunJob**
> Job GetClusrunJob (int? id)

Get a clusrun

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetClusrunJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id

            try
            {
                // Get a clusrun
                Job result = apiInstance.GetClusrunJob(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClusrunJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 

### Return type

[**Job**](Job.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusrunjobaggregationresult"></a>
# **GetClusrunJobAggregationResult**
> Object GetClusrunJobAggregationResult (int? id)

Get aggregation result of a clusrun job

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetClusrunJobAggregationResultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id

            try
            {
                // Get aggregation result of a clusrun job
                Object result = apiInstance.GetClusrunJobAggregationResult(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClusrunJobAggregationResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 

### Return type

**Object**

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusrunjobs"></a>
# **GetClusrunJobs**
> List<Job> GetClusrunJobs (int? lastId, int? count, bool? reverse)

Get a list of clusruns

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetClusrunJobsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var lastId = 56;  // int? | The object id since which(but not included) the objects are requested (optional) 
            var count = 56;  // int? | Requested number of objects (optional)  (default to 1000)
            var reverse = true;  // bool? | Get the results in reverse order (optional)  (default to false)

            try
            {
                // Get a list of clusruns
                List&lt;Job&gt; result = apiInstance.GetClusrunJobs(lastId, count, reverse);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClusrunJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastId** | **int?**| The object id since which(but not included) the objects are requested | [optional] 
 **count** | **int?**| Requested number of objects | [optional] [default to 1000]
 **reverse** | **bool?**| Get the results in reverse order | [optional] [default to false]

### Return type

[**List<Job>**](Job.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusrunoutput"></a>
# **GetClusrunOutput**
> System.IO.Stream GetClusrunOutput (string key)

Get the whole output of a task

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetClusrunOutputExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var key = key_example;  // string | Result key of a task

            try
            {
                // Get the whole output of a task
                System.IO.Stream result = apiInstance.GetClusrunOutput(key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClusrunOutput: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Result key of a task | 

### Return type

**System.IO.Stream**

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusrunoutputinpage"></a>
# **GetClusrunOutputInPage**
> TaskOutput GetClusrunOutputInPage (string key, int? offset, int? pageSize)

Get partial output of a task

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetClusrunOutputInPageExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var key = key_example;  // string | Result key of a task
            var offset = 56;  // int? | The distance from the beginning of the output (optional) 
            var pageSize = 56;  // int? | The size of requested piece of output (optional) 

            try
            {
                // Get partial output of a task
                TaskOutput result = apiInstance.GetClusrunOutputInPage(key, offset, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClusrunOutputInPage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| Result key of a task | 
 **offset** | **int?**| The distance from the beginning of the output | [optional] 
 **pageSize** | **int?**| The size of requested piece of output | [optional] 

### Return type

[**TaskOutput**](TaskOutput.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusruntask"></a>
# **GetClusrunTask**
> Task GetClusrunTask (int? id, int? taskId)

Get a task of a clusrun

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetClusrunTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id
            var taskId = 56;  // int? | Task id

            try
            {
                // Get a task of a clusrun
                Task result = apiInstance.GetClusrunTask(id, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClusrunTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 
 **taskId** | **int?**| Task id | 

### Return type

[**Task**](Task.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusruntaskresult"></a>
# **GetClusrunTaskResult**
> TaskResult GetClusrunTaskResult (int? id, int? taskId)

Get a task result of a clusrun

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetClusrunTaskResultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id
            var taskId = 56;  // int? | Task id

            try
            {
                // Get a task result of a clusrun
                TaskResult result = apiInstance.GetClusrunTaskResult(id, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClusrunTaskResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 
 **taskId** | **int?**| Task id | 

### Return type

[**TaskResult**](TaskResult.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getclusruntasks"></a>
# **GetClusrunTasks**
> List<Task> GetClusrunTasks (int? id, int? lastId, int? count, int? requeueCount)

Get tasks of a clusrun

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetClusrunTasksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id
            var lastId = 56;  // int? | The object id since which(but not included) the objects are requested (optional) 
            var count = 56;  // int? | Requested number of objects (optional)  (default to 1000)
            var requeueCount = 56;  // int? | The number of times a job/task is requeued (optional) 

            try
            {
                // Get tasks of a clusrun
                List&lt;Task&gt; result = apiInstance.GetClusrunTasks(id, lastId, count, requeueCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClusrunTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 
 **lastId** | **int?**| The object id since which(but not included) the objects are requested | [optional] 
 **count** | **int?**| Requested number of objects | [optional] [default to 1000]
 **requeueCount** | **int?**| The number of times a job/task is requeued | [optional] 

### Return type

[**List<Task>**](Task.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiagnosticjob"></a>
# **GetDiagnosticJob**
> Job GetDiagnosticJob (int? id)

Get a diagnostic test run

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetDiagnosticJobExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id

            try
            {
                // Get a diagnostic test run
                Job result = apiInstance.GetDiagnosticJob(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDiagnosticJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 

### Return type

[**Job**](Job.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiagnosticjobaggregationresult"></a>
# **GetDiagnosticJobAggregationResult**
> Object GetDiagnosticJobAggregationResult (int? id)

Get aggregation result of a diagnostic job

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetDiagnosticJobAggregationResultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id

            try
            {
                // Get aggregation result of a diagnostic job
                Object result = apiInstance.GetDiagnosticJobAggregationResult(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDiagnosticJobAggregationResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 

### Return type

**Object**

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiagnosticjobsummary"></a>
# **GetDiagnosticJobSummary**
> JobSummary GetDiagnosticJobSummary ()

Get summary of diagnostic jobs

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetDiagnosticJobSummaryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                // Get summary of diagnostic jobs
                JobSummary result = apiInstance.GetDiagnosticJobSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDiagnosticJobSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**JobSummary**](JobSummary.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiagnosticjobs"></a>
# **GetDiagnosticJobs**
> List<Job> GetDiagnosticJobs (int? lastId, int? count, bool? reverse)

Get a list of diagnostic test runs

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetDiagnosticJobsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var lastId = 56;  // int? | The object id since which(but not included) the objects are requested (optional) 
            var count = 56;  // int? | Requested number of objects (optional)  (default to 1000)
            var reverse = true;  // bool? | Get the results in reverse order (optional)  (default to false)

            try
            {
                // Get a list of diagnostic test runs
                List&lt;Job&gt; result = apiInstance.GetDiagnosticJobs(lastId, count, reverse);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDiagnosticJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastId** | **int?**| The object id since which(but not included) the objects are requested | [optional] 
 **count** | **int?**| Requested number of objects | [optional] [default to 1000]
 **reverse** | **bool?**| Get the results in reverse order | [optional] [default to false]

### Return type

[**List<Job>**](Job.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiagnostictask"></a>
# **GetDiagnosticTask**
> Task GetDiagnosticTask (int? id, int? taskId)

Get a task of a diagnostic test run

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetDiagnosticTaskExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id
            var taskId = 56;  // int? | Task id

            try
            {
                // Get a task of a diagnostic test run
                Task result = apiInstance.GetDiagnosticTask(id, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDiagnosticTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 
 **taskId** | **int?**| Task id | 

### Return type

[**Task**](Task.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiagnostictaskresult"></a>
# **GetDiagnosticTaskResult**
> TaskResult GetDiagnosticTaskResult (int? id, int? taskId)

Get a task result of a diagnostic test run

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetDiagnosticTaskResultExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id
            var taskId = 56;  // int? | Task id

            try
            {
                // Get a task result of a diagnostic test run
                TaskResult result = apiInstance.GetDiagnosticTaskResult(id, taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDiagnosticTaskResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 
 **taskId** | **int?**| Task id | 

### Return type

[**TaskResult**](TaskResult.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiagnostictasks"></a>
# **GetDiagnosticTasks**
> List<Task> GetDiagnosticTasks (int? id, int? lastId, int? count, int? requeueCount)

Get tasks of a diagnostic test run

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetDiagnosticTasksExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Job id
            var lastId = 56;  // int? | The object id since which(but not included) the objects are requested (optional) 
            var count = 56;  // int? | Requested number of objects (optional)  (default to 1000)
            var requeueCount = 56;  // int? | The number of times a job/task is requeued (optional) 

            try
            {
                // Get tasks of a diagnostic test run
                List&lt;Task&gt; result = apiInstance.GetDiagnosticTasks(id, lastId, count, requeueCount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDiagnosticTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Job id | 
 **lastId** | **int?**| The object id since which(but not included) the objects are requested | [optional] 
 **count** | **int?**| Requested number of objects | [optional] [default to 1000]
 **requeueCount** | **int?**| The number of times a job/task is requeued | [optional] 

### Return type

[**List<Task>**](Task.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdiagnostictests"></a>
# **GetDiagnosticTests**
> List<DiagnoticTest> GetDiagnosticTests ()

Get available diagnostic tests

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetDiagnosticTestsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                // Get available diagnostic tests
                List&lt;DiagnoticTest&gt; result = apiInstance.GetDiagnosticTests();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetDiagnosticTests: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DiagnoticTest>**](DiagnoticTest.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetriccategories"></a>
# **GetMetricCategories**
> List<string> GetMetricCategories ()

Get node metric categories

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetMetricCategoriesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                // Get node metric categories
                List&lt;string&gt; result = apiInstance.GetMetricCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMetricCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmetricsofcategory"></a>
# **GetMetricsOfCategory**
> Metrics GetMetricsOfCategory (string category, string lastNodeId, int? count)

Get node merics in a category

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetMetricsOfCategoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var category = category_example;  // string | 
            var lastNodeId = lastNodeId_example;  // string |  (optional) 
            var count = 56;  // int? | Requested number of objects (optional)  (default to 1000)

            try
            {
                // Get node merics in a category
                Metrics result = apiInstance.GetMetricsOfCategory(category, lastNodeId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetMetricsOfCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | **string**|  | 
 **lastNodeId** | **string**|  | [optional] 
 **count** | **int?**| Requested number of objects | [optional] [default to 1000]

### Return type

[**Metrics**](Metrics.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnode"></a>
# **GetNode**
> Node GetNode (string id)

Get a node

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetNodeExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | Node id

            try
            {
                // Get a node
                Node result = apiInstance.GetNode(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Node id | 

### Return type

[**Node**](Node.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodeevents"></a>
# **GetNodeEvents**
> List<Event> GetNodeEvents (string id)

Get events of a node

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetNodeEventsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | Node id

            try
            {
                // Get events of a node
                List&lt;Event&gt; result = apiInstance.GetNodeEvents(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNodeEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Node id | 

### Return type

[**List<Event>**](Event.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodejobs"></a>
# **GetNodeJobs**
> List<NodeJob> GetNodeJobs (string id)

Get jobs of a node

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetNodeJobsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | Node id

            try
            {
                // Get jobs of a node
                List&lt;NodeJob&gt; result = apiInstance.GetNodeJobs(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNodeJobs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Node id | 

### Return type

[**List<NodeJob>**](NodeJob.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodemetadata"></a>
# **GetNodeMetadata**
> NodeMetadata GetNodeMetadata (string id)

get metadata of a node

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetNodeMetadataExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | Node id

            try
            {
                // get metadata of a node
                NodeMetadata result = apiInstance.GetNodeMetadata(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNodeMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Node id | 

### Return type

[**NodeMetadata**](NodeMetadata.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodemetrichistory"></a>
# **GetNodeMetricHistory**
> NodeMetrics GetNodeMetricHistory (string id)

Get metric history of a node

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetNodeMetricHistoryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | Node id

            try
            {
                // Get metric history of a node
                NodeMetrics result = apiInstance.GetNodeMetricHistory(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNodeMetricHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Node id | 

### Return type

[**NodeMetrics**](NodeMetrics.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodescheduledevents"></a>
# **GetNodeScheduledEvents**
> ScheduledEvents GetNodeScheduledEvents (string id)

get scheduled events of a node

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetNodeScheduledEventsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | Node id

            try
            {
                // get scheduled events of a node
                ScheduledEvents result = apiInstance.GetNodeScheduledEvents(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNodeScheduledEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Node id | 

### Return type

[**ScheduledEvents**](ScheduledEvents.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodesummary"></a>
# **GetNodeSummary**
> NodeSummary GetNodeSummary ()

Get summary of nodes

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetNodeSummaryExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                // Get summary of nodes
                NodeSummary result = apiInstance.GetNodeSummary();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNodeSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NodeSummary**](NodeSummary.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnodes"></a>
# **GetNodes**
> List<Node> GetNodes (int? lastId, int? count)

Get a list of nodes

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class GetNodesExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();
            var lastId = 56;  // int? | The object id since which(but not included) the objects are requested (optional) 
            var count = 56;  // int? | Requested number of objects (optional)  (default to 1000)

            try
            {
                // Get a list of nodes
                List&lt;Node&gt; result = apiInstance.GetNodes(lastId, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lastId** | **int?**| The object id since which(but not included) the objects are requested | [optional] 
 **count** | **int?**| Requested number of objects | [optional] [default to 1000]

### Return type

[**List<Node>**](Node.md)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syncscripts"></a>
# **SyncScripts**
> void SyncScripts ()

Sync diagnostic and metric scripts from GitHub

### Example
```csharp
using System;
using System.Diagnostics;
using HPC.ACM.Api;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace Example
{
    public class SyncScriptsExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: aad
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DefaultApi();

            try
            {
                // Sync diagnostic and metric scripts from GitHub
                apiInstance.SyncScripts();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.SyncScripts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[aad](../README.md#aad)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

