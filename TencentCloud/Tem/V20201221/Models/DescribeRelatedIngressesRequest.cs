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

namespace TencentCloud.Tem.V20201221.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRelatedIngressesRequest : AbstractModel
    {
        
        /// <summary>
        /// Environment ID.
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// EKS namespace.
        /// </summary>
        [JsonProperty("EksNamespace")]
        public string EksNamespace{ get; set; }

        /// <summary>
        /// Source channel.
        /// </summary>
        [JsonProperty("SourceChannel")]
        public long? SourceChannel{ get; set; }

        /// <summary>
        /// Service ID.
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "EksNamespace", this.EksNamespace);
            this.SetParamSimple(map, prefix + "SourceChannel", this.SourceChannel);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
        }
    }
}

