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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmAssetSecurityAnalyseStatus : AbstractModel
    {
        
        /// <summary>
        /// app id of the asset owner account
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Asset instance ID.
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Asset type
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Whether sensitive data identification is supported. 0: no support; 1: support
        /// </summary>
        [JsonProperty("IdentifyScanSupported")]
        public long? IdentifyScanSupported{ get; set; }

        /// <summary>
        /// Whether log shipping is supported. 0: unsupported; 1: supported
        /// </summary>
        [JsonProperty("LogDeliverySupported")]
        public long? LogDeliverySupported{ get; set; }

        /// <summary>
        /// Security analysis status (0: Off, 1: On, 2: Activating, 3: Disabling)
        /// </summary>
        [JsonProperty("SecurityAnalyseStatus")]
        public long? SecurityAnalyseStatus{ get; set; }

        /// <summary>
        /// Log delivery status.
        /// 0: shipping disabled; 1: shipping enabled; 2: shipping activating; 3: shipping disabling
        /// </summary>
        [JsonProperty("LogDeliveryStatus")]
        public long? LogDeliveryStatus{ get; set; }

        /// <summary>
        /// The causes for the log audit being forbidden to enable. Available values: VersionNotSupportLogSubscription, InstanceIsUpgrading, CdbRuleAuditEnabled
        /// </summary>
        [JsonProperty("LogDeliveryDisableReason")]
        public string LogDeliveryDisableReason{ get; set; }

        /// <summary>
        /// Total number of logs for the current instance.
        /// </summary>
        [JsonProperty("TotalAuditLogs")]
        public ulong? TotalAuditLogs{ get; set; }

        /// <summary>
        /// Number of recognized sensitive data items
        /// </summary>
        [JsonProperty("DataScanDetailRuleCount")]
        public ulong? DataScanDetailRuleCount{ get; set; }

        /// <summary>
        /// Operation error information
        /// </summary>
        [JsonProperty("OperationErrorMsg")]
        public string OperationErrorMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IdentifyScanSupported", this.IdentifyScanSupported);
            this.SetParamSimple(map, prefix + "LogDeliverySupported", this.LogDeliverySupported);
            this.SetParamSimple(map, prefix + "SecurityAnalyseStatus", this.SecurityAnalyseStatus);
            this.SetParamSimple(map, prefix + "LogDeliveryStatus", this.LogDeliveryStatus);
            this.SetParamSimple(map, prefix + "LogDeliveryDisableReason", this.LogDeliveryDisableReason);
            this.SetParamSimple(map, prefix + "TotalAuditLogs", this.TotalAuditLogs);
            this.SetParamSimple(map, prefix + "DataScanDetailRuleCount", this.DataScanDetailRuleCount);
            this.SetParamSimple(map, prefix + "OperationErrorMsg", this.OperationErrorMsg);
        }
    }
}

