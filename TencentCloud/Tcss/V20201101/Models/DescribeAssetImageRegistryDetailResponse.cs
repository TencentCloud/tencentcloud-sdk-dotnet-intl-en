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

    public class DescribeAssetImageRegistryDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Image digest
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageDigest")]
        public string ImageDigest{ get; set; }

        /// <summary>
        /// Image address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageRepoAddress")]
        public string ImageRepoAddress{ get; set; }

        /// <summary>
        /// Image type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// Repository name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Image tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// Scan time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// Scanning status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// Number of vulnerabilities
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VulCnt")]
        public ulong? VulCnt{ get; set; }

        /// <summary>
        /// Number of viruses and trojans
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VirusCnt")]
        public ulong? VirusCnt{ get; set; }

        /// <summary>
        /// Number of risky behaviors
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// Number of sensitive data items
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SentiveInfoCnt")]
        public ulong? SentiveInfoCnt{ get; set; }

        /// <summary>
        /// Image system
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Trojan scan error
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanVirusError")]
        public string ScanVirusError{ get; set; }

        /// <summary>
        /// Vulnerability scan error
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanVulError")]
        public string ScanVulError{ get; set; }

        /// <summary>
        /// Layer file information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LayerInfo")]
        public string LayerInfo{ get; set; }

        /// <summary>
        /// Instance ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Namespace
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// High-risk scan error
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanRiskError")]
        public string ScanRiskError{ get; set; }

        /// <summary>
        /// Trojan scanning progress
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanVirusProgress")]
        public ulong? ScanVirusProgress{ get; set; }

        /// <summary>
        /// Vulnerability scanning progress
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanVulProgress")]
        public ulong? ScanVulProgress{ get; set; }

        /// <summary>
        /// Sensitive data scanning progress
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanRiskProgress")]
        public ulong? ScanRiskProgress{ get; set; }

        /// <summary>
        /// Remaining scan time in seconds
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScanRemainTime")]
        public ulong? ScanRemainTime{ get; set; }

        /// <summary>
        /// CVE scanning status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CveStatus")]
        public string CveStatus{ get; set; }

        /// <summary>
        /// High-risk scanning status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// Trojan scanning status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VirusStatus")]
        public string VirusStatus{ get; set; }

        /// <summary>
        /// Overall progress
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// Licensing status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public ulong? IsAuthorized{ get; set; }

        /// <summary>
        /// Image size
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageSize")]
        public ulong? ImageSize{ get; set; }

        /// <summary>
        /// Image ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Image region
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// Image creation time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageCreateTime")]
        public string ImageCreateTime{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


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
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "VulCnt", this.VulCnt);
            this.SetParamSimple(map, prefix + "VirusCnt", this.VirusCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "SentiveInfoCnt", this.SentiveInfoCnt);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "ScanVirusError", this.ScanVirusError);
            this.SetParamSimple(map, prefix + "ScanVulError", this.ScanVulError);
            this.SetParamSimple(map, prefix + "LayerInfo", this.LayerInfo);
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
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "ImageCreateTime", this.ImageCreateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

