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

    public class DbNormalDetail : AbstractModel
    {
        
        /// <summary>
        /// Whether it is subscribed. Valid values: `0` (no), `1` (yes)
        /// </summary>
        [JsonProperty("IsSubscribed")]
        public string IsSubscribed{ get; set; }

        /// <summary>
        /// Database collation
        /// </summary>
        [JsonProperty("CollationName")]
        public string CollationName{ get; set; }

        /// <summary>
        /// Whether the cleanup task is enabled to automatically remove old change tracking information when CT is enabled. Valid values: `0` (no), `1` (yes)
        /// </summary>
        [JsonProperty("IsAutoCleanupOn")]
        public string IsAutoCleanupOn{ get; set; }

        /// <summary>
        /// Whether SQL Server Service Broker is enabled. Valid values: `0` (no), `1` (yes)
        /// </summary>
        [JsonProperty("IsBrokerEnabled")]
        public string IsBrokerEnabled{ get; set; }

        /// <summary>
        /// Whether CDC is enabled. Valid values: `0` (disabled), `1` (enabled)
        /// </summary>
        [JsonProperty("IsCdcEnabled")]
        public string IsCdcEnabled{ get; set; }

        /// <summary>
        /// Whether CT is enabled. Valid values: `0` (disabled), `1` (enabled)
        /// </summary>
        [JsonProperty("IsDbChainingOn")]
        public string IsDbChainingOn{ get; set; }

        /// <summary>
        /// Whether it is encrypted. Valid values: `0` (no), `1` (yes)
        /// </summary>
        [JsonProperty("IsEncrypted")]
        public string IsEncrypted{ get; set; }

        /// <summary>
        /// Whether full-text indexes are enabled. Valid values: `0` (no), `1` (yes)
        /// </summary>
        [JsonProperty("IsFulltextEnabled")]
        [System.Obsolete]
        public string IsFulltextEnabled{ get; set; }

        /// <summary>
        /// Whether it is a mirror database. Valid values: `0` (no), `1` (yes)
        /// </summary>
        [JsonProperty("IsMirroring")]
        public string IsMirroring{ get; set; }

        /// <summary>
        /// Whether it is published. Valid values: `0` (no), `1` (yes)
        /// </summary>
        [JsonProperty("IsPublished")]
        public string IsPublished{ get; set; }

        /// <summary>
        /// Whether snapshots are enabled. Valid values: `0` (no), `1` (yes)
        /// </summary>
        [JsonProperty("IsReadCommittedSnapshotOn")]
        public string IsReadCommittedSnapshotOn{ get; set; }

        /// <summary>
        /// Whether it is trustworthy. Valid values: `0` (no), `1` (yes)
        /// </summary>
        [JsonProperty("IsTrustworthyOn")]
        public string IsTrustworthyOn{ get; set; }

        /// <summary>
        /// Mirroring state
        /// </summary>
        [JsonProperty("MirroringState")]
        public string MirroringState{ get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Recovery model
        /// </summary>
        [JsonProperty("RecoveryModelDesc")]
        public string RecoveryModelDesc{ get; set; }

        /// <summary>
        /// Retention period (in days) of change tracking information
        /// </summary>
        [JsonProperty("RetentionPeriod")]
        public string RetentionPeriod{ get; set; }

        /// <summary>
        /// Database status
        /// </summary>
        [JsonProperty("StateDesc")]
        public string StateDesc{ get; set; }

        /// <summary>
        /// User type
        /// </summary>
        [JsonProperty("UserAccessDesc")]
        public string UserAccessDesc{ get; set; }

        /// <summary>
        /// Database creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSubscribed", this.IsSubscribed);
            this.SetParamSimple(map, prefix + "CollationName", this.CollationName);
            this.SetParamSimple(map, prefix + "IsAutoCleanupOn", this.IsAutoCleanupOn);
            this.SetParamSimple(map, prefix + "IsBrokerEnabled", this.IsBrokerEnabled);
            this.SetParamSimple(map, prefix + "IsCdcEnabled", this.IsCdcEnabled);
            this.SetParamSimple(map, prefix + "IsDbChainingOn", this.IsDbChainingOn);
            this.SetParamSimple(map, prefix + "IsEncrypted", this.IsEncrypted);
            this.SetParamSimple(map, prefix + "IsFulltextEnabled", this.IsFulltextEnabled);
            this.SetParamSimple(map, prefix + "IsMirroring", this.IsMirroring);
            this.SetParamSimple(map, prefix + "IsPublished", this.IsPublished);
            this.SetParamSimple(map, prefix + "IsReadCommittedSnapshotOn", this.IsReadCommittedSnapshotOn);
            this.SetParamSimple(map, prefix + "IsTrustworthyOn", this.IsTrustworthyOn);
            this.SetParamSimple(map, prefix + "MirroringState", this.MirroringState);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RecoveryModelDesc", this.RecoveryModelDesc);
            this.SetParamSimple(map, prefix + "RetentionPeriod", this.RetentionPeriod);
            this.SetParamSimple(map, prefix + "StateDesc", this.StateDesc);
            this.SetParamSimple(map, prefix + "UserAccessDesc", this.UserAccessDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

