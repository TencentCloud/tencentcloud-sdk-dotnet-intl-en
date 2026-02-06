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

    public class VulRiskItem : AbstractModel
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
        /// Creation time.
        /// 
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// Vulnerability type.
        /// </summary>
        [JsonProperty("VulCategory")]
        public string VulCategory{ get; set; }

        /// <summary>
        /// Vulnerability level
        /// </summary>
        [JsonProperty("VulLevel")]
        public string VulLevel{ get; set; }

        /// <summary>
        /// CVE id.
        /// </summary>
        [JsonProperty("CveID")]
        public string CveID{ get; set; }

        /// <summary>
        /// Vulnerability description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Container ID.
        /// </summary>
        [JsonProperty("ContainerID")]
        public string ContainerID{ get; set; }

        /// <summary>
        /// Vulnerability risk remediation recommendation.
        /// </summary>
        [JsonProperty("Fix")]
        public string Fix{ get; set; }

        /// <summary>
        /// Linux vulnerability.
        /// </summary>
        [JsonProperty("VulCategoryName")]
        public string VulCategoryName{ get; set; }

        /// <summary>
        /// Vulnerability level name.
        /// </summary>
        [JsonProperty("VulLevelName")]
        public string VulLevelName{ get; set; }

        /// <summary>
        /// Instance status chinese information.
        /// </summary>
        [JsonProperty("InstanceStatusName")]
        public string InstanceStatusName{ get; set; }

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
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulCategory", this.VulCategory);
            this.SetParamSimple(map, prefix + "VulLevel", this.VulLevel);
            this.SetParamSimple(map, prefix + "CveID", this.CveID);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ContainerID", this.ContainerID);
            this.SetParamSimple(map, prefix + "Fix", this.Fix);
            this.SetParamSimple(map, prefix + "VulCategoryName", this.VulCategoryName);
            this.SetParamSimple(map, prefix + "VulLevelName", this.VulLevelName);
            this.SetParamSimple(map, prefix + "InstanceStatusName", this.InstanceStatusName);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
        }
    }
}

