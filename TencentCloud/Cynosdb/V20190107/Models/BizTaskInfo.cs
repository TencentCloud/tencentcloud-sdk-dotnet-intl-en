/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BizTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>User appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Region</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Task creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Delayed execution time</p>
        /// </summary>
        [JsonProperty("DelayTime")]
        public string DelayTime{ get; set; }

        /// <summary>
        /// <p>Task failure information</p>
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// <p>Asynchronous task flow id</p>
        /// </summary>
        [JsonProperty("FlowId")]
        public long? FlowId{ get; set; }

        /// <summary>
        /// <p>Task input information</p>
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// <p>Instance group id.</p>
        /// </summary>
        [JsonProperty("InstanceGrpId")]
        [System.Obsolete]
        public string InstanceGrpId{ get; set; }

        /// <summary>
        /// <p>Instance group id.</p>
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public string InstanceGroupId{ get; set; }

        /// <summary>
        /// <p>Instance id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Task operation object id</p>
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// <p>Task operation object type.</p>
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// <p>Operator uin</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>Task output information</p>
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// <p>Task status</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Task type</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>Parent task ID that triggers this task</p>
        /// </summary>
        [JsonProperty("TriggerTaskId")]
        public long? TriggerTaskId{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Task start time</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Task end time</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Instance name</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Task progress</p>
        /// </summary>
        [JsonProperty("Process")]
        public long? Process{ get; set; }

        /// <summary>
        /// <p>Modify parameter task information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModifyParamsData")]
        [System.Obsolete]
        public ModifyParamsData[] ModifyParamsData{ get; set; }

        /// <summary>
        /// <p>Create cluster task information</p>
        /// </summary>
        [JsonProperty("CreateClustersData")]
        public CreateClustersData CreateClustersData{ get; set; }

        /// <summary>
        /// <p>Cluster rollback task information</p>
        /// </summary>
        [JsonProperty("RollbackData")]
        public RollbackData RollbackData{ get; set; }

        /// <summary>
        /// <p>Instance configuration change task information</p>
        /// </summary>
        [JsonProperty("ModifyInstanceData")]
        public ModifyInstanceData ModifyInstanceData{ get; set; }

        /// <summary>
        /// <p>Manual backup task information</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ManualBackupData")]
        public ManualBackupData ManualBackupData{ get; set; }

        /// <summary>
        /// <p>Modify kernel version task information</p>
        /// </summary>
        [JsonProperty("ModifyDbVersionData")]
        public ModifyDbVersionData ModifyDbVersionData{ get; set; }

        /// <summary>
        /// <p>Cluster Availability Zone Information</p>
        /// </summary>
        [JsonProperty("ClusterSlaveData")]
        public ClusterSlaveData ClusterSlaveData{ get; set; }

        /// <summary>
        /// <p>Convert cluster logs</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SwitchClusterLogBin")]
        public SwitchClusterLogBin SwitchClusterLogBin{ get; set; }

        /// <summary>
        /// <p>Modify instance parameter data</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModifyInstanceParamsData")]
        public BizTaskModifyParamsData ModifyInstanceParamsData{ get; set; }

        /// <summary>
        /// <p>Maintenance time</p>
        /// </summary>
        [JsonProperty("TaskMaintainInfo")]
        public TaskMaintainInfo TaskMaintainInfo{ get; set; }

        /// <summary>
        /// <p>Instance Log Delivery Information</p>
        /// </summary>
        [JsonProperty("InstanceCLSDeliveryInfos")]
        public InstanceCLSDeliveryInfo[] InstanceCLSDeliveryInfos{ get; set; }

        /// <summary>
        /// <p>Task progress information</p>
        /// </summary>
        [JsonProperty("TaskProgressInfo")]
        public TaskProgressInfo TaskProgressInfo{ get; set; }

        /// <summary>
        /// <p>Global database network task</p>
        /// </summary>
        [JsonProperty("GdnTaskInfo")]
        public GdnTaskInfo GdnTaskInfo{ get; set; }

        /// <summary>
        /// <p>Safe id</p>
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// <p>Safe name</p>
        /// </summary>
        [JsonProperty("VaultName")]
        public string VaultName{ get; set; }

        /// <summary>
        /// <p>AI optimizer task information</p>
        /// </summary>
        [JsonProperty("AIOptimizerTaskData")]
        public AIOptimizerTaskData AIOptimizerTaskData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "InstanceGrpId", this.InstanceGrpId);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TriggerTaskId", this.TriggerTaskId);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Process", this.Process);
            this.SetParamArrayObj(map, prefix + "ModifyParamsData.", this.ModifyParamsData);
            this.SetParamObj(map, prefix + "CreateClustersData.", this.CreateClustersData);
            this.SetParamObj(map, prefix + "RollbackData.", this.RollbackData);
            this.SetParamObj(map, prefix + "ModifyInstanceData.", this.ModifyInstanceData);
            this.SetParamObj(map, prefix + "ManualBackupData.", this.ManualBackupData);
            this.SetParamObj(map, prefix + "ModifyDbVersionData.", this.ModifyDbVersionData);
            this.SetParamObj(map, prefix + "ClusterSlaveData.", this.ClusterSlaveData);
            this.SetParamObj(map, prefix + "SwitchClusterLogBin.", this.SwitchClusterLogBin);
            this.SetParamObj(map, prefix + "ModifyInstanceParamsData.", this.ModifyInstanceParamsData);
            this.SetParamObj(map, prefix + "TaskMaintainInfo.", this.TaskMaintainInfo);
            this.SetParamArrayObj(map, prefix + "InstanceCLSDeliveryInfos.", this.InstanceCLSDeliveryInfos);
            this.SetParamObj(map, prefix + "TaskProgressInfo.", this.TaskProgressInfo);
            this.SetParamObj(map, prefix + "GdnTaskInfo.", this.GdnTaskInfo);
            this.SetParamSimple(map, prefix + "VaultId", this.VaultId);
            this.SetParamSimple(map, prefix + "VaultName", this.VaultName);
            this.SetParamObj(map, prefix + "AIOptimizerTaskData.", this.AIOptimizerTaskData);
        }
    }
}

