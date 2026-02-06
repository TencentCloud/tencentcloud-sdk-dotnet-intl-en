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

    public class HighBaseLineRiskItem : AbstractModel
    {
        
        /// <summary>
        /// Cloud account ID.
        /// </summary>
        [JsonProperty("CloudAccountID")]
        public string CloudAccountID{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("AssetID")]
        public string AssetID{ get; set; }

        /// <summary>
        /// Instance status
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Risk name.
        /// </summary>
        [JsonProperty("RiskName")]
        public string RiskName{ get; set; }

        /// <summary>
        /// Risk classification.
        /// </summary>
        [JsonProperty("RiskCategory")]
        public string RiskCategory{ get; set; }

        /// <summary>
        /// Risk level.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Risk description.
        /// </summary>
        [JsonProperty("RiskDesc")]
        public string RiskDesc{ get; set; }

        /// <summary>
        /// Risk result.
        /// </summary>
        [JsonProperty("RiskResult")]
        public string RiskResult{ get; set; }

        /// <summary>
        /// Fixing suggestion
        /// </summary>
        [JsonProperty("FixAdvice")]
        public string FixAdvice{ get; set; }

        /// <summary>
        /// Linux vulnerability.
        /// </summary>
        [JsonProperty("RiskCategoryName")]
        public string RiskCategoryName{ get; set; }

        /// <summary>
        /// Risk name.
        /// </summary>
        [JsonProperty("RiskLevelName")]
        public string RiskLevelName{ get; set; }

        /// <summary>
        /// Instance status
        /// </summary>
        [JsonProperty("InstanceStatusName")]
        public string InstanceStatusName{ get; set; }

        /// <summary>
        /// First detection time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last discovery time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Tenant ID.
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CloudAccountID", this.CloudAccountID);
            this.SetParamSimple(map, prefix + "AssetID", this.AssetID);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "RiskName", this.RiskName);
            this.SetParamSimple(map, prefix + "RiskCategory", this.RiskCategory);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RiskDesc", this.RiskDesc);
            this.SetParamSimple(map, prefix + "RiskResult", this.RiskResult);
            this.SetParamSimple(map, prefix + "FixAdvice", this.FixAdvice);
            this.SetParamSimple(map, prefix + "RiskCategoryName", this.RiskCategoryName);
            this.SetParamSimple(map, prefix + "RiskLevelName", this.RiskLevelName);
            this.SetParamSimple(map, prefix + "InstanceStatusName", this.InstanceStatusName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
        }
    }
}

