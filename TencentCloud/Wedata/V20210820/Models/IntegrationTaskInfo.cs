/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntegrationTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Task Name
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Task Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Synchronization Type 1. Solution (Whole Database Migration), 2. Single Table Synchronization
        /// </summary>
        [JsonProperty("SyncType")]
        public long? SyncType{ get; set; }

        /// <summary>
        /// 201. Real-time, 202. Offline
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// Workflow ID of Task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Task IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task Scheduling ID (oceanus or us etc. Job ID), not a mandatory field
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ScheduleTaskId")]
        public string ScheduleTaskId{ get; set; }

        /// <summary>
        /// InLong Task ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskGroupId")]
        public string TaskGroupId{ get; set; }

        /// <summary>
        /// Project IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Creator UIN
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// Operator UIN
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OperatorUin")]
        public string OperatorUin{ get; set; }

        /// <summary>
        /// owner uin
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Application ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 1: not started | 2: In operation | 3: Running | 4: Suspension | 5: Task Stopping | 6: Stop | 7: Execution Failure | 20: Abnormal | 21: Unknown |
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Node list
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Nodes")]
        public IntegrationNodeInfo[] Nodes{ get; set; }

        /// <summary>
        /// Execution Resource ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExecutorId")]
        public string ExecutorId{ get; set; }

        /// <summary>
        /// Task configuration information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Config")]
        public RecordField[] Config{ get; set; }

        /// <summary>
        /// Task extension configuration information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExtConfig")]
        public RecordField[] ExtConfig{ get; set; }

        /// <summary>
        /// Task execution context information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExecuteContext")]
        public RecordField[] ExecuteContext{ get; set; }

        /// <summary>
        /// Node Mapping
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Mappings")]
        public IntegrationNodeMapping[] Mappings{ get; set; }

        /// <summary>
        /// Task configuration mode, 0: Canvas 1: Form 3: Script
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskMode")]
        public string TaskMode{ get; set; }

        /// <summary>
        /// Person in ChargeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Incharge")]
        public string Incharge{ get; set; }

        /// <summary>
        /// Offline new parameters
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OfflineTaskAddEntity")]
        public OfflineTaskAddParam OfflineTaskAddEntity{ get; set; }

        /// <summary>
        /// group name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// inlong manager url
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InLongManagerUrl")]
        public string InLongManagerUrl{ get; set; }

        /// <summary>
        /// stream id
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InLongStreamId")]
        public string InLongStreamId{ get; set; }

        /// <summary>
        /// version
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InLongManagerVersion")]
        public string InLongManagerVersion{ get; set; }

        /// <summary>
        /// inlong dataproxy url
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DataProxyUrl")]
        public string[] DataProxyUrl{ get; set; }

        /// <summary>
        /// Whether the task version has been submitted for operation and maintenance
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Submit")]
        public bool? Submit{ get; set; }

        /// <summary>
        /// Data Source Type: MYSQL|POSTGRE|ORACLE|SQLSERVER|FTP|HIVE|HDFS|ICEBERG|KAFKA|HBASE|SPARK|VIRTUAL|TBASE|DB2|DM|GAUSSDB|GBASE|IMPALA|ES|S3_DATAINSIGHT|GREENPLUM|PHOENIX|SAP_HANA|SFTP|OCEANBASE|CLICKHOUSE|KUDU|VERTICA|REDIS|COS|DLC|DLCV1|DORIS|CKAFKA|DTS_KAFKA|S3|CDW|LOCAL|TDSQLC|TDSQL|TDSQL_MYSQL|MONGODB|INFORMIX|SYBASE|REST_API|SuperSQL|PRESTO|DR_SUM|TiDB|StarRocks|Trino|Kyuubi|GDB|TCHOUSE_X|TCHOUSE_P|TDSQL_POSTGRE
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InputDatasourceType")]
        public string InputDatasourceType{ get; set; }

        /// <summary>
        /// Data Source Type: MYSQL|POSTGRE|ORACLE|SQLSERVER|FTP|HIVE|HDFS|ICEBERG|KAFKA|HBASE|SPARK|VIRTUAL|TBASE|DB2|DM|GAUSSDB|GBASE|IMPALA|ES|S3_DATAINSIGHT|GREENPLUM|PHOENIX|SAP_HANA|SFTP|OCEANBASE|CLICKHOUSE|KUDU|VERTICA|REDIS|COS|DLC|DLCV1|DORIS|CKAFKA|DTS_KAFKA|S3|CDW|LOCAL|TDSQLC|TDSQL|TDSQL_MYSQL|MONGODB|INFORMIX|SYBASE|REST_API|SuperSQL|PRESTO|DR_SUM|TiDB|StarRocks|Trino|Kyuubi|GDB|TCHOUSE_X|TCHOUSE_P|TDSQL_POSTGRE
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OutputDatasourceType")]
        public string OutputDatasourceType{ get; set; }

        /// <summary>
        /// Number of reads
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NumRecordsIn")]
        public long? NumRecordsIn{ get; set; }

        /// <summary>
        /// Number of writes
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NumRecordsOut")]
        public long? NumRecordsOut{ get; set; }

        /// <summary>
        /// Read latency
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ReaderDelay")]
        public float? ReaderDelay{ get; set; }

        /// <summary>
        /// Restart Times
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NumRestarts")]
        public long? NumRestarts{ get; set; }

        /// <summary>
        /// Creation TimeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Task Update Time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Last task run time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LastRunTime")]
        public string LastRunTime{ get; set; }

        /// <summary>
        /// Task stop time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StopTime")]
        public string StopTime{ get; set; }

        /// <summary>
        /// Job Submitted?
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("HasVersion")]
        public bool? HasVersion{ get; set; }

        /// <summary>
        /// Is the task locked?
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Locked")]
        public bool? Locked{ get; set; }

        /// <summary>
        /// Task Locked By
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Locker")]
        public string Locker{ get; set; }

        /// <summary>
        /// Resource Consumption
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RunningCu")]
        public float? RunningCu{ get; set; }

        /// <summary>
        /// Associated Alert Rules for the Task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskAlarmRegularList")]
        public string[] TaskAlarmRegularList{ get; set; }

        /// <summary>
        /// Real-time task resource layering status: 0:Ongoing,1:Success,2:Failed
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SwitchResource")]
        public long? SwitchResource{ get; set; }

        /// <summary>
        /// Real-time task reading phase: 0:Full Full,1:Partial Full,2:Full Incremental
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ReadPhase")]
        public long? ReadPhase{ get; set; }

        /// <summary>
        /// Real-time Task Version Number
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public long? InstanceVersion{ get; set; }

        /// <summary>
        /// Offline task imported into orchestration space Task ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ArrangeSpaceTaskId")]
        public string ArrangeSpaceTaskId{ get; set; }

        /// <summary>
        /// Offline Task Status Differentiation 1.Not Submitted 2.Submitted 3.Exported
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OfflineTaskStatus")]
        public long? OfflineTaskStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SyncType", this.SyncType);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ScheduleTaskId", this.ScheduleTaskId);
            this.SetParamSimple(map, prefix + "TaskGroupId", this.TaskGroupId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "OperatorUin", this.OperatorUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "ExecutorId", this.ExecutorId);
            this.SetParamArrayObj(map, prefix + "Config.", this.Config);
            this.SetParamArrayObj(map, prefix + "ExtConfig.", this.ExtConfig);
            this.SetParamArrayObj(map, prefix + "ExecuteContext.", this.ExecuteContext);
            this.SetParamArrayObj(map, prefix + "Mappings.", this.Mappings);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "Incharge", this.Incharge);
            this.SetParamObj(map, prefix + "OfflineTaskAddEntity.", this.OfflineTaskAddEntity);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
            this.SetParamSimple(map, prefix + "InLongManagerUrl", this.InLongManagerUrl);
            this.SetParamSimple(map, prefix + "InLongStreamId", this.InLongStreamId);
            this.SetParamSimple(map, prefix + "InLongManagerVersion", this.InLongManagerVersion);
            this.SetParamArraySimple(map, prefix + "DataProxyUrl.", this.DataProxyUrl);
            this.SetParamSimple(map, prefix + "Submit", this.Submit);
            this.SetParamSimple(map, prefix + "InputDatasourceType", this.InputDatasourceType);
            this.SetParamSimple(map, prefix + "OutputDatasourceType", this.OutputDatasourceType);
            this.SetParamSimple(map, prefix + "NumRecordsIn", this.NumRecordsIn);
            this.SetParamSimple(map, prefix + "NumRecordsOut", this.NumRecordsOut);
            this.SetParamSimple(map, prefix + "ReaderDelay", this.ReaderDelay);
            this.SetParamSimple(map, prefix + "NumRestarts", this.NumRestarts);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastRunTime", this.LastRunTime);
            this.SetParamSimple(map, prefix + "StopTime", this.StopTime);
            this.SetParamSimple(map, prefix + "HasVersion", this.HasVersion);
            this.SetParamSimple(map, prefix + "Locked", this.Locked);
            this.SetParamSimple(map, prefix + "Locker", this.Locker);
            this.SetParamSimple(map, prefix + "RunningCu", this.RunningCu);
            this.SetParamArraySimple(map, prefix + "TaskAlarmRegularList.", this.TaskAlarmRegularList);
            this.SetParamSimple(map, prefix + "SwitchResource", this.SwitchResource);
            this.SetParamSimple(map, prefix + "ReadPhase", this.ReadPhase);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "ArrangeSpaceTaskId", this.ArrangeSpaceTaskId);
            this.SetParamSimple(map, prefix + "OfflineTaskStatus", this.OfflineTaskStatus);
        }
    }
}

