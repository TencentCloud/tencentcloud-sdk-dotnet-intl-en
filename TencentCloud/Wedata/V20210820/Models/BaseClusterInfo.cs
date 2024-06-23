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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaseClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Cluster Type, EMR/CDW, etc.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Cluster NameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Region Chinese
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RegionCn")]
        public string RegionCn{ get; set; }

        /// <summary>
        /// Region English
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RegionEn")]
        public string RegionEn{ get; set; }

        /// <summary>
        /// RegionNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RegionArea")]
        public string RegionArea{ get; set; }

        /// <summary>
        /// Whether the Cluster is Used
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Used")]
        public bool? Used{ get; set; }

        /// <summary>
        /// Cluster StatusNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Cluster State Information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StatusInfo")]
        public string StatusInfo{ get; set; }

        /// <summary>
        /// Cluster Storage Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// Cluster Computing Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ComputeType")]
        public string ComputeType{ get; set; }

        /// <summary>
        /// Cluster Resource Quantity
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterResource")]
        public string ClusterResource{ get; set; }

        /// <summary>
        /// Cluster Payment Method
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// Cluster Creation Time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Additional Configuration
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExtraConf")]
        public string ExtraConf{ get; set; }

        /// <summary>
        /// Ranger Account Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RangerUserName")]
        public string RangerUserName{ get; set; }

        /// <summary>
        /// CDW Account (for display)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CdwUserName")]
        public string CdwUserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "RegionCn", this.RegionCn);
            this.SetParamSimple(map, prefix + "RegionEn", this.RegionEn);
            this.SetParamSimple(map, prefix + "RegionArea", this.RegionArea);
            this.SetParamSimple(map, prefix + "Used", this.Used);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusInfo", this.StatusInfo);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "ComputeType", this.ComputeType);
            this.SetParamSimple(map, prefix + "ClusterResource", this.ClusterResource);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExtraConf", this.ExtraConf);
            this.SetParamSimple(map, prefix + "RangerUserName", this.RangerUserName);
            this.SetParamSimple(map, prefix + "CdwUserName", this.CdwUserName);
        }
    }
}

