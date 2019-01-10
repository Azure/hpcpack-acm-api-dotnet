# HPC.ACM.Model.Job
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **JobType** |  | [optional] 
**Id** | **int?** | job id | [optional] 
**Name** | **string** | job name give by user | [optional] 
**CommandLine** | **string** | Available only for ClusRun job | [optional] 
**DiagnosticTest** | [**DiagnoticTest**](DiagnoticTest.md) | Available only for Diagnostics job | [optional] 
**State** | **JobState** |  | [optional] 
**TargetNodes** | **List&lt;string&gt;** | Nodes on which the job runs | [optional] 
**Progress** | **int?** | Job progress | [optional] 
**Events** | [**List&lt;Event&gt;**](Event.md) | Events happened in the job | [optional] 
**RequeueCount** | **int?** | The number of times the job is requeued | [optional] 
**FailJobOnTaskFailure** | **bool?** |  | [optional] 
**CreatedAt** | **DateTime?** |  | [optional] 
**UpdatedAt** | **DateTime?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

