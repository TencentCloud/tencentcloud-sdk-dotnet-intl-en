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

    public class CreateServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// Custom service name. If this parameter is left empty, the system will automatically generate a unique name.
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Service frontend request type, such as `http`, `https`, and `http&https`.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Custom service description.
        /// </summary>
        [JsonProperty("ServiceDesc")]
        public string ServiceDesc{ get; set; }

        /// <summary>
        /// Self-deployed cluster name, which is used to specify the self-deployed cluster where the service is to be created.
        /// </summary>
        [JsonProperty("ExclusiveSetName")]
        public string ExclusiveSetName{ get; set; }

        /// <summary>
        /// Network type list, which is used to specify the supported network types. `INNER` indicates access over private network, and `OUTER` indicates access over public network. The default value is `OUTER`.
        /// </summary>
        [JsonProperty("NetTypes")]
        public string[] NetTypes{ get; set; }

        /// <summary>
        /// IP version number. Valid values: IPv4 (default value), IPv6
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// Cluster name, which is reserved and used by the `tsf serverless` type.
        /// </summary>
        [JsonProperty("SetServerName")]
        public string SetServerName{ get; set; }

        /// <summary>
        /// User type, which is reserved and can be used by `serverless` users.
        /// </summary>
        [JsonProperty("AppIdType")]
        public string AppIdType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ServiceDesc", this.ServiceDesc);
            this.SetParamSimple(map, prefix + "ExclusiveSetName", this.ExclusiveSetName);
            this.SetParamArraySimple(map, prefix + "NetTypes.", this.NetTypes);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "SetServerName", this.SetServerName);
            this.SetParamSimple(map, prefix + "AppIdType", this.AppIdType);
        }
    }
}

