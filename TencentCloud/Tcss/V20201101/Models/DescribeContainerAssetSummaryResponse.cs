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

    public class DescribeContainerAssetSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of containers
        /// </summary>
        [JsonProperty("ContainerTotalCnt")]
        public ulong? ContainerTotalCnt{ get; set; }

        /// <summary>
        /// Number of running containers
        /// </summary>
        [JsonProperty("ContainerRunningCnt")]
        public ulong? ContainerRunningCnt{ get; set; }

        /// <summary>
        /// Number of suspended containers
        /// </summary>
        [JsonProperty("ContainerPauseCnt")]
        public ulong? ContainerPauseCnt{ get; set; }

        /// <summary>
        /// Number of stopped containers
        /// </summary>
        [JsonProperty("ContainerStopped")]
        public ulong? ContainerStopped{ get; set; }

        /// <summary>
        /// Number of local images
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// Number of server nodes
        /// </summary>
        [JsonProperty("HostCnt")]
        public ulong? HostCnt{ get; set; }

        /// <summary>
        /// Number of running nodes on the server
        /// </summary>
        [JsonProperty("HostRunningCnt")]
        public ulong? HostRunningCnt{ get; set; }

        /// <summary>
        /// Number of offline nodes on the server
        /// </summary>
        [JsonProperty("HostOfflineCnt")]
        public ulong? HostOfflineCnt{ get; set; }

        /// <summary>
        /// Number of image repositories
        /// </summary>
        [JsonProperty("ImageRegistryCnt")]
        public ulong? ImageRegistryCnt{ get; set; }

        /// <summary>
        /// Total number of images
        /// </summary>
        [JsonProperty("ImageTotalCnt")]
        public ulong? ImageTotalCnt{ get; set; }

        /// <summary>
        /// Number of servers not installed with the agent
        /// </summary>
        [JsonProperty("HostUnInstallCnt")]
        public ulong? HostUnInstallCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "ContainerTotalCnt", this.ContainerTotalCnt);
            this.SetParamSimple(map, prefix + "ContainerRunningCnt", this.ContainerRunningCnt);
            this.SetParamSimple(map, prefix + "ContainerPauseCnt", this.ContainerPauseCnt);
            this.SetParamSimple(map, prefix + "ContainerStopped", this.ContainerStopped);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "HostCnt", this.HostCnt);
            this.SetParamSimple(map, prefix + "HostRunningCnt", this.HostRunningCnt);
            this.SetParamSimple(map, prefix + "HostOfflineCnt", this.HostOfflineCnt);
            this.SetParamSimple(map, prefix + "ImageRegistryCnt", this.ImageRegistryCnt);
            this.SetParamSimple(map, prefix + "ImageTotalCnt", this.ImageTotalCnt);
            this.SetParamSimple(map, prefix + "HostUnInstallCnt", this.HostUnInstallCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

