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

    public class ModifyTargetPortRequest : AbstractModel
    {
        
        /// <summary>
        /// CLB instance ID
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// CLB listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// List of real servers for which to modify the ports
        /// </summary>
        [JsonProperty("Targets")]
        public Target[] Targets{ get; set; }

        /// <summary>
        /// New port of the real server bound to the listener or forwarding rule
        /// </summary>
        [JsonProperty("NewPort")]
        public long? NewPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamArrayObj(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "NewPort", this.NewPort);
        }
    }
}

