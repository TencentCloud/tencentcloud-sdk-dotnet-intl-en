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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Target ES version. Valid values: "6.4.3", "6.8.2", "7.5.1", "7.10.1", and "7.14.2".
        /// </summary>
        [JsonProperty("EsVersion")]
        public string EsVersion{ get; set; }

        /// <summary>
        /// Whether to perform an upgrade check only. Default value: false.
        /// </summary>
        [JsonProperty("CheckOnly")]
        public bool? CheckOnly{ get; set; }

        /// <summary>
        /// Target business feature version: <li>oss open source edition</li><li>basic edition</li>Currently used only when upgrading from 5.6.4 to 6.x. Default value: basic
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// Whether xpack security authentication is enabled for basic version 6.8 (and above versions)<li>1: not enabled</li><li>2: enabled</li>
        /// </summary>
        [JsonProperty("BasicSecurityType")]
        public ulong? BasicSecurityType{ get; set; }

        /// <summary>
        /// Upgrade method: <li>scale blue-green change</li><li>restart rolling restart</li>Default value: scale
        /// </summary>
        [JsonProperty("UpgradeMode")]
        public string UpgradeMode{ get; set; }

        /// <summary>
        /// Whether to back up the cluster before upgrading the version. By default, no backup is performed.
        /// </summary>
        [JsonProperty("CosBackup")]
        public bool? CosBackup{ get; set; }

        /// <summary>
        /// In rolling mode, whether to skip the check and perform a forced reboot. Default value: false
        /// </summary>
        [JsonProperty("SkipCheckForceRestart")]
        public bool? SkipCheckForceRestart{ get; set; }

        /// <summary>
        /// Parameter for delayed cvm launch
        /// </summary>
        [JsonProperty("CvmDelayOnlineTime")]
        public ulong? CvmDelayOnlineTime{ get; set; }

        /// <summary>
        /// Number of concurrent shard migrations
        /// </summary>
        [JsonProperty("ShardAllocationConcurrents")]
        public ulong? ShardAllocationConcurrents{ get; set; }

        /// <summary>
        /// Shard migration concurrency speed
        /// </summary>
        [JsonProperty("ShardAllocationBytes")]
        public ulong? ShardAllocationBytes{ get; set; }

        /// <summary>
        /// Whether to enable the placement group asynchronous task
        /// </summary>
        [JsonProperty("EnableScheduleRecoverGroup")]
        public bool? EnableScheduleRecoverGroup{ get; set; }

        /// <summary>
        /// Time period of the async task for the placement group
        /// </summary>
        [JsonProperty("EnableScheduleOperationDuration")]
        public EnableScheduleOperationDuration EnableScheduleOperationDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "EsVersion", this.EsVersion);
            this.SetParamSimple(map, prefix + "CheckOnly", this.CheckOnly);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "BasicSecurityType", this.BasicSecurityType);
            this.SetParamSimple(map, prefix + "UpgradeMode", this.UpgradeMode);
            this.SetParamSimple(map, prefix + "CosBackup", this.CosBackup);
            this.SetParamSimple(map, prefix + "SkipCheckForceRestart", this.SkipCheckForceRestart);
            this.SetParamSimple(map, prefix + "CvmDelayOnlineTime", this.CvmDelayOnlineTime);
            this.SetParamSimple(map, prefix + "ShardAllocationConcurrents", this.ShardAllocationConcurrents);
            this.SetParamSimple(map, prefix + "ShardAllocationBytes", this.ShardAllocationBytes);
            this.SetParamSimple(map, prefix + "EnableScheduleRecoverGroup", this.EnableScheduleRecoverGroup);
            this.SetParamObj(map, prefix + "EnableScheduleOperationDuration.", this.EnableScheduleOperationDuration);
        }
    }
}

