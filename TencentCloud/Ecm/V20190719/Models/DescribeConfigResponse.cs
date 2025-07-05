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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// Range of the network bandwidth disk size.
        /// </summary>
        [JsonProperty("NetworkStorageRange")]
        public NetworkStorageRange NetworkStorageRange{ get; set; }

        /// <summary>
        /// Image OS allowlist.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageWhiteSet")]
        public string[] ImageWhiteSet{ get; set; }

        /// <summary>
        /// Network quota information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceNetworkLimitConfigs")]
        public InstanceNetworkLimitConfig[] InstanceNetworkLimitConfigs{ get; set; }

        /// <summary>
        /// Image quota information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageLimits")]
        public ImageLimitConfig ImageLimits{ get; set; }

        /// <summary>
        /// Default IP direct access, used in scenarios with direct access parameters such as module creation and virtual machine purchase.
        /// </summary>
        [JsonProperty("DefaultIPDirect")]
        public bool? DefaultIPDirect{ get; set; }

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
            this.SetParamObj(map, prefix + "NetworkStorageRange.", this.NetworkStorageRange);
            this.SetParamArraySimple(map, prefix + "ImageWhiteSet.", this.ImageWhiteSet);
            this.SetParamArrayObj(map, prefix + "InstanceNetworkLimitConfigs.", this.InstanceNetworkLimitConfigs);
            this.SetParamObj(map, prefix + "ImageLimits.", this.ImageLimits);
            this.SetParamSimple(map, prefix + "DefaultIPDirect", this.DefaultIPDirect);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

