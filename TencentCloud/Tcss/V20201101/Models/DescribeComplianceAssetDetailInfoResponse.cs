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

    public class DescribeComplianceAssetDetailInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Asset details
        /// </summary>
        [JsonProperty("AssetDetailInfo")]
        public ComplianceAssetDetailInfo AssetDetailInfo{ get; set; }

        /// <summary>
        /// This field is returned when the asset is a container.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerDetailInfo")]
        public ComplianceContainerDetailInfo ContainerDetailInfo{ get; set; }

        /// <summary>
        /// This field is returned when the asset is an image.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageDetailInfo")]
        public ComplianceImageDetailInfo ImageDetailInfo{ get; set; }

        /// <summary>
        /// This field is returned when the asset is a server.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostDetailInfo")]
        public ComplianceHostDetailInfo HostDetailInfo{ get; set; }

        /// <summary>
        /// This field is returned when the asset is a K8s asset.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("K8SDetailInfo")]
        public ComplianceK8SDetailInfo K8SDetailInfo{ get; set; }

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
            this.SetParamObj(map, prefix + "AssetDetailInfo.", this.AssetDetailInfo);
            this.SetParamObj(map, prefix + "ContainerDetailInfo.", this.ContainerDetailInfo);
            this.SetParamObj(map, prefix + "ImageDetailInfo.", this.ImageDetailInfo);
            this.SetParamObj(map, prefix + "HostDetailInfo.", this.HostDetailInfo);
            this.SetParamObj(map, prefix + "K8SDetailInfo.", this.K8SDetailInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

