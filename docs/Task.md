# HPC.ACM.Model.Task
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | task id | [optional] 
**JobId** | **int?** | Id of the job the task belongs to | [optional] 
**JobType** | **JobType** | Type of the job the task belongs to | [optional] 
**State** | **TaskState** | Task state | [optional] 
**CommandLine** | **string** | Available only when task&#39;s job type is ClusRun | [optional] 
**Node** | **string** | The node on which the task runs | [optional] 
**ParentIds** | **List&lt;int?&gt;** |  | [optional] 
**ChildIds** | **List&lt;int?&gt;** |  | [optional] 
**RemainingParentIds** | **List&lt;int?&gt;** |  | [optional] 
**CustomizedData** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

