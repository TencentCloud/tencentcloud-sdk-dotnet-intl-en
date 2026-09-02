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

    public class ImageAssetInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Image repository address</p>
        /// </summary>
        [JsonProperty("ImageRepoAddress")]
        public string ImageRepoAddress{ get; set; }

        /// <summary>
        /// <p>Image digests.</p>
        /// </summary>
        [JsonProperty("ImageDigest")]
        public string ImageDigest{ get; set; }

        /// <summary>
        /// <p>Image repository type</p>
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// <p>Image name.</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>Image tag</p>
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// <p>Image size.</p>
        /// </summary>
        [JsonProperty("ImageSize")]
        public ulong? ImageSize{ get; set; }

        /// <summary>
        /// <p>Last scan time</p><p>Parameter format: YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>Scan status</p><p>Enumeration values:</p><ul><li>INIT: Unscanned</li><li>SCANNING: Scanning</li><li>FINISH: Scan successful</li><li>TIMEOUT: Scan timeout</li><li>FAILED: Scan failure</li><li>STOPPING: Terminating</li><li>CANCELLED: Scan canceled</li><li>CREATING: Scan task under creation</li><li>LICENSE_NOT_ENOUGH: Insufficient license</li></ul>
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// <p>Number of vulnerabilities</p>
        /// </summary>
        [JsonProperty("VulCnt")]
        public ulong? VulCnt{ get; set; }

        /// <summary>
        /// <p>Number of Trojans</p>
        /// </summary>
        [JsonProperty("VirusCnt")]
        public ulong? VirusCnt{ get; set; }

        /// <summary>
        /// <p>Number of sensitive information entries.</p>
        /// </summary>
        [JsonProperty("SensitiveCnt")]
        public ulong? SensitiveCnt{ get; set; }

        /// <summary>
        /// <p>Image operating system</p>
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// <p>id of the associated repository instance</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Name of the associated mirror repository instance</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Namespace.</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>Whether to authorize</p>
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public ulong? IsAuthorized{ get; set; }

        /// <summary>
        /// <p>region where the image repository is located</p>
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// <p>id</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Image ID.</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>Image creation time</p><p>Parameter format: YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("ImageCreateTime")]
        public string ImageCreateTime{ get; set; }

        /// <summary>
        /// <p>Is it the latest image?</p>
        /// </summary>
        [JsonProperty("IsLatestImage")]
        public bool? IsLatestImage{ get; set; }

        /// <summary>
        /// <p>Number of low-risk vulnerabilities</p>
        /// </summary>
        [JsonProperty("LowLevelVulCnt")]
        public ulong? LowLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>Medium-risk vulnerability count</p>
        /// </summary>
        [JsonProperty("MediumLevelVulCnt")]
        public ulong? MediumLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>Number of high-risk vulnerabilities</p>
        /// </summary>
        [JsonProperty("HighLevelVulCnt")]
        public ulong? HighLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>Number of critical risk vulnerabilities</p>
        /// </summary>
        [JsonProperty("CriticalLevelVulCnt")]
        public ulong? CriticalLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>Associated account name</p>
        /// </summary>
        [JsonProperty("OwnerAccountName")]
        public string OwnerAccountName{ get; set; }

        /// <summary>
        /// <p>appid of the associated account</p>
        /// </summary>
        [JsonProperty("OwnerAppId")]
        public ulong? OwnerAppId{ get; set; }

        /// <summary>
        /// <p>Associated account uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>Number of low-risk trojans</p>
        /// </summary>
        [JsonProperty("LowLevelVirusCnt")]
        public ulong? LowLevelVirusCnt{ get; set; }

        /// <summary>
        /// <p>Number of medium-risk trojans</p>
        /// </summary>
        [JsonProperty("MediumLevelVirusCnt")]
        public ulong? MediumLevelVirusCnt{ get; set; }

        /// <summary>
        /// <p>Number of high-risk trojans</p>
        /// </summary>
        [JsonProperty("HighLevelVirusCnt")]
        public ulong? HighLevelVirusCnt{ get; set; }

        /// <summary>
        /// <p>Number of severe trojans</p>
        /// </summary>
        [JsonProperty("CriticalLevelVirusCnt")]
        public ulong? CriticalLevelVirusCnt{ get; set; }

        /// <summary>
        /// <p>Number of emergency vulnerabilities</p>
        /// </summary>
        [JsonProperty("EmergencyVulCnt")]
        public ulong? EmergencyVulCnt{ get; set; }

        /// <summary>
        /// <p>Number of low-risk sensitive data items</p>
        /// </summary>
        [JsonProperty("LowLevelSensitiveCnt")]
        public ulong? LowLevelSensitiveCnt{ get; set; }

        /// <summary>
        /// <p>Number of medium-risk sensitive data items</p>
        /// </summary>
        [JsonProperty("MediumLevelSensitiveCnt")]
        public ulong? MediumLevelSensitiveCnt{ get; set; }

        /// <summary>
        /// <p>Number of high-risk sensitive data items</p>
        /// </summary>
        [JsonProperty("HighLevelSensitiveCnt")]
        public ulong? HighLevelSensitiveCnt{ get; set; }

        /// <summary>
        /// <p>Number of severe sensitive data items</p>
        /// </summary>
        [JsonProperty("CriticalLevelSensitiveCnt")]
        public ulong? CriticalLevelSensitiveCnt{ get; set; }

        /// <summary>
        /// <p>Risk count</p>
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// <p>Scan failure reason</p>
        /// </summary>
        [JsonProperty("ScanFailReason")]
        public string ScanFailReason{ get; set; }

        /// <summary>
        /// <p>Solution to scan failure</p>
        /// </summary>
        [JsonProperty("ScanSolution")]
        public string ScanSolution{ get; set; }

        /// <summary>
        /// <p>Region information.</p>
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// <p>Most recent scan task Id.</p>
        /// </summary>
        [JsonProperty("ScanTaskId")]
        public ulong? ScanTaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageRepoAddress", this.ImageRepoAddress);
            this.SetParamSimple(map, prefix + "ImageDigest", this.ImageDigest);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "VulCnt", this.VulCnt);
            this.SetParamSimple(map, prefix + "VirusCnt", this.VirusCnt);
            this.SetParamSimple(map, prefix + "SensitiveCnt", this.SensitiveCnt);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
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
            this.SetParamSimple(map, prefix + "OwnerAccountName", this.OwnerAccountName);
            this.SetParamSimple(map, prefix + "OwnerAppId", this.OwnerAppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "LowLevelVirusCnt", this.LowLevelVirusCnt);
            this.SetParamSimple(map, prefix + "MediumLevelVirusCnt", this.MediumLevelVirusCnt);
            this.SetParamSimple(map, prefix + "HighLevelVirusCnt", this.HighLevelVirusCnt);
            this.SetParamSimple(map, prefix + "CriticalLevelVirusCnt", this.CriticalLevelVirusCnt);
            this.SetParamSimple(map, prefix + "EmergencyVulCnt", this.EmergencyVulCnt);
            this.SetParamSimple(map, prefix + "LowLevelSensitiveCnt", this.LowLevelSensitiveCnt);
            this.SetParamSimple(map, prefix + "MediumLevelSensitiveCnt", this.MediumLevelSensitiveCnt);
            this.SetParamSimple(map, prefix + "HighLevelSensitiveCnt", this.HighLevelSensitiveCnt);
            this.SetParamSimple(map, prefix + "CriticalLevelSensitiveCnt", this.CriticalLevelSensitiveCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "ScanFailReason", this.ScanFailReason);
            this.SetParamSimple(map, prefix + "ScanSolution", this.ScanSolution);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamSimple(map, prefix + "ScanTaskId", this.ScanTaskId);
        }
    }
}

