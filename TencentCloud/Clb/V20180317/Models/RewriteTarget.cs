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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RewriteTarget : AbstractModel
    {
        
        /// <summary>
        /// Listener ID of the redirection target. this field is valid only when redirection is configured.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetListenerId")]
        public string TargetListenerId{ get; set; }

        /// <summary>
        /// Specifies the forwarding rule ID of redirection target. field is valid only when redirection is configured.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetLocationId")]
        public string TargetLocationId{ get; set; }

        /// <summary>
        /// Specifies the redirection status code.
        /// </summary>
        [JsonProperty("RewriteCode")]
        public long? RewriteCode{ get; set; }

        /// <summary>
        /// Whether the matched URL is carried in redirection
        /// </summary>
        [JsonProperty("TakeUrl")]
        public bool? TakeUrl{ get; set; }

        /// <summary>
        /// Redirection type. Manual: Manual redirection; Auto: Automatic redirection
        /// </summary>
        [JsonProperty("RewriteType")]
        public string RewriteType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetListenerId", this.TargetListenerId);
            this.SetParamSimple(map, prefix + "TargetLocationId", this.TargetLocationId);
            this.SetParamSimple(map, prefix + "RewriteCode", this.RewriteCode);
            this.SetParamSimple(map, prefix + "TakeUrl", this.TakeUrl);
            this.SetParamSimple(map, prefix + "RewriteType", this.RewriteType);
        }
    }
}

