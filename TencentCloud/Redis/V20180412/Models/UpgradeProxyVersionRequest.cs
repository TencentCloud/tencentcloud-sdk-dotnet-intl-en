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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeProxyVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [Redis console](https://console.tencentcloud.com/redis/instance) and copy it in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Current proxy version. Call the [DescribeInstances](https://www.tencentcloud.comom/document/product/239/20018?from_cn_redirect=1) API to obtain the current proxy version for the instance.
        /// </summary>
        [JsonProperty("CurrentProxyVersion")]
        public string CurrentProxyVersion{ get; set; }

        /// <summary>
        /// Upgradable Redis version. Call the [DescribeInstances](https://www.tencentcloud.comom/document/product/239/20018?from_cn_redirect=1) API to obtain the upgradable Redis version for the instance.
        /// </summary>
        [JsonProperty("UpgradeProxyVersion")]
        public string UpgradeProxyVersion{ get; set; }

        /// <summary>
        /// Specifies whether to upgrade immediately.
        /// - 1: Upgrade immediately.
        /// - 0: Upgrade during the maintenance window.
        /// </summary>
        [JsonProperty("InstanceTypeUpgradeNow")]
        public long? InstanceTypeUpgradeNow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CurrentProxyVersion", this.CurrentProxyVersion);
            this.SetParamSimple(map, prefix + "UpgradeProxyVersion", this.UpgradeProxyVersion);
            this.SetParamSimple(map, prefix + "InstanceTypeUpgradeNow", this.InstanceTypeUpgradeNow);
        }
    }
}

