using System;
using System.Collections.Generic;
using RestSharp;
using HPC.ACM.Client;
using HPC.ACM.Model;

namespace HPC.ACM.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        /// <summary>
        /// Cancel a clusrun 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <param name="job"></param>
        /// <returns></returns>
        void CancelClusrunJob (int? id, JobUpdate job);
        /// <summary>
        /// Cancel a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <param name="job"></param>
        /// <returns></returns>
        void CancelDiagnosticJob (int? id, JobUpdate job);
        /// <summary>
        /// Create a clusrun 
        /// </summary>
        /// <param name="job"></param>
        /// <returns>Job</returns>
        Job CreateClusrunJob (Job job);
        /// <summary>
        /// Create a diagnostic test run 
        /// </summary>
        /// <param name="job"></param>
        /// <returns>Job</returns>
        Job CreateDiagnosticJob (Job job);
        /// <summary>
        /// Get summary of ClusRun jobs 
        /// </summary>
        /// <returns>JobSummary</returns>
        JobSummary GetClusRunJobSummary ();
        /// <summary>
        /// Get a clusrun 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <returns>Job</returns>
        Job GetClusrunJob (int? id);
        /// <summary>
        /// Get aggregation result of a clusrun job 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <returns>Object</returns>
        Object GetClusrunJobAggregationResult (int? id);
        /// <summary>
        /// Get a list of clusruns 
        /// </summary>
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param>
        /// <param name="count">Requested number of objects</param>
        /// <param name="reverse">Get the results in reverse order</param>
        /// <returns>List&lt;Job&gt;</returns>
        List<Job> GetClusrunJobs (int? lastId, int? count, bool? reverse);
        /// <summary>
        /// Get the whole output of a task 
        /// </summary>
        /// <param name="key">Result key of a task</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetClusrunOutput (string key);
        /// <summary>
        /// Get partial output of a task 
        /// </summary>
        /// <param name="key">Result key of a task</param>
        /// <param name="offset">The distance from the beginning of the output</param>
        /// <param name="pageSize">The size of requested piece of output</param>
        /// <returns>TaskOutput</returns>
        TaskOutput GetClusrunOutputInPage (string key, int? offset, int? pageSize);
        /// <summary>
        /// Get a task of a clusrun 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>Task</returns>
        Task GetClusrunTask (int? id, int? taskId);
        /// <summary>
        /// Get a task result of a clusrun 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>TaskResult</returns>
        TaskResult GetClusrunTaskResult (int? id, int? taskId);
        /// <summary>
        /// Get tasks of a clusrun 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param>
        /// <param name="count">Requested number of objects</param>
        /// <param name="requeueCount">The number of times a job/task is requeued</param>
        /// <returns>List&lt;Task&gt;</returns>
        List<Task> GetClusrunTasks (int? id, int? lastId, int? count, int? requeueCount);
        /// <summary>
        /// Get a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <returns>Job</returns>
        Job GetDiagnosticJob (int? id);
        /// <summary>
        /// Get aggregation result of a diagnostic job 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <returns>Object</returns>
        Object GetDiagnosticJobAggregationResult (int? id);
        /// <summary>
        /// Get summary of diagnostic jobs 
        /// </summary>
        /// <returns>JobSummary</returns>
        JobSummary GetDiagnosticJobSummary ();
        /// <summary>
        /// Get a list of diagnostic test runs 
        /// </summary>
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param>
        /// <param name="count">Requested number of objects</param>
        /// <param name="reverse">Get the results in reverse order</param>
        /// <returns>List&lt;Job&gt;</returns>
        List<Job> GetDiagnosticJobs (int? lastId, int? count, bool? reverse);
        /// <summary>
        /// Get a task of a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>Task</returns>
        Task GetDiagnosticTask (int? id, int? taskId);
        /// <summary>
        /// Get a task result of a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <param name="taskId">Task id</param>
        /// <returns>TaskResult</returns>
        TaskResult GetDiagnosticTaskResult (int? id, int? taskId);
        /// <summary>
        /// Get tasks of a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param>
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param>
        /// <param name="count">Requested number of objects</param>
        /// <param name="requeueCount">The number of times a job/task is requeued</param>
        /// <returns>List&lt;Task&gt;</returns>
        List<Task> GetDiagnosticTasks (int? id, int? lastId, int? count, int? requeueCount);
        /// <summary>
        /// Get available diagnostic tests 
        /// </summary>
        /// <returns>List&lt;DiagnoticTest&gt;</returns>
        List<DiagnoticTest> GetDiagnosticTests ();
        /// <summary>
        /// Get node metric categories 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> GetMetricCategories ();
        /// <summary>
        /// Get node merics in a category 
        /// </summary>
        /// <param name="category"></param>
        /// <param name="lastNodeId"></param>
        /// <param name="count">Requested number of objects</param>
        /// <returns>Metrics</returns>
        Metrics GetMetricsOfCategory (string category, string lastNodeId, int? count);
        /// <summary>
        /// Get a node 
        /// </summary>
        /// <param name="id">Node id</param>
        /// <returns>Node</returns>
        Node GetNode (string id);
        /// <summary>
        /// Get events of a node 
        /// </summary>
        /// <param name="id">Node id</param>
        /// <returns>List&lt;Event&gt;</returns>
        List<Event> GetNodeEvents (string id);
        /// <summary>
        /// Get jobs of a node 
        /// </summary>
        /// <param name="id">Node id</param>
        /// <returns>List&lt;NodeJob&gt;</returns>
        List<NodeJob> GetNodeJobs (string id);
        /// <summary>
        /// get metadata of a node 
        /// </summary>
        /// <param name="id">Node id</param>
        /// <returns>NodeMetadata</returns>
        NodeMetadata GetNodeMetadata (string id);
        /// <summary>
        /// Get metric history of a node 
        /// </summary>
        /// <param name="id">Node id</param>
        /// <returns>NodeMetrics</returns>
        NodeMetrics GetNodeMetricHistory (string id);
        /// <summary>
        /// get scheduled events of a node 
        /// </summary>
        /// <param name="id">Node id</param>
        /// <returns>ScheduledEvents</returns>
        ScheduledEvents GetNodeScheduledEvents (string id);
        /// <summary>
        /// Get summary of nodes 
        /// </summary>
        /// <returns>NodeSummary</returns>
        NodeSummary GetNodeSummary ();
        /// <summary>
        /// Get a list of nodes 
        /// </summary>
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param>
        /// <param name="count">Requested number of objects</param>
        /// <returns>List&lt;Node&gt;</returns>
        List<Node> GetNodes (int? lastId, int? count);
        /// <summary>
        /// Sync diagnostic and metric scripts from GitHub 
        /// </summary>
        /// <returns></returns>
        void SyncScripts ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Cancel a clusrun 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <param name="job"></param> 
        /// <returns></returns>            
        public void CancelClusrunJob (int? id, JobUpdate job)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelClusrunJob");
            
    
            var path = "/clusrun/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(job); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CancelClusrunJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CancelClusrunJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Cancel a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <param name="job"></param> 
        /// <returns></returns>            
        public void CancelDiagnosticJob (int? id, JobUpdate job)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CancelDiagnosticJob");
            
    
            var path = "/diagnostics/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(job); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CancelDiagnosticJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CancelDiagnosticJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create a clusrun 
        /// </summary>
        /// <param name="job"></param> 
        /// <returns>Job</returns>            
        public Job CreateClusrunJob (Job job)
        {
            
    
            var path = "/clusrun";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(job); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateClusrunJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateClusrunJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Job) ApiClient.Deserialize(response.Content, typeof(Job), response.Headers);
        }
    
        /// <summary>
        /// Create a diagnostic test run 
        /// </summary>
        /// <param name="job"></param> 
        /// <returns>Job</returns>            
        public Job CreateDiagnosticJob (Job job)
        {
            
    
            var path = "/diagnostics";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(job); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDiagnosticJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateDiagnosticJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Job) ApiClient.Deserialize(response.Content, typeof(Job), response.Headers);
        }
    
        /// <summary>
        /// Get summary of ClusRun jobs 
        /// </summary>
        /// <returns>JobSummary</returns>            
        public JobSummary GetClusRunJobSummary ()
        {
            
    
            var path = "/dashboard/clusrun";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusRunJobSummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusRunJobSummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JobSummary) ApiClient.Deserialize(response.Content, typeof(JobSummary), response.Headers);
        }
    
        /// <summary>
        /// Get a clusrun 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <returns>Job</returns>            
        public Job GetClusrunJob (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClusrunJob");
            
    
            var path = "/clusrun/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Job) ApiClient.Deserialize(response.Content, typeof(Job), response.Headers);
        }
    
        /// <summary>
        /// Get aggregation result of a clusrun job 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <returns>Object</returns>            
        public Object GetClusrunJobAggregationResult (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClusrunJobAggregationResult");
            
    
            var path = "/clusrun/{id}/aggregationResult";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunJobAggregationResult: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunJobAggregationResult: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Get a list of clusruns 
        /// </summary>
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param> 
        /// <param name="count">Requested number of objects</param> 
        /// <param name="reverse">Get the results in reverse order</param> 
        /// <returns>List&lt;Job&gt;</returns>            
        public List<Job> GetClusrunJobs (int? lastId, int? count, bool? reverse)
        {
            
    
            var path = "/clusrun";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lastId != null) queryParams.Add("lastId", ApiClient.ParameterToString(lastId)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (reverse != null) queryParams.Add("reverse", ApiClient.ParameterToString(reverse)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunJobs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunJobs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Job>) ApiClient.Deserialize(response.Content, typeof(List<Job>), response.Headers);
        }
    
        /// <summary>
        /// Get the whole output of a task 
        /// </summary>
        /// <param name="key">Result key of a task</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream GetClusrunOutput (string key)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetClusrunOutput");
            
    
            var path = "/output/clusrun/{key}/raw";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunOutput: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunOutput: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Get partial output of a task 
        /// </summary>
        /// <param name="key">Result key of a task</param> 
        /// <param name="offset">The distance from the beginning of the output</param> 
        /// <param name="pageSize">The size of requested piece of output</param> 
        /// <returns>TaskOutput</returns>            
        public TaskOutput GetClusrunOutputInPage (string key, int? offset, int? pageSize)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetClusrunOutputInPage");
            
    
            var path = "/output/clusrun/{key}/page";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key" + "}", ApiClient.ParameterToString(key));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunOutputInPage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunOutputInPage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TaskOutput) ApiClient.Deserialize(response.Content, typeof(TaskOutput), response.Headers);
        }
    
        /// <summary>
        /// Get a task of a clusrun 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <param name="taskId">Task id</param> 
        /// <returns>Task</returns>            
        public Task GetClusrunTask (int? id, int? taskId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClusrunTask");
            
            // verify the required parameter 'taskId' is set
            if (taskId == null) throw new ApiException(400, "Missing required parameter 'taskId' when calling GetClusrunTask");
            
    
            var path = "/clusrun/{id}/tasks/{taskId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "taskId" + "}", ApiClient.ParameterToString(taskId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunTask: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunTask: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Task) ApiClient.Deserialize(response.Content, typeof(Task), response.Headers);
        }
    
        /// <summary>
        /// Get a task result of a clusrun 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <param name="taskId">Task id</param> 
        /// <returns>TaskResult</returns>            
        public TaskResult GetClusrunTaskResult (int? id, int? taskId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClusrunTaskResult");
            
            // verify the required parameter 'taskId' is set
            if (taskId == null) throw new ApiException(400, "Missing required parameter 'taskId' when calling GetClusrunTaskResult");
            
    
            var path = "/clusrun/{id}/tasks/{taskId}/result";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "taskId" + "}", ApiClient.ParameterToString(taskId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunTaskResult: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunTaskResult: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TaskResult) ApiClient.Deserialize(response.Content, typeof(TaskResult), response.Headers);
        }
    
        /// <summary>
        /// Get tasks of a clusrun 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param> 
        /// <param name="count">Requested number of objects</param> 
        /// <param name="requeueCount">The number of times a job/task is requeued</param> 
        /// <returns>List&lt;Task&gt;</returns>            
        public List<Task> GetClusrunTasks (int? id, int? lastId, int? count, int? requeueCount)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClusrunTasks");
            
    
            var path = "/clusrun/{id}/tasks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lastId != null) queryParams.Add("lastId", ApiClient.ParameterToString(lastId)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (requeueCount != null) queryParams.Add("requeueCount", ApiClient.ParameterToString(requeueCount)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunTasks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClusrunTasks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Task>) ApiClient.Deserialize(response.Content, typeof(List<Task>), response.Headers);
        }
    
        /// <summary>
        /// Get a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <returns>Job</returns>            
        public Job GetDiagnosticJob (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDiagnosticJob");
            
    
            var path = "/diagnostics/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Job) ApiClient.Deserialize(response.Content, typeof(Job), response.Headers);
        }
    
        /// <summary>
        /// Get aggregation result of a diagnostic job 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <returns>Object</returns>            
        public Object GetDiagnosticJobAggregationResult (int? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDiagnosticJobAggregationResult");
            
    
            var path = "/diagnostics/{id}/aggregationResult";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticJobAggregationResult: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticJobAggregationResult: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Get summary of diagnostic jobs 
        /// </summary>
        /// <returns>JobSummary</returns>            
        public JobSummary GetDiagnosticJobSummary ()
        {
            
    
            var path = "/dashboard/diagnostics";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticJobSummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticJobSummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JobSummary) ApiClient.Deserialize(response.Content, typeof(JobSummary), response.Headers);
        }
    
        /// <summary>
        /// Get a list of diagnostic test runs 
        /// </summary>
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param> 
        /// <param name="count">Requested number of objects</param> 
        /// <param name="reverse">Get the results in reverse order</param> 
        /// <returns>List&lt;Job&gt;</returns>            
        public List<Job> GetDiagnosticJobs (int? lastId, int? count, bool? reverse)
        {
            
    
            var path = "/diagnostics";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lastId != null) queryParams.Add("lastId", ApiClient.ParameterToString(lastId)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (reverse != null) queryParams.Add("reverse", ApiClient.ParameterToString(reverse)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticJobs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticJobs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Job>) ApiClient.Deserialize(response.Content, typeof(List<Job>), response.Headers);
        }
    
        /// <summary>
        /// Get a task of a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <param name="taskId">Task id</param> 
        /// <returns>Task</returns>            
        public Task GetDiagnosticTask (int? id, int? taskId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDiagnosticTask");
            
            // verify the required parameter 'taskId' is set
            if (taskId == null) throw new ApiException(400, "Missing required parameter 'taskId' when calling GetDiagnosticTask");
            
    
            var path = "/diagnostics/{id}/tasks/{taskId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "taskId" + "}", ApiClient.ParameterToString(taskId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticTask: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticTask: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Task) ApiClient.Deserialize(response.Content, typeof(Task), response.Headers);
        }
    
        /// <summary>
        /// Get a task result of a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <param name="taskId">Task id</param> 
        /// <returns>TaskResult</returns>            
        public TaskResult GetDiagnosticTaskResult (int? id, int? taskId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDiagnosticTaskResult");
            
            // verify the required parameter 'taskId' is set
            if (taskId == null) throw new ApiException(400, "Missing required parameter 'taskId' when calling GetDiagnosticTaskResult");
            
    
            var path = "/diagnostics/{id}/tasks/{taskId}/result";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "taskId" + "}", ApiClient.ParameterToString(taskId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticTaskResult: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticTaskResult: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TaskResult) ApiClient.Deserialize(response.Content, typeof(TaskResult), response.Headers);
        }
    
        /// <summary>
        /// Get tasks of a diagnostic test run 
        /// </summary>
        /// <param name="id">Job id</param> 
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param> 
        /// <param name="count">Requested number of objects</param> 
        /// <param name="requeueCount">The number of times a job/task is requeued</param> 
        /// <returns>List&lt;Task&gt;</returns>            
        public List<Task> GetDiagnosticTasks (int? id, int? lastId, int? count, int? requeueCount)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDiagnosticTasks");
            
    
            var path = "/diagnostics/{id}/tasks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lastId != null) queryParams.Add("lastId", ApiClient.ParameterToString(lastId)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (requeueCount != null) queryParams.Add("requeueCount", ApiClient.ParameterToString(requeueCount)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticTasks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticTasks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Task>) ApiClient.Deserialize(response.Content, typeof(List<Task>), response.Headers);
        }
    
        /// <summary>
        /// Get available diagnostic tests 
        /// </summary>
        /// <returns>List&lt;DiagnoticTest&gt;</returns>            
        public List<DiagnoticTest> GetDiagnosticTests ()
        {
            
    
            var path = "/diagnostics/tests";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticTests: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDiagnosticTests: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiagnoticTest>) ApiClient.Deserialize(response.Content, typeof(List<DiagnoticTest>), response.Headers);
        }
    
        /// <summary>
        /// Get node metric categories 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> GetMetricCategories ()
        {
            
    
            var path = "/metrics/categories";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMetricCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMetricCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Get node merics in a category 
        /// </summary>
        /// <param name="category"></param> 
        /// <param name="lastNodeId"></param> 
        /// <param name="count">Requested number of objects</param> 
        /// <returns>Metrics</returns>            
        public Metrics GetMetricsOfCategory (string category, string lastNodeId, int? count)
        {
            
            // verify the required parameter 'category' is set
            if (category == null) throw new ApiException(400, "Missing required parameter 'category' when calling GetMetricsOfCategory");
            
    
            var path = "/metrics/{category}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "category" + "}", ApiClient.ParameterToString(category));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lastNodeId != null) queryParams.Add("lastNodeId", ApiClient.ParameterToString(lastNodeId)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMetricsOfCategory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMetricsOfCategory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Metrics) ApiClient.Deserialize(response.Content, typeof(Metrics), response.Headers);
        }
    
        /// <summary>
        /// Get a node 
        /// </summary>
        /// <param name="id">Node id</param> 
        /// <returns>Node</returns>            
        public Node GetNode (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetNode");
            
    
            var path = "/nodes/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Node) ApiClient.Deserialize(response.Content, typeof(Node), response.Headers);
        }
    
        /// <summary>
        /// Get events of a node 
        /// </summary>
        /// <param name="id">Node id</param> 
        /// <returns>List&lt;Event&gt;</returns>            
        public List<Event> GetNodeEvents (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetNodeEvents");
            
    
            var path = "/nodes/{id}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Event>) ApiClient.Deserialize(response.Content, typeof(List<Event>), response.Headers);
        }
    
        /// <summary>
        /// Get jobs of a node 
        /// </summary>
        /// <param name="id">Node id</param> 
        /// <returns>List&lt;NodeJob&gt;</returns>            
        public List<NodeJob> GetNodeJobs (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetNodeJobs");
            
    
            var path = "/nodes/{id}/jobs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeJobs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeJobs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NodeJob>) ApiClient.Deserialize(response.Content, typeof(List<NodeJob>), response.Headers);
        }
    
        /// <summary>
        /// get metadata of a node 
        /// </summary>
        /// <param name="id">Node id</param> 
        /// <returns>NodeMetadata</returns>            
        public NodeMetadata GetNodeMetadata (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetNodeMetadata");
            
    
            var path = "/nodes/{id}/metadata";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeMetadata: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeMetadata: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NodeMetadata) ApiClient.Deserialize(response.Content, typeof(NodeMetadata), response.Headers);
        }
    
        /// <summary>
        /// Get metric history of a node 
        /// </summary>
        /// <param name="id">Node id</param> 
        /// <returns>NodeMetrics</returns>            
        public NodeMetrics GetNodeMetricHistory (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetNodeMetricHistory");
            
    
            var path = "/nodes/{id}/metricHistory";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeMetricHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeMetricHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NodeMetrics) ApiClient.Deserialize(response.Content, typeof(NodeMetrics), response.Headers);
        }
    
        /// <summary>
        /// get scheduled events of a node 
        /// </summary>
        /// <param name="id">Node id</param> 
        /// <returns>ScheduledEvents</returns>            
        public ScheduledEvents GetNodeScheduledEvents (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetNodeScheduledEvents");
            
    
            var path = "/nodes/{id}/scheduledEvents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeScheduledEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeScheduledEvents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ScheduledEvents) ApiClient.Deserialize(response.Content, typeof(ScheduledEvents), response.Headers);
        }
    
        /// <summary>
        /// Get summary of nodes 
        /// </summary>
        /// <returns>NodeSummary</returns>            
        public NodeSummary GetNodeSummary ()
        {
            
    
            var path = "/dashboard/nodes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeSummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodeSummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NodeSummary) ApiClient.Deserialize(response.Content, typeof(NodeSummary), response.Headers);
        }
    
        /// <summary>
        /// Get a list of nodes 
        /// </summary>
        /// <param name="lastId">The object id since which(but not included) the objects are requested</param> 
        /// <param name="count">Requested number of objects</param> 
        /// <returns>List&lt;Node&gt;</returns>            
        public List<Node> GetNodes (int? lastId, int? count)
        {
            
    
            var path = "/nodes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lastId != null) queryParams.Add("lastId", ApiClient.ParameterToString(lastId)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNodes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Node>) ApiClient.Deserialize(response.Content, typeof(List<Node>), response.Headers);
        }
    
        /// <summary>
        /// Sync diagnostic and metric scripts from GitHub 
        /// </summary>
        /// <returns></returns>            
        public void SyncScripts ()
        {
            
    
            var path = "/sync";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "aad" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SyncScripts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SyncScripts: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
