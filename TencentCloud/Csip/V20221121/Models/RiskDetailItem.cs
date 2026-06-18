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

    public class RiskDetailItem : AbstractModel
    {
        
        /// <summary>
        /// <p>First discovery time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Risk status</p>
        /// </summary>
        [JsonProperty("RiskStatus")]
        public long? RiskStatus{ get; set; }

        /// <summary>
        /// <p>Risk content</p>
        /// </summary>
        [JsonProperty("RiskContent")]
        public string RiskContent{ get; set; }

        /// <summary>
        /// <p>Cloud service provider</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>Vendor name</p>
        /// </summary>
        [JsonProperty("ProviderName")]
        public string ProviderName{ get; set; }

        /// <summary>
        /// <p>cloud account</p>
        /// </summary>
        [JsonProperty("CloudAccountId")]
        public string CloudAccountId{ get; set; }

        /// <summary>
        /// <p>Cloud account name</p>
        /// </summary>
        [JsonProperty("CloudAccountName")]
        public string CloudAccountName{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Instance name</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Risk ID</p>
        /// </summary>
        [JsonProperty("RiskId")]
        public ulong? RiskId{ get; set; }

        /// <summary>
        /// <p>Risk rule ID</p>
        /// </summary>
        [JsonProperty("RiskRuleId")]
        public string RiskRuleId{ get; set; }

        /// <summary>
        /// <p>Risk verification status</p>
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// <p>User AppID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>Asset type</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamSimple(map, prefix + "RiskContent", this.RiskContent);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "ProviderName", this.ProviderName);
            this.SetParamSimple(map, prefix + "CloudAccountId", this.CloudAccountId);
            this.SetParamSimple(map, prefix + "CloudAccountName", this.CloudAccountName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "RiskRuleId", this.RiskRuleId);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
        }
    }
}

