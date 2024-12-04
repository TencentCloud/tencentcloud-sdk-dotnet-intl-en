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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// Task ID 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// Task start time 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task type.
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
        /// - FLOW_MIGRATETASK: "023" - Migrating data is in progress.
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
        /// - FLOW_UPGRADE_INSTANCE_CACHE_AND_PROXY: "067" - Upgrading the instance version is in progress.
        /// - FLOW_MODIFY_PROXY_NUM: "069" - Add or remove a Proxy node.
        /// - FLOW_MODIFYBACKUPMOD: "070" - Change the instance backup mode.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Instance name 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance ID 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Project ID 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Task progress 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// Task end time 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Task execution status. Valid values: - `0` (initilized) - `1` (executing) - `2` (completed) - `4` (failed) 
        /// Note:  This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Result", this.Result);
        }
    }
}

