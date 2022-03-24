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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpstreamNode : AbstractModel
    {
        
        /// <summary>
        /// IP or domain name of the host
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// The port number. Range: [0, 65535]
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Value range: [0, 100]. `0` refers to disable it.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// VM instance ID
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("VmInstanceId")]
        public string VmInstanceId{ get; set; }

        /// <summary>
        /// Tag
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Health status of the node. Value: `OFF`, `HEALTHY`, `UNHEALTHY` and `NO_DATA`. It’s not required for creating and editing actions.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Healthy")]
        public string Healthy{ get; set; }

        /// <summary>
        /// The K8s service name
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// K8s namespace
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("NameSpace")]
        public string NameSpace{ get; set; }

        /// <summary>
        /// ID of the TKE cluster
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Source of the node
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// The unique service name in API Gateway
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UniqueServiceName")]
        public string UniqueServiceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "VmInstanceId", this.VmInstanceId);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "UniqueServiceName", this.UniqueServiceName);
        }
    }
}

