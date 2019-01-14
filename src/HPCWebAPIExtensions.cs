// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HPC.ACM.API
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HPCWebAPI.
    /// </summary>
    public static partial class HPCWebAPIExtensions
    {
            /// <summary>
            /// Get a list of nodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Node> GetNodes(this IHPCWebAPI operations)
            {
                return operations.GetNodesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of nodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Node>> GetNodesAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNodesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Node GetNode(this IHPCWebAPI operations)
            {
                return operations.GetNodeAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Node> GetNodeAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNodeWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// get metadata of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static NodeMetadata GetNodeMetadata(this IHPCWebAPI operations)
            {
                return operations.GetNodeMetadataAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// get metadata of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeMetadata> GetNodeMetadataAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNodeMetadataWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// get scheduled events of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ScheduledEvents GetNodeScheduledEvents(this IHPCWebAPI operations)
            {
                return operations.GetNodeScheduledEventsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// get scheduled events of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ScheduledEvents> GetNodeScheduledEventsAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNodeScheduledEventsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get events of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<EventModel> GetNodeEvents(this IHPCWebAPI operations)
            {
                return operations.GetNodeEventsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get events of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<EventModel>> GetNodeEventsAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNodeEventsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get jobs of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<NodeJob> GetNodeJobs(this IHPCWebAPI operations)
            {
                return operations.GetNodeJobsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get jobs of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<NodeJob>> GetNodeJobsAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNodeJobsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get metric history of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static NodeMetrics GetNodeMetricHistory(this IHPCWebAPI operations)
            {
                return operations.GetNodeMetricHistoryAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get metric history of a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeMetrics> GetNodeMetricHistoryAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNodeMetricHistoryWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get node metric categories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> GetMetricCategories(this IHPCWebAPI operations)
            {
                return operations.GetMetricCategoriesAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get node metric categories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetMetricCategoriesAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMetricCategoriesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get node merics in a category
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='category'>
            /// </param>
            /// <param name='lastNodeId'>
            /// </param>
            public static Metrics GetMetricsOfCategory(this IHPCWebAPI operations, string category, string lastNodeId = default(string))
            {
                return operations.GetMetricsOfCategoryAsync(category, lastNodeId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get node merics in a category
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='category'>
            /// </param>
            /// <param name='lastNodeId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Metrics> GetMetricsOfCategoryAsync(this IHPCWebAPI operations, string category, string lastNodeId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMetricsOfCategoryWithHttpMessagesAsync(category, lastNodeId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of clusruns
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Job> GetClusrunJobs(this IHPCWebAPI operations)
            {
                return operations.GetClusrunJobsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of clusruns
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Job>> GetClusrunJobsAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClusrunJobsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// </param>
            public static Job CreateClusrunJob(this IHPCWebAPI operations, Job job = default(Job))
            {
                return operations.CreateClusrunJobAsync(job).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> CreateClusrunJobAsync(this IHPCWebAPI operations, Job job = default(Job), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateClusrunJobWithHttpMessagesAsync(job, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Job GetClusrunJob(this IHPCWebAPI operations)
            {
                return operations.GetClusrunJobAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> GetClusrunJobAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClusrunJobWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// </param>
            public static void CancelClusrunJob(this IHPCWebAPI operations, JobUpdate job = default(JobUpdate))
            {
                operations.CancelClusrunJobAsync(job).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task CancelClusrunJobAsync(this IHPCWebAPI operations, JobUpdate job = default(JobUpdate), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelClusrunJobWithHttpMessagesAsync(job, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get aggregation result of a clusrun job
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object GetClusrunJobAggregationResult(this IHPCWebAPI operations)
            {
                return operations.GetClusrunJobAggregationResultAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get aggregation result of a clusrun job
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetClusrunJobAggregationResultAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClusrunJobAggregationResultWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get tasks of a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Models.Task> GetClusrunTasks(this IHPCWebAPI operations)
            {
                return operations.GetClusrunTasksAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get tasks of a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Models.Task>> GetClusrunTasksAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClusrunTasksWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a task of a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Models.Task GetClusrunTask(this IHPCWebAPI operations)
            {
                return operations.GetClusrunTaskAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a task of a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Models.Task> GetClusrunTaskAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClusrunTaskWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a task result of a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static TaskResult GetClusrunTaskResult(this IHPCWebAPI operations)
            {
                return operations.GetClusrunTaskResultAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a task result of a clusrun
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskResult> GetClusrunTaskResultAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClusrunTaskResultWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the whole output of a task
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Stream GetClusrunOutput(this IHPCWebAPI operations)
            {
                return operations.GetClusrunOutputAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the whole output of a task
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetClusrunOutputAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetClusrunOutputWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Get partial output of a task
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='offset'>
            /// The distance from the beginning of the output
            /// </param>
            /// <param name='pageSize'>
            /// The size of requested piece of output
            /// </param>
            public static TaskOutput GetClusrunOutputInPage(this IHPCWebAPI operations, int? offset = default(int?), int? pageSize = default(int?))
            {
                return operations.GetClusrunOutputInPageAsync(offset, pageSize).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get partial output of a task
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='offset'>
            /// The distance from the beginning of the output
            /// </param>
            /// <param name='pageSize'>
            /// The size of requested piece of output
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskOutput> GetClusrunOutputInPageAsync(this IHPCWebAPI operations, int? offset = default(int?), int? pageSize = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClusrunOutputInPageWithHttpMessagesAsync(offset, pageSize, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of diagnostic test runs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Job> GetDiagnosticJobs(this IHPCWebAPI operations)
            {
                return operations.GetDiagnosticJobsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of diagnostic test runs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Job>> GetDiagnosticJobsAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDiagnosticJobsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// </param>
            public static Job CreateDiagnosticJob(this IHPCWebAPI operations, Job job = default(Job))
            {
                return operations.CreateDiagnosticJobAsync(job).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> CreateDiagnosticJobAsync(this IHPCWebAPI operations, Job job = default(Job), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateDiagnosticJobWithHttpMessagesAsync(job, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Job GetDiagnosticJob(this IHPCWebAPI operations)
            {
                return operations.GetDiagnosticJobAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Job> GetDiagnosticJobAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDiagnosticJobWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancel a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// </param>
            public static void CancelDiagnosticJob(this IHPCWebAPI operations, JobUpdate job = default(JobUpdate))
            {
                operations.CancelDiagnosticJobAsync(job).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancel a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='job'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task CancelDiagnosticJobAsync(this IHPCWebAPI operations, JobUpdate job = default(JobUpdate), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CancelDiagnosticJobWithHttpMessagesAsync(job, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get aggregation result of a diagnostic job
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object GetDiagnosticJobAggregationResult(this IHPCWebAPI operations)
            {
                return operations.GetDiagnosticJobAggregationResultAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get aggregation result of a diagnostic job
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetDiagnosticJobAggregationResultAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDiagnosticJobAggregationResultWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get tasks of a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Models.Task> GetDiagnosticTasks(this IHPCWebAPI operations)
            {
                return operations.GetDiagnosticTasksAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get tasks of a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Models.Task>> GetDiagnosticTasksAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDiagnosticTasksWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a task of a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Models.Task GetDiagnosticTask(this IHPCWebAPI operations)
            {
                return operations.GetDiagnosticTaskAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a task of a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Models.Task> GetDiagnosticTaskAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDiagnosticTaskWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a task result of a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static TaskResult GetDiagnosticTaskResult(this IHPCWebAPI operations)
            {
                return operations.GetDiagnosticTaskResultAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a task result of a diagnostic test run
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskResult> GetDiagnosticTaskResultAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDiagnosticTaskResultWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get available diagnostic tests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<DiagnoticTest> GetDiagnosticTests(this IHPCWebAPI operations)
            {
                return operations.GetDiagnosticTestsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get available diagnostic tests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DiagnoticTest>> GetDiagnosticTestsAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDiagnosticTestsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get summary of nodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static NodeSummary GetNodeSummary(this IHPCWebAPI operations)
            {
                return operations.GetNodeSummaryAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get summary of nodes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NodeSummary> GetNodeSummaryAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNodeSummaryWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get summary of ClusRun jobs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static JobSummary GetClusRunJobSummary(this IHPCWebAPI operations)
            {
                return operations.GetClusRunJobSummaryAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get summary of ClusRun jobs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobSummary> GetClusRunJobSummaryAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClusRunJobSummaryWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get summary of diagnostic jobs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static JobSummary GetDiagnosticJobSummary(this IHPCWebAPI operations)
            {
                return operations.GetDiagnosticJobSummaryAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get summary of diagnostic jobs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobSummary> GetDiagnosticJobSummaryAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDiagnosticJobSummaryWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sync diagnostic and metric scripts from GitHub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void SyncScripts(this IHPCWebAPI operations)
            {
                operations.SyncScriptsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sync diagnostic and metric scripts from GitHub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task SyncScriptsAsync(this IHPCWebAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SyncScriptsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}