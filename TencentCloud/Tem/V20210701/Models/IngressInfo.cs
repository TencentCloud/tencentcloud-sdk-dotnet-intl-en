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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IngressInfo : AbstractModel
    {
        
        /// <summary>
        /// Environment ID
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Environment namespace
        /// </summary>
        [JsonProperty("ClusterNamespace")]
        public string ClusterNamespace{ get; set; }

        /// <summary>
        /// ip version
        /// </summary>
        [JsonProperty("AddressIPVersion")]
        public string AddressIPVersion{ get; set; }

        /// <summary>
        /// ingress name
        /// </summary>
        [JsonProperty("IngressName")]
        public string IngressName{ get; set; }

        /// <summary>
        /// Rules configuration
        /// </summary>
        [JsonProperty("Rules")]
        public IngressRule[] Rules{ get; set; }

        /// <summary>
        /// clb ID
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClbId")]
        public string ClbId{ get; set; }

        /// <summary>
        /// TLS configuration
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tls")]
        public IngressTls[] Tls{ get; set; }

        /// <summary>
        /// Environment cluster ID
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// clb ip
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Whether to listen on both the HTTP 80 port and HTTPS 443 port. The default value is `false`. The optional value `true` means listening on both the HTTP 80 port and HTTPS 443 port.
        /// </summary>
        [JsonProperty("Mixed")]
        public bool? Mixed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "ClusterNamespace", this.ClusterNamespace);
            this.SetParamSimple(map, prefix + "AddressIPVersion", this.AddressIPVersion);
            this.SetParamSimple(map, prefix + "IngressName", this.IngressName);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "ClbId", this.ClbId);
            this.SetParamArrayObj(map, prefix + "Tls.", this.Tls);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Mixed", this.Mixed);
        }
    }
}

