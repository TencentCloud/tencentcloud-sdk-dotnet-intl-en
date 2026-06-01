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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdjustCdbProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Proxy group ID, which can be obtained through the [DescribeCdbProxyInfo](https://www.tencentcloud.com/document/api/236/90585?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// Node specification configuration
        /// Remark: Database proxy supported node specifications are 2C4000MB, 4C8000MB, 8C16000MB.
        /// Parameter description in the example.
        /// NodeCount: Number of nodes
        /// Region: Node region
        /// Zone: Node availability zone
        /// Cpu: Number of node cores for one agent (Unit: core)
        /// Mem: Memory size of each proxy node (unit: MB)
        /// </summary>
        [JsonProperty("ProxyNodeCustom")]
        public ProxyNodeCustom[] ProxyNodeCustom{ get; set; }

        /// <summary>
        /// Rebalance. Valid values:  `auto` (automatic), `manual` (manual).
        /// </summary>
        [JsonProperty("ReloadBalance")]
        public string ReloadBalance{ get; set; }

        /// <summary>
        /// The upgrade switch time. Valid values:  `nowTime` (upgrade immediately), `timeWindow` (upgrade during instance maintenance time).
        /// </summary>
        [JsonProperty("UpgradeTime")]
        public string UpgradeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamArrayObj(map, prefix + "ProxyNodeCustom.", this.ProxyNodeCustom);
            this.SetParamSimple(map, prefix + "ReloadBalance", this.ReloadBalance);
            this.SetParamSimple(map, prefix + "UpgradeTime", this.UpgradeTime);
        }
    }
}

