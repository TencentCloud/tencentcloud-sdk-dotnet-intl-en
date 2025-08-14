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

    public class TaskInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// Task start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task type.
        /// 
        /// - FLOW_CREATE: "001", indicating instance creation.
        /// - FLOW_RESIZE: "002", indicating configuration modification.
        /// - FLOW_CLOSE: "003", indicating instance disabling.
        /// - FLOW_CLEAN: "004", indicating instance cleanup.
        /// - FLOW_STARTUP: "005", indicating instance enabling.
        /// - FLOW_DELETE: "006", indicating instance deletion.
        /// - FLOW_SETPWD: "007", indicating password reset.
        /// - FLOW_EXPORTBACKUP: "009", indicating backup file export.
        /// - FLOW_RESTOREBACKUP: "010", indicating backup restoration.
        /// - FLOW_BACKUPINSTANCE: "012", indicating instance backup.
        /// - FLOW_MIGRATEINSTANCE: "013", indicating instance migration.
        /// - FLOW_DELBACKUP: "014", indicating backup deletion.
        /// - FLOW_EXCHANGEINSTANCE: "016", indicating instance switch.
        /// - FLOW_AUTOBACKUP: "017", indicating automatic instance backup.
        /// - FLOW_MIGRATECHECK: "022", indicating migration parameter verification.
        /// - FLOW_MIGRATETASK: "023", indicating that data migration is in progress.
        /// - FLOW_CLEANDB: "025", indicating database cleanup.
        /// - FLOW_CLONEBACKUP: "026": indicating backup cloning.
        /// - FLOW_CHANGEVIP: "027", indicating VIP address modification.
        /// - FLOW_EXPORSHR: "028", indicating scaling.
        /// - FLOW_ADDNODES: "029", indicating node addition (removal).
        /// - FLOW_CHANGENET: "031", indicating network type modification.
        /// - FLOW_MODIFYINSTACEREADONLY: "033": indicating read-only policy modification.
        /// - FLOW_MODIFYINSTANCEPARAMS: "034", indicating instance parameter modification.
        /// - FLOW_MODIFYINSTANCEPASSWORDFREE: "035", indicating password-free access settings.
        /// - FLOW_SWITCHINSTANCEVIP: "036", indicating instance VIP address switch.
        /// - FLOW_MODIFYINSTANCEACCOUNT: "037", indicating instance account modification.
        /// - FLOW_MODIFYINSTANCEBANDWIDTH: "038", indicating instance bandwidth modification.
        /// - FLOW_ENABLEINSTANCE_REPLICATE: "039", indicating enabling of read-only replica.
        /// - FLOW_DISABLEINSTANCE_REPLICATE: "040", indicating disabling of read-only replica.
        /// - FLOW_UpgradeArch: "041", indicating instance architecture upgrade from the standard architecture to the cluster architecture.
        /// - FLOW_DowngradeArch: "042", indicating instance architecture downgrade from the cluster architecture to the standard architecture.
        /// - FLOW_UpgradeVersion: "043", indicating version upgrade.
        /// - FLOW_MODIFYCONNECTIONCONFIG: "044", indicating adjustment of the bandwidth and the number of connections.
        /// - FLOW_CLEARNETWORK: "045", indicating network change.
        /// - FLOW_REMOVE_BACKUP_FILE: "046", indicating backup deletion.
        /// - FLOW_UPGRADE_SUPPORT_MULTI_AZ: "047", indicating instance upgrade to multi-AZ deployment.
        /// - FLOW_SHUTDOWN_MASTER: "048", indicating fault simulation.
        /// - FLOW_CHANGE_REPLICA_TO_MASTER: "049", indicating manual promotion to the primary node.
        /// - FLOW_CODE_ADD_REPLICATION_INSTANCE: "050", indicating replication group addition.
        /// - FLOW_OPEN_WAN: "052", indicating enabling of public network access.
        /// - FLOW_CLOSE_WAN: "053", indicating disabling of public network access.
        /// - FLOW_CODE_DELETE_REPLICATION_INSTANCE: "055", indicating replication group unbinding.
        /// - FLOW_CODE_CHANGE_MASTER_INSTANCE: "056", indicating switching a replication group instance to the primary instance.
        /// - FLOW_CODE_CHANGE_INSTANCE_ROLE: "057", indicating modification of the replication group instance role.
        /// - FLOW_MIGRATE_NODE: "058", indicating node migration.
        /// - FLOW_SWITCH_NODE: "059", indicating node switch.
        /// - FLOW_UPGRADE_SMALL_VERSION: "060", indicating Redis version upgrade.
        /// - FLOW_UPGRADE_PROXY_VERSION: "061", indicating proxy version upgrade.
        /// - FLOW_MODIFY_INSTANCE_NETWORK: "062", indicating instance network modification.
        /// - FLOW_MIGRATE_PROXY_NODE: "063", indicating proxy node migration.
        /// - FLOW_MIGRATION_INSTANCE_ZONE: "066", indicating that instance migration to another AZ is in progress.
        /// - FLOW_UPGRADE_INSTANCE_CACHE_AND_PROXY: "067", indicating that instance version upgrade is in progress.
        /// - FLOW_MODIFY_PROXY_NUM: "069", indicating proxy node addition (removal).
        /// - FLOW_MODIFYBACKUPMOD: "070", indicating instance backup mode modification.
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Task progress.
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// Task execution end time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Task execution status.
        /// 
        /// 
        /// 
        /// 0: initializing the task.
        /// 1: executing.
        /// 2. completed.
        /// 4: failed.
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

