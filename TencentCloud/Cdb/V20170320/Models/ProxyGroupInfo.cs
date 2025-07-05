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

    public class ProxyGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// Proxy group ID
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// Proxy version Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyVersion")]
        public string ProxyVersion{ get; set; }

        /// <summary>
        /// Supported proxy upgrade version Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportUpgradeProxyVersion")]
        public string SupportUpgradeProxyVersion{ get; set; }

        /// <summary>
        /// Proxy status Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Proxy task status Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// Node information of the proxy group Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyNode")]
        public ProxyNode[] ProxyNode{ get; set; }

        /// <summary>
        /// Address information of the proxy group Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyAddress")]
        public ProxyAddress[] ProxyAddress{ get; set; }

        /// <summary>
        /// Connection pool threshold Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConnectionPoolLimit")]
        public ulong? ConnectionPoolLimit{ get; set; }

        /// <summary>
        /// Whether to support address creation Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportCreateProxyAddress")]
        public bool? SupportCreateProxyAddress{ get; set; }

        /// <summary>
        /// TencentDB versions supporting proxy versions upgrade Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SupportUpgradeProxyMysqlVersion")]
        public string SupportUpgradeProxyMysqlVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "ProxyVersion", this.ProxyVersion);
            this.SetParamSimple(map, prefix + "SupportUpgradeProxyVersion", this.SupportUpgradeProxyVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamArrayObj(map, prefix + "ProxyNode.", this.ProxyNode);
            this.SetParamArrayObj(map, prefix + "ProxyAddress.", this.ProxyAddress);
            this.SetParamSimple(map, prefix + "ConnectionPoolLimit", this.ConnectionPoolLimit);
            this.SetParamSimple(map, prefix + "SupportCreateProxyAddress", this.SupportCreateProxyAddress);
            this.SetParamSimple(map, prefix + "SupportUpgradeProxyMysqlVersion", this.SupportUpgradeProxyMysqlVersion);
        }
    }
}

