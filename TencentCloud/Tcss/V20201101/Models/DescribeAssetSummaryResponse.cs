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

    public class DescribeAssetSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of applications
        /// </summary>
        [JsonProperty("AppCnt")]
        public ulong? AppCnt{ get; set; }

        /// <summary>
        /// Number of containers
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// Number of paused containers
        /// </summary>
        [JsonProperty("ContainerPause")]
        public ulong? ContainerPause{ get; set; }

        /// <summary>
        /// Number of running containers
        /// </summary>
        [JsonProperty("ContainerRunning")]
        public ulong? ContainerRunning{ get; set; }

        /// <summary>
        /// Number of stopped containers
        /// </summary>
        [JsonProperty("ContainerStop")]
        public ulong? ContainerStop{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Number of databases
        /// </summary>
        [JsonProperty("DbCnt")]
        public ulong? DbCnt{ get; set; }

        /// <summary>
        /// Number of images
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// Number of online servers
        /// </summary>
        [JsonProperty("HostOnline")]
        public ulong? HostOnline{ get; set; }

        /// <summary>
        /// Number of servers
        /// </summary>
        [JsonProperty("HostCnt")]
        public ulong? HostCnt{ get; set; }

        /// <summary>
        /// Number of images at risk
        /// </summary>
        [JsonProperty("ImageHasRiskInfoCnt")]
        public ulong? ImageHasRiskInfoCnt{ get; set; }

        /// <summary>
        /// Number of images with viruses
        /// </summary>
        [JsonProperty("ImageHasVirusCnt")]
        public ulong? ImageHasVirusCnt{ get; set; }

        /// <summary>
        /// Number of images with vulnerabilities
        /// </summary>
        [JsonProperty("ImageHasVulsCnt")]
        public ulong? ImageHasVulsCnt{ get; set; }

        /// <summary>
        /// Number of untrusted images
        /// </summary>
        [JsonProperty("ImageUntrustCnt")]
        public ulong? ImageUntrustCnt{ get; set; }

        /// <summary>
        /// Number of listened ports
        /// </summary>
        [JsonProperty("ListenPortCnt")]
        public ulong? ListenPortCnt{ get; set; }

        /// <summary>
        /// Number of processes
        /// </summary>
        [JsonProperty("ProcessCnt")]
        public ulong? ProcessCnt{ get; set; }

        /// <summary>
        /// Number of web services
        /// </summary>
        [JsonProperty("WebServiceCnt")]
        public ulong? WebServiceCnt{ get; set; }

        /// <summary>
        /// Last image scan time
        /// </summary>
        [JsonProperty("LatestImageScanTime")]
        public string LatestImageScanTime{ get; set; }

        /// <summary>
        /// Number of images at risk
        /// </summary>
        [JsonProperty("ImageUnsafeCnt")]
        public ulong? ImageUnsafeCnt{ get; set; }

        /// <summary>
        /// Number of servers not installed with the agent
        /// </summary>
        [JsonProperty("HostUnInstallCnt")]
        public ulong? HostUnInstallCnt{ get; set; }

        /// <summary>
        /// Number of super nodes
        /// </summary>
        [JsonProperty("SuperNodeCnt")]
        public ulong? SuperNodeCnt{ get; set; }

        /// <summary>
        /// Number of running super nodes
        /// </summary>
        [JsonProperty("SuperNodeRunningCnt")]
        public ulong? SuperNodeRunningCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TodayNewImageCnt")]
        public ulong? TodayNewImageCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TodayUnsafeImageCnt")]
        public ulong? TodayUnsafeImageCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RecommendedFixImageCnt")]
        public ulong? RecommendedFixImageCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScannedImageCnt")]
        public ulong? ScannedImageCnt{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppCnt", this.AppCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "ContainerPause", this.ContainerPause);
            this.SetParamSimple(map, prefix + "ContainerRunning", this.ContainerRunning);
            this.SetParamSimple(map, prefix + "ContainerStop", this.ContainerStop);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DbCnt", this.DbCnt);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "HostOnline", this.HostOnline);
            this.SetParamSimple(map, prefix + "HostCnt", this.HostCnt);
            this.SetParamSimple(map, prefix + "ImageHasRiskInfoCnt", this.ImageHasRiskInfoCnt);
            this.SetParamSimple(map, prefix + "ImageHasVirusCnt", this.ImageHasVirusCnt);
            this.SetParamSimple(map, prefix + "ImageHasVulsCnt", this.ImageHasVulsCnt);
            this.SetParamSimple(map, prefix + "ImageUntrustCnt", this.ImageUntrustCnt);
            this.SetParamSimple(map, prefix + "ListenPortCnt", this.ListenPortCnt);
            this.SetParamSimple(map, prefix + "ProcessCnt", this.ProcessCnt);
            this.SetParamSimple(map, prefix + "WebServiceCnt", this.WebServiceCnt);
            this.SetParamSimple(map, prefix + "LatestImageScanTime", this.LatestImageScanTime);
            this.SetParamSimple(map, prefix + "ImageUnsafeCnt", this.ImageUnsafeCnt);
            this.SetParamSimple(map, prefix + "HostUnInstallCnt", this.HostUnInstallCnt);
            this.SetParamSimple(map, prefix + "SuperNodeCnt", this.SuperNodeCnt);
            this.SetParamSimple(map, prefix + "SuperNodeRunningCnt", this.SuperNodeRunningCnt);
            this.SetParamSimple(map, prefix + "TodayNewImageCnt", this.TodayNewImageCnt);
            this.SetParamSimple(map, prefix + "TodayUnsafeImageCnt", this.TodayUnsafeImageCnt);
            this.SetParamSimple(map, prefix + "RecommendedFixImageCnt", this.RecommendedFixImageCnt);
            this.SetParamSimple(map, prefix + "ScannedImageCnt", this.ScannedImageCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

