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

    public class DescribeTcssSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of images
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// Number of scanned images
        /// </summary>
        [JsonProperty("ScannedImageCnt")]
        public ulong? ScannedImageCnt{ get; set; }

        /// <summary>
        /// Number of images to be scanned
        /// </summary>
        [JsonProperty("UnScannedImageCnt")]
        public ulong? UnScannedImageCnt{ get; set; }

        /// <summary>
        /// Number of local images
        /// </summary>
        [JsonProperty("LocalImageCnt")]
        public ulong? LocalImageCnt{ get; set; }

        /// <summary>
        /// Number of repository images
        /// </summary>
        [JsonProperty("RepositoryImageCnt")]
        public ulong? RepositoryImageCnt{ get; set; }

        /// <summary>
        /// Number of local images at risk
        /// </summary>
        [JsonProperty("RiskLocalImageCnt")]
        public ulong? RiskLocalImageCnt{ get; set; }

        /// <summary>
        /// Number of repository images at risk
        /// </summary>
        [JsonProperty("RiskRepositoryImageCnt")]
        public ulong? RiskRepositoryImageCnt{ get; set; }

        /// <summary>
        /// Number of containers
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// Number of containers at risk
        /// </summary>
        [JsonProperty("RiskContainerCnt")]
        public ulong? RiskContainerCnt{ get; set; }

        /// <summary>
        /// Number of clusters
        /// </summary>
        [JsonProperty("ClusterCnt")]
        public ulong? ClusterCnt{ get; set; }

        /// <summary>
        /// Number of clusters at risk
        /// </summary>
        [JsonProperty("RiskClusterCnt")]
        public ulong? RiskClusterCnt{ get; set; }

        /// <summary>
        /// Number of vulnerabilities to be scanned
        /// </summary>
        [JsonProperty("UnScannedVulCnt")]
        public ulong? UnScannedVulCnt{ get; set; }

        /// <summary>
        /// Number of risk vulnerabilities
        /// </summary>
        [JsonProperty("RiskVulCnt")]
        public ulong? RiskVulCnt{ get; set; }

        /// <summary>
        /// Number of security baseline items to be scanned
        /// </summary>
        [JsonProperty("UnScannedBaseLineCnt")]
        public ulong? UnScannedBaseLineCnt{ get; set; }

        /// <summary>
        /// Number of security baseline risks
        /// </summary>
        [JsonProperty("RiskBaseLineCnt")]
        public ulong? RiskBaseLineCnt{ get; set; }

        /// <summary>
        /// Number of pending (high-risk) events at runtime
        /// </summary>
        [JsonProperty("RuntimeUnhandleEventCnt")]
        public ulong? RuntimeUnhandleEventCnt{ get; set; }

        /// <summary>
        /// Number of clusters to be scanned
        /// </summary>
        [JsonProperty("UnScannedClusterCnt")]
        public ulong? UnScannedClusterCnt{ get; set; }

        /// <summary>
        /// Whether images are scanned
        /// </summary>
        [JsonProperty("ScanImageStatus")]
        public bool? ScanImageStatus{ get; set; }

        /// <summary>
        /// Whether clusters are scanned
        /// </summary>
        [JsonProperty("ScanClusterStatus")]
        public bool? ScanClusterStatus{ get; set; }

        /// <summary>
        /// Whether baseline items are scanned
        /// </summary>
        [JsonProperty("ScanBaseLineStatus")]
        public bool? ScanBaseLineStatus{ get; set; }

        /// <summary>
        /// Whether vulnerabilities are scanned for
        /// </summary>
        [JsonProperty("ScanVulStatus")]
        public bool? ScanVulStatus{ get; set; }

        /// <summary>
        /// Number of images affected by vulnerabilities
        /// </summary>
        [JsonProperty("VulRiskImageCnt")]
        public ulong? VulRiskImageCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "ScannedImageCnt", this.ScannedImageCnt);
            this.SetParamSimple(map, prefix + "UnScannedImageCnt", this.UnScannedImageCnt);
            this.SetParamSimple(map, prefix + "LocalImageCnt", this.LocalImageCnt);
            this.SetParamSimple(map, prefix + "RepositoryImageCnt", this.RepositoryImageCnt);
            this.SetParamSimple(map, prefix + "RiskLocalImageCnt", this.RiskLocalImageCnt);
            this.SetParamSimple(map, prefix + "RiskRepositoryImageCnt", this.RiskRepositoryImageCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "RiskContainerCnt", this.RiskContainerCnt);
            this.SetParamSimple(map, prefix + "ClusterCnt", this.ClusterCnt);
            this.SetParamSimple(map, prefix + "RiskClusterCnt", this.RiskClusterCnt);
            this.SetParamSimple(map, prefix + "UnScannedVulCnt", this.UnScannedVulCnt);
            this.SetParamSimple(map, prefix + "RiskVulCnt", this.RiskVulCnt);
            this.SetParamSimple(map, prefix + "UnScannedBaseLineCnt", this.UnScannedBaseLineCnt);
            this.SetParamSimple(map, prefix + "RiskBaseLineCnt", this.RiskBaseLineCnt);
            this.SetParamSimple(map, prefix + "RuntimeUnhandleEventCnt", this.RuntimeUnhandleEventCnt);
            this.SetParamSimple(map, prefix + "UnScannedClusterCnt", this.UnScannedClusterCnt);
            this.SetParamSimple(map, prefix + "ScanImageStatus", this.ScanImageStatus);
            this.SetParamSimple(map, prefix + "ScanClusterStatus", this.ScanClusterStatus);
            this.SetParamSimple(map, prefix + "ScanBaseLineStatus", this.ScanBaseLineStatus);
            this.SetParamSimple(map, prefix + "ScanVulStatus", this.ScanVulStatus);
            this.SetParamSimple(map, prefix + "VulRiskImageCnt", this.VulRiskImageCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

