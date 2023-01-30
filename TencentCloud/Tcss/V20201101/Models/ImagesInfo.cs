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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImagesInfo : AbstractModel
    {
        
        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Image size
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// Number of servers
        /// </summary>
        [JsonProperty("HostCnt")]
        public ulong? HostCnt{ get; set; }

        /// <summary>
        /// Number of containers
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// Scan time
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// Number of vulnerabilities
        /// </summary>
        [JsonProperty("VulCnt")]
        public ulong? VulCnt{ get; set; }

        /// <summary>
        /// Number of viruses
        /// </summary>
        [JsonProperty("VirusCnt")]
        public ulong? VirusCnt{ get; set; }

        /// <summary>
        /// Number of sensitive data items
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// Whether it is a trusted image
        /// </summary>
        [JsonProperty("IsTrustImage")]
        public bool? IsTrustImage{ get; set; }

        /// <summary>
        /// Image system
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Image scan error in the agent
        /// </summary>
        [JsonProperty("AgentError")]
        public string AgentError{ get; set; }

        /// <summary>
        /// Image scan error on the backend
        /// </summary>
        [JsonProperty("ScanError")]
        public string ScanError{ get; set; }

        /// <summary>
        /// Scanning status
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// Trojan scan error message
        /// </summary>
        [JsonProperty("ScanVirusError")]
        public string ScanVirusError{ get; set; }

        /// <summary>
        /// Vulnerability scan error message
        /// </summary>
        [JsonProperty("ScanVulError")]
        public string ScanVulError{ get; set; }

        /// <summary>
        /// Risk scan error message
        /// </summary>
        [JsonProperty("ScanRiskError")]
        public string ScanRiskError{ get; set; }

        /// <summary>
        /// Whether the image is of high priority. Valid values: `0` (no); others (yes).
        /// </summary>
        [JsonProperty("IsSuggest")]
        public ulong? IsSuggest{ get; set; }

        /// <summary>
        /// Whether it is licensed. Valid values: `1` (yes); `0` (no).
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public ulong? IsAuthorized{ get; set; }

        /// <summary>
        /// Number of components
        /// </summary>
        [JsonProperty("ComponentCnt")]
        public ulong? ComponentCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "HostCnt", this.HostCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "VulCnt", this.VulCnt);
            this.SetParamSimple(map, prefix + "VirusCnt", this.VirusCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "IsTrustImage", this.IsTrustImage);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "AgentError", this.AgentError);
            this.SetParamSimple(map, prefix + "ScanError", this.ScanError);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "ScanVirusError", this.ScanVirusError);
            this.SetParamSimple(map, prefix + "ScanVulError", this.ScanVulError);
            this.SetParamSimple(map, prefix + "ScanRiskError", this.ScanRiskError);
            this.SetParamSimple(map, prefix + "IsSuggest", this.IsSuggest);
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
            this.SetParamSimple(map, prefix + "ComponentCnt", this.ComponentCnt);
        }
    }
}

