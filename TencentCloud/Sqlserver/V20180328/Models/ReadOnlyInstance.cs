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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReadOnlyInstance : AbstractModel
    {
        
        /// <summary>
        /// Read-Only Replica ID, in the format of: mssqlro-3l3fgqn7
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Read-Only Replica Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Read-Only Replica Unique UID
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// Read-Only Replica Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Read-Only Replica Status: 1: Creating, 2: Running, 3: Delayed Removal, 4: Isolated, 5: Recycling, 6: Recycled, 7: Task Executing, 8: Offline, 9: Instance Scaling, 10: Instance Migrating, 12: Restarting
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Read-Only Replica Creation Time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Read-Only Replica Update Time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Read-Only Replica Memory Size (Unit: GB)
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Read-Only Replica Storage Space Size (Unit: GB)
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// Read-Only Replica cpu Core Count
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Read-Only Replica Codenames
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Host Machine Code
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Read-Only Replica Mode, 2-Standalone
        /// </summary>
        [JsonProperty("Model")]
        public long? Model{ get; set; }

        /// <summary>
        /// Read-Only Replica Billing Mode, 1-yearly/monthly subscription, 0-pay-as-you-go
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Read-Only Replica Weight
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// Read-Only Replica Latency Time (Unit: seconds)
        /// </summary>
        [JsonProperty("DelayTime")]
        public string DelayTime{ get; set; }

        /// <summary>
        /// Synchronization status between the read-only replica and the primary instance.
        /// 
        /// Init: Initializing
        /// 
        /// DeployReadOnlyInPorgress: Deploying replica in progress
        /// 
        /// DeployReadOnlySuccess: Replica deployment succeeded
        /// 
        /// DeployReadOnlyFail: Replica deployment failed
        /// 
        /// DeployMasterDBInPorgress: Adding replica database to primary node in progress
        /// 
        /// DeployMasterDBSuccess: Successfully added replica database to primary node
        /// 
        /// DeployMasterDBFail: Failed to add replica database to primary node
        /// 
        /// DeployReadOnlyDBInPorgress: Replica restoration and database joining started
        /// 
        /// DeployReadOnlyDBSuccess: Replica restoration and database joining succeeded
        /// 
        /// DeployReadOnlyDBFail: Replica restoration and database joining failed
        /// 
        /// SyncDelay: Synchronization delayed
        /// 
        /// SyncFail: Synchronization failed
        /// 
        /// SyncExcluded: Removed from read-only group
        /// 
        /// SyncNormal: Normal
        /// </summary>
        [JsonProperty("SynStatus")]
        public string SynStatus{ get; set; }

        /// <summary>
        /// Databases not synchronized between the read-only replica and the primary instance
        /// </summary>
        [JsonProperty("DatabaseDifference")]
        public string DatabaseDifference{ get; set; }

        /// <summary>
        /// Accounts not synchronized between the read-only replica and the primary instance
        /// </summary>
        [JsonProperty("AccountDifference")]
        public string AccountDifference{ get; set; }

        /// <summary>
        /// Read-Only Replica Billing Start Time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Read-Only Replica Billing End Time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Read-Only Replica Isolation Time
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// Read-Only Replica Region Location
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// Read-Only Replica AZ Location
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "SynStatus", this.SynStatus);
            this.SetParamSimple(map, prefix + "DatabaseDifference", this.DatabaseDifference);
            this.SetParamSimple(map, prefix + "AccountDifference", this.AccountDifference);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
        }
    }
}

