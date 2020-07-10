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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBlockIPListRequest : AbstractModel
    {
        
        /// <summary>
        /// CLB instance ID
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// Operation type. Valid values:
        /// <li> add_customized_field (sets header initially to enable the blacklist feature)</li>
        /// <li> set_customized_field (modifies header)</li>
        /// <li> del_customized_field (deletes header)</li>
        /// <li> add_blocked (adds IPs to blacklist)</li>
        /// <li> del_blocked (deletes IPs from blacklist)</li>
        /// <li> flush_blocked (clears blacklist)</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Header field that stores real client IPs
        /// </summary>
        [JsonProperty("ClientIPField")]
        public string ClientIPField{ get; set; }

        /// <summary>
        /// List of blocked IPs. The array can contain up to 200,000 entries in one operation.
        /// </summary>
        [JsonProperty("BlockIPList")]
        public string[] BlockIPList{ get; set; }

        /// <summary>
        /// Expiration time in seconds. Default value: 3600
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// IP adding policy. Valid value: fifo (if a blacklist is full, new IPs added to the blacklist will adopt the first-in first-out policy)
        /// </summary>
        [JsonProperty("AddStrategy")]
        public string AddStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ClientIPField", this.ClientIPField);
            this.SetParamArraySimple(map, prefix + "BlockIPList.", this.BlockIPList);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AddStrategy", this.AddStrategy);
        }
    }
}

