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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskListRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of a specified instance,  such as  "crs-xjhsdj****" Log in to the [Redis console](https://console.cloud.tencent.com/redis) and copy the instance ID in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Number of taskss returned per page.  Default value: `20`. Maximum value: `100`.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Pagination offset, which is an integral multiple of `Limit`. Calculation formula:  `offset` = `limit` * (page number - 1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Project ID Log in to the [Redis console](https://console.cloud.tencent.com/redis#/), go to the account information menu in the top-right corner, and select **Project Management** to query the project ID.
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// Task type.
        /// 
        /// 
        /// 
        /// - FLOW_CREATE: "001" - Create an instance.
        /// - FLOW_RESIZE: "002" - Change the configuration.
        /// - FLOW_CLOSE: "003" - Close an instance.
        /// - FLOW_CLEAN: "004" - Clear an instance.
        /// - FLOW_STARTUP: "005" - Enable an instance.
        /// - FLOW_DELETE: "006" - Delete an instance.
        /// - FLOW_SETPWD: "007" - Reset the password.
        /// - FLOW_EXPORTBACKUP: "009" - Export the backup file.
        /// - FLOW_RESTOREBACKUP: "010" - Restore the backup.
        /// - FLOW_BACKUPINSTANCE: "012" - Back up an instance.
        /// - FLOW_MIGRATEINSTANCE: "013" - Migrate an instance.
        /// - FLOW_DELBACKUP: "014" - Delete the backup.
        /// - FLOW_EXCHANGEINSTANCE: "016" - Switch an instance.
        /// - FLOW_AUTOBACKUP: "017" - Automatically backup an instance.
        /// - FLOW_MIGRATECHECK: "022" - Verify migration parameters.
        /// - FLOW_MIGRATETASK: "023" - Migrate data in progress.
        /// - FLOW_CLEANDB: "025" - Clear a database.
        /// - FLOW_CLONEBACKUP: "026" - Clone the backup.
        /// - FLOW_CHANGEVIP: "027" - Change the VIP.
        /// - FLOW_EXPORSHR: "028" - Perform scaling.
        /// - FLOW_ADDNODES: "029" - Add or remove a node.
        /// - FLOW_CHANGENET: "031" - Change the network type.
        /// - FLOW_MODIFYINSTACEREADONLY: "033" - Modify the read-only policy.
        /// - FLOW_MODIFYINSTANCEPARAMS: "034" - Modify instance parameters.
        /// - FLOW_MODIFYINSTANCEPASSWORDFREE: "035" - Set password-free access.
        /// - FLOW_SWITCHINSTANCEVIP: "036" - Switch the instance VIP.
        /// - FLOW_MODIFYINSTANCEACCOUNT: "037" - Modify the instance account.
        /// - FLOW_MODIFYINSTANCEBANDWIDTH: "038" - Modify the instance bandwidth.
        /// - FLOW_ENABLEINSTANCE_REPLICATE: "039" - Enable read-only replica.
        /// - FLOW_DISABLEINSTANCE_REPLICATE: "040" - Disable read-only replica.
        /// - FLOW_UpgradeArch: "041" - Upgrade the instance architecture from primary-secondary to cluster.
        /// - FLOW_DowngradeArch: "042" - Downgrade the instance architecture from cluster to primary-secondary.
        /// - FLOW_UpgradeVersion: "043" - Upgrade the version.
        /// - FLOW_MODIFYCONNECTIONCONFIG: "044" - Modify the number of bandwidth connections.
        /// - FLOW_CLEARNETWORK: "045" - Change the network.
        /// - FLOW_REMOVE_BACKUP_FILE: "046" - Delete the backup.
        /// - FLOW_UPGRADE_SUPPORT_MULTI_AZ: "047" - Upgrade an instance to support multiple AZs.
        /// - FLOW_SHUTDOWN_MASTER: "048" - Simulate a fault.
        /// - FLOW_CHANGE_REPLICA_TO_MASTER: "049" - Manually promote the replica node to the primary node.
        /// - FLOW_CODE_ADD_REPLICATION_INSTANCE: "050" - Add a replication group.
        /// - FLOW_OPEN_WAN: "052" - Enable the public network.
        /// - FLOW_CLOSE_WAN: "053" - Disable the public network. - FLOW_UPDATE_WAN: "054" - Update the public network.
        /// - FLOW_CODE_DELETE_REPLICATION_INSTANCE: "055" - Unbind the replication group.
        /// - FLOW_CODE_CHANGE_MASTER_INSTANCE: "056" - Switch to the primary instance in the replication group.
        /// - FLOW_CODE_CHANGE_INSTANCE_ROLE: "057" - Change the roles of instances in the replication group.
        /// - FLOW_MIGRATE_NODE: "058" - Migrate a node.
        /// - FLOW_SWITCH_NODE: "059" - Switch a node.
        /// - FLOW_UPGRADE_SMALL_VERSION: "060" - Upgrade the Redis version.
        /// - FLOW_UPGRADE_PROXY_VERSION: "061" - Upgrade the Proxy version.
        /// - FLOW_MODIFY_INSTANCE_NETWORK: "062" - Modify the instance network.
        /// - FLOW_MIGRATE_PROXY_NODE: "063" - Migrate the Proxy node.
        /// - FLOW_MIGRATION_INSTANCE_ZONE: "066" - Migrate the instance AZ in progress.
        /// - FLOW_UPGRADE_INSTANCE_CACHE_AND_PROXY: "067" - Upgrade the instance version in progress.
        /// - FLOW_MODIFY_PROXY_NUM: "069" - Add or remove a Proxy node.
        /// - FLOW_MODIFYBACKUPMOD: "070" - Change the instance backup mode.
        /// </summary>
        [JsonProperty("TaskTypes")]
        public string[] TaskTypes{ get; set; }

        /// <summary>
        /// Start time of the task, for example, in the format of 2021-12-30 00:00:00. Data in the last 30 days can be queried.
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// End time of the task, for example, in the format of 2021-12-30 20:59:35. Data in the last 30 days can be queried.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// This parameter is only for internal use and can be ignored.
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long?[] TaskStatus{ get; set; }

        /// <summary>
        /// Task execution status. Valid values: - `0` (initilized) - `1` (executing) - `2` (completed) - `4` (failed)
        /// </summary>
        [JsonProperty("Result")]
        public long?[] Result{ get; set; }

        /// <summary>
        /// The field `OperatorUin` has been disused and replaced by `OperateUin`.
        /// </summary>
        [JsonProperty("OperatorUin")]
        [System.Obsolete]
        public long?[] OperatorUin{ get; set; }

        /// <summary>
        /// Operator account ID or UIN
        /// </summary>
        [JsonProperty("OperateUin")]
        public string[] OperateUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "TaskStatus.", this.TaskStatus);
            this.SetParamArraySimple(map, prefix + "Result.", this.Result);
            this.SetParamArraySimple(map, prefix + "OperatorUin.", this.OperatorUin);
            this.SetParamArraySimple(map, prefix + "OperateUin.", this.OperateUin);
        }
    }
}

