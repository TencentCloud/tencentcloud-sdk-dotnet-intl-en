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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkPeer : AbstractModel
    {
        
        /// <summary>
        /// Object type:
        /// 
        /// Namespace: `NamespaceSelector`, which indicates that `NamespaceSelector` has a value.
        /// 
        /// Pod type: `PodSelector`, which indicates that both `NamespaceSelector` and `PodSelector` have values.
        /// 
        /// IP type: `IPBlock`, which indicates that only `IPBlock` has a value.
        /// </summary>
        [JsonProperty("PeerType")]
        public string PeerType{ get; set; }

        /// <summary>
        /// Namespace selector
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NamespaceSelector")]
        public string NamespaceSelector{ get; set; }

        /// <summary>
        /// Pod selector
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PodSelector")]
        public string PodSelector{ get; set; }

        /// <summary>
        /// IP selector
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IPBlock")]
        public string IPBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PeerType", this.PeerType);
            this.SetParamSimple(map, prefix + "NamespaceSelector", this.NamespaceSelector);
            this.SetParamSimple(map, prefix + "PodSelector", this.PodSelector);
            this.SetParamSimple(map, prefix + "IPBlock", this.IPBlock);
        }
    }
}

