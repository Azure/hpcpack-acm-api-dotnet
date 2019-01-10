# HPC.ACM.Model.ScheduledEvent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | **string** | Globally unique identifier for this event | [optional] 
**EventType** | **string** | Impact this event causes | [optional] 
**ResourceType** | **string** | Type of resource this event impacts | [optional] 
**Resources** | **List&lt;string&gt;** | List of resources this event impacts. This is guaranteed to contain machines from at most one Update Domain, but may not contain all machines in the UD. | [optional] 
**EventStatus** | **string** | No Completed or similar status is ever provided; the event will no longer be returned when the event is completed. | [optional] 
**NotBefore** | **DateTime?** | Time after which this event may start | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

