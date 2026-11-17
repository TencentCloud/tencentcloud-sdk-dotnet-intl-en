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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RotateClusterTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Cluster type. Valid values: TKEServerless and TKE. Default value: TKE.</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>Operation to perform. Valid values: CreateNewToken, RevokeOldToken, and RecoverOldToken.<br>CreateNewToken: Creates a new token and makes it take effect. By default, a maximum of two tokens can take effect at the same time. If you want more tokens to take effect, Force must be set to true.<br>RevokeOldToken: Deletes the old token and makes it invalid. In this case, ClusterToken is required.<br>RecoverOldToken: Recovers the old token and makes it take effect. In this case, ClusterToken is required, and this operation can be called only when there is a corresponding RevokeOldToken task that has succeeded.</p>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// <p>Cluster token. It is required only when Operation is set to RevokeOldToken or RecoverOldToken.</p>
        /// </summary>
        [JsonProperty("ClusterToken")]
        public string ClusterToken{ get; set; }

        /// <summary>
        /// <p>Default value: false. It is required only when Operation is set to CreateNewToken. Only when it is set to true can more than two tokens take effect.</p>
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ClusterToken", this.ClusterToken);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}

