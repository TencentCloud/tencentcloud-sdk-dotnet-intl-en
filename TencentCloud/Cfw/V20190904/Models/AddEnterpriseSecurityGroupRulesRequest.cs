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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddEnterpriseSecurityGroupRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// Creates rule data
        /// </summary>
        [JsonProperty("Data")]
        public SecurityGroupRule[] Data{ get; set; }

        /// <summary>
        /// Adding type. 0: add to the end; 1: add to the front; 2: insert. Default: 0
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// An identifier to ensure the idempotency of the request. The value of the ClientToken parameter is a unique string that is generated by your client and can contain up to 64 ASCII characters in length.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Indicates whether to delay publishing. 1: delay; other values: do not delay
        /// </summary>
        [JsonProperty("IsDelay")]
        public ulong? IsDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "IsDelay", this.IsDelay);
        }
    }
}

