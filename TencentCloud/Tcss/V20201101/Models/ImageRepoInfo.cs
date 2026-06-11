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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageRepoInfo : AbstractModel
    {
        
        /// <summary>
        /// Image digest
        /// </summary>
        [JsonProperty("ImageDigest")]
        public string ImageDigest{ get; set; }

        /// <summary>
        /// Image repository address
        /// </summary>
        [JsonProperty("ImageRepoAddress")]
        public string ImageRepoAddress{ get; set; }

        /// <summary>
        /// Repository type
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Image tag
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// Image size
        /// </summary>
        [JsonProperty("ImageSize")]
        public ulong? ImageSize{ get; set; }

        /// <summary>
        /// Last scan time
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// Scanning status
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// Number of vulnerabilities
        /// </summary>
        [JsonProperty("VulCnt")]
        public ulong? VulCnt{ get; set; }

        /// <summary>
        /// Number of viruses and trojans
        /// </summary>
        [JsonProperty("VirusCnt")]
        public ulong? VirusCnt{ get; set; }

        /// <summary>
        /// Number of risky behaviors
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// Number of sensitive data items
        /// </summary>
        [JsonProperty("SentiveInfoCnt")]
        [System.Obsolete]
        public ulong? SentiveInfoCnt{ get; set; }

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
        /// Trojan scan error
        /// </summary>
        [JsonProperty("ScanVirusError")]
        public string ScanVirusError{ get; set; }

        /// <summary>
        /// Vulnerability scan error.
        /// </summary>
        [JsonProperty("ScanVulError")]
        public string ScanVulError{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// High risk scan error
        /// </summary>
        [JsonProperty("ScanRiskError")]
        public string ScanRiskError{ get; set; }

        /// <summary>
        /// Sensitive information scan progress
        /// </summary>
        [JsonProperty("ScanVirusProgress")]
        public ulong? ScanVirusProgress{ get; set; }

        /// <summary>
        /// Trojan scan progress.
        /// </summary>
        [JsonProperty("ScanVulProgress")]
        public ulong? ScanVulProgress{ get; set; }

        /// <summary>
        /// Vulnerability scan progress.
        /// </summary>
        [JsonProperty("ScanRiskProgress")]
        public ulong? ScanRiskProgress{ get; set; }

        /// <summary>
        /// Remaining scan time (seconds)
        /// </summary>
        [JsonProperty("ScanRemainTime")]
        public ulong? ScanRemainTime{ get; set; }

        /// <summary>
        /// cve scan status
        /// </summary>
        [JsonProperty("CveStatus")]
        public string CveStatus{ get; set; }

        /// <summary>
        /// High risk scan status
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// Trojan scan status
        /// </summary>
        [JsonProperty("VirusStatus")]
        public string VirusStatus{ get; set; }

        /// <summary>
        /// Overall progress
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// Licensing status
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public ulong? IsAuthorized{ get; set; }

        /// <summary>
        /// Repository region
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// List of IDs
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Image ID.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Image Creation Time
        /// </summary>
        [JsonProperty("ImageCreateTime")]
        public string ImageCreateTime{ get; set; }

        /// <summary>
        /// Whether the Latest Version of the Image
        /// </summary>
        [JsonProperty("IsLatestImage")]
        public bool? IsLatestImage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LowLevelVulCnt")]
        public ulong? LowLevelVulCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MediumLevelVulCnt")]
        public ulong? MediumLevelVulCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HighLevelVulCnt")]
        public ulong? HighLevelVulCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CriticalLevelVulCnt")]
        public ulong? CriticalLevelVulCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ComponentCnt")]
        public ulong? ComponentCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsRunning")]
        public bool? IsRunning{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HasNeedFixVul")]
        public bool? HasNeedFixVul{ get; set; }

        /// <summary>
        /// Sensitive information
        /// </summary>
        [JsonProperty("SensitiveInfoCnt")]
        public ulong? SensitiveInfoCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RecommendedFix")]
        public bool? RecommendedFix{ get; set; }

        /// <summary>
        /// Solution
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// <p>Reason.</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageDigest", this.ImageDigest);
            this.SetParamSimple(map, prefix + "ImageRepoAddress", this.ImageRepoAddress);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "VulCnt", this.VulCnt);
            this.SetParamSimple(map, prefix + "VirusCnt", this.VirusCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "SentiveInfoCnt", this.SentiveInfoCnt);
            this.SetParamSimple(map, prefix + "IsTrustImage", this.IsTrustImage);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "ScanVirusError", this.ScanVirusError);
            this.SetParamSimple(map, prefix + "ScanVulError", this.ScanVulError);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ScanRiskError", this.ScanRiskError);
            this.SetParamSimple(map, prefix + "ScanVirusProgress", this.ScanVirusProgress);
            this.SetParamSimple(map, prefix + "ScanVulProgress", this.ScanVulProgress);
            this.SetParamSimple(map, prefix + "ScanRiskProgress", this.ScanRiskProgress);
            this.SetParamSimple(map, prefix + "ScanRemainTime", this.ScanRemainTime);
            this.SetParamSimple(map, prefix + "CveStatus", this.CveStatus);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamSimple(map, prefix + "VirusStatus", this.VirusStatus);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageCreateTime", this.ImageCreateTime);
            this.SetParamSimple(map, prefix + "IsLatestImage", this.IsLatestImage);
            this.SetParamSimple(map, prefix + "LowLevelVulCnt", this.LowLevelVulCnt);
            this.SetParamSimple(map, prefix + "MediumLevelVulCnt", this.MediumLevelVulCnt);
            this.SetParamSimple(map, prefix + "HighLevelVulCnt", this.HighLevelVulCnt);
            this.SetParamSimple(map, prefix + "CriticalLevelVulCnt", this.CriticalLevelVulCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "ComponentCnt", this.ComponentCnt);
            this.SetParamSimple(map, prefix + "IsRunning", this.IsRunning);
            this.SetParamSimple(map, prefix + "HasNeedFixVul", this.HasNeedFixVul);
            this.SetParamSimple(map, prefix + "SensitiveInfoCnt", this.SensitiveInfoCnt);
            this.SetParamSimple(map, prefix + "RecommendedFix", this.RecommendedFix);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

