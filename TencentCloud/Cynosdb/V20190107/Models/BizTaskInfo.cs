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
        /// 
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Specifies the delayed execution time.
        /// </summary>
        [JsonProperty("DelayTime")]
        public string DelayTime{ get; set; }

        /// <summary>
        /// Task failure information.
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FlowId")]
        public long? FlowId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InstanceGrpId")]
        [System.Obsolete]
        public string InstanceGrpId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public string InstanceGroupId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TriggerTaskId")]
        public long? TriggerTaskId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Process")]
        public long? Process{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ModifyParamsData")]
        [System.Obsolete]
        public ModifyParamsData[] ModifyParamsData{ get; set; }

        /// <summary>
        /// Create cluster task information.
        /// </summary>
        [JsonProperty("CreateClustersData")]
        public CreateClustersData CreateClustersData{ get; set; }

        /// <summary>
        /// Cluster rollback task information.
        /// </summary>
        [JsonProperty("RollbackData")]
        public RollbackData RollbackData{ get; set; }

        /// <summary>
        /// Instance configuration change task information.
        /// </summary>
        [JsonProperty("ModifyInstanceData")]
        public ModifyInstanceData ModifyInstanceData{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ManualBackupData")]
        public ManualBackupData ManualBackupData{ get; set; }

        /// <summary>
        /// Modify kernel version task information.
        /// </summary>
        [JsonProperty("ModifyDbVersionData")]
        public ModifyDbVersionData ModifyDbVersionData{ get; set; }

        /// <summary>
        /// Cluster availability zone information.
        /// </summary>
        [JsonProperty("ClusterSlaveData")]
        public ClusterSlaveData ClusterSlaveData{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SwitchClusterLogBin")]
        public SwitchClusterLogBin SwitchClusterLogBin{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ModifyInstanceParamsData")]
        public BizTaskModifyParamsData ModifyInstanceParamsData{ get; set; }

        /// <summary>
        /// Maintenance time.
        /// </summary>
        [JsonProperty("TaskMaintainInfo")]
        public TaskMaintainInfo TaskMaintainInfo{ get; set; }

        /// <summary>
        /// Instance log delivery information.
        /// </summary>
        [JsonProperty("InstanceCLSDeliveryInfos")]
        public InstanceCLSDeliveryInfo[] InstanceCLSDeliveryInfos{ get; set; }

        /// <summary>
        /// Task progress information.
        /// </summary>
        [JsonProperty("TaskProgressInfo")]
        public TaskProgressInfo TaskProgressInfo{ get; set; }


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
        }
    }
}

