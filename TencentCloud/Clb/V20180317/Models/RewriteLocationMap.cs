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

    public class RewriteLocationMap : AbstractModel
    {
        
        /// <summary>
        /// Source forwarding rule ID
        /// </summary>
        [JsonProperty("SourceLocationId")]
        public string SourceLocationId{ get; set; }

        /// <summary>
        /// ID of the forwarding rule of the destination
        /// </summary>
        [JsonProperty("TargetLocationId")]
        public string TargetLocationId{ get; set; }

        /// <summary>
        /// Redirection status code. Valid values: 301, 302, and 307.
        /// </summary>
        [JsonProperty("RewriteCode")]
        public long? RewriteCode{ get; set; }

        /// <summary>
        /// Whether the matched URL is carried in redirection. It is required when configuring `RewriteCode`.
        /// </summary>
        [JsonProperty("TakeUrl")]
        public bool? TakeUrl{ get; set; }

        /// <summary>
        /// Original domain name of redirection, which must be the corresponding domain name of `SourceLocationId`. It is required when configuring `RewriteCode`.
        /// </summary>
        [JsonProperty("SourceDomain")]
        public string SourceDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceLocationId", this.SourceLocationId);
            this.SetParamSimple(map, prefix + "TargetLocationId", this.TargetLocationId);
            this.SetParamSimple(map, prefix + "RewriteCode", this.RewriteCode);
            this.SetParamSimple(map, prefix + "TakeUrl", this.TakeUrl);
            this.SetParamSimple(map, prefix + "SourceDomain", this.SourceDomain);
        }
    }
}

