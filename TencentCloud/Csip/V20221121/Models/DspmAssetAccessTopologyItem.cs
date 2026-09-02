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

    public class DspmAssetAccessTopologyItem : AbstractModel
    {
        
        /// <summary>
        /// Asset ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Asset type
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Asset name
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// Asset account
        /// </summary>
        [JsonProperty("AssetAccount")]
        public string AssetAccount{ get; set; }

        /// <summary>
        /// Host address
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Account type.
        /// </summary>
        [JsonProperty("AccountType")]
        public long? AccountType{ get; set; }

        /// <summary>
        /// Asset address
        /// </summary>
        [JsonProperty("AssetIp")]
        public string AssetIp{ get; set; }

        /// <summary>
        /// Origin ip address
        /// </summary>
        [JsonProperty("SourceIp")]
        public string SourceIp{ get; set; }

        /// <summary>
        /// Origin ip type
        /// </summary>
        [JsonProperty("SourceIpType")]
        public string SourceIpType{ get; set; }

        /// <summary>
        /// Access frequency (times/day)
        /// </summary>
        [JsonProperty("AccessFrequency")]
        public DspmFrequency AccessFrequency{ get; set; }

        /// <summary>
        /// SQL execution frequency. Queries/hr.
        /// </summary>
        [JsonProperty("ExecSQLFrequency")]
        public DspmFrequency ExecSQLFrequency{ get; set; }

        /// <summary>
        /// Access start time.
        /// </summary>
        [JsonProperty("AccessBeginTime")]
        public string AccessBeginTime{ get; set; }

        /// <summary>
        /// Access end time
        /// </summary>
        [JsonProperty("AccessEndTime")]
        public string AccessEndTime{ get; set; }

        /// <summary>
        /// Number of account risks
        /// </summary>
        [JsonProperty("AccountRisk")]
        public long? AccountRisk{ get; set; }

        /// <summary>
        /// Number of asset risks
        /// </summary>
        [JsonProperty("AssetRisk")]
        public long? AssetRisk{ get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Identity type. null for non-identity accounts. 0: Undefined; 2: Long-term identity; 3: Temporary identity
        /// </summary>
        [JsonProperty("IdentifyType")]
        public long? IdentifyType{ get; set; }

        /// <summary>
        /// uin of the user belonging to the cloud account.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public DspmUinUser OwnerUin{ get; set; }

        /// <summary>
        /// User information to which it belongs.
        /// </summary>
        [JsonProperty("Person")]
        public DspmPersonUser Person{ get; set; }

        /// <summary>
        /// Alarm count of the account
        /// </summary>
        [JsonProperty("AccountAlarm")]
        public long? AccountAlarm{ get; set; }

        /// <summary>
        /// Number of asset alarms
        /// </summary>
        [JsonProperty("AssetAlarm")]
        public long? AssetAlarm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetAccount", this.AssetAccount);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "AssetIp", this.AssetIp);
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamSimple(map, prefix + "SourceIpType", this.SourceIpType);
            this.SetParamObj(map, prefix + "AccessFrequency.", this.AccessFrequency);
            this.SetParamObj(map, prefix + "ExecSQLFrequency.", this.ExecSQLFrequency);
            this.SetParamSimple(map, prefix + "AccessBeginTime", this.AccessBeginTime);
            this.SetParamSimple(map, prefix + "AccessEndTime", this.AccessEndTime);
            this.SetParamSimple(map, prefix + "AccountRisk", this.AccountRisk);
            this.SetParamSimple(map, prefix + "AssetRisk", this.AssetRisk);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IdentifyType", this.IdentifyType);
            this.SetParamObj(map, prefix + "OwnerUin.", this.OwnerUin);
            this.SetParamObj(map, prefix + "Person.", this.Person);
            this.SetParamSimple(map, prefix + "AccountAlarm", this.AccountAlarm);
            this.SetParamSimple(map, prefix + "AssetAlarm", this.AssetAlarm);
        }
    }
}

