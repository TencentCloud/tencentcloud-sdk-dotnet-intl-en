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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DestroyProxiesRequest : AbstractModel
    {
        
        /// <summary>
        /// The identifier for forced deletion
        /// 1: this connection list is deleted forcibly regardless of whether the origin server has been bound.
        /// 0: this connection list cannot be deleted if the origin server has been bound.
        /// If this identifier is 0, the deletion can be performed only when all the connections have not been bound to any origin servers.
        /// </summary>
        [JsonProperty("Force")]
        public long? Force{ get; set; }

        /// <summary>
        /// List of connection instance IDs; It's an old parameter, please switch to ProxyIds.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// A string used to ensure the idempotency of the request, which is generated by the user and must be unique to each request. The maximum length is 64 ASCII characters. If this parameter is not specified, the idempotency of the request cannot be guaranteed.
        /// For more information, please see How to Ensure Idempotence.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// List of connection instance IDs; It's a new parameter.
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Force", this.Force);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamArraySimple(map, prefix + "ProxyIds.", this.ProxyIds);
        }
    }
}

