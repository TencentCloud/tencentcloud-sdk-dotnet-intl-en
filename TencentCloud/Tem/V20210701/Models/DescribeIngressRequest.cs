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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIngressRequest : AbstractModel
    {
        
        /// <summary>
        /// Environment ID
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Environment namespace
        /// </summary>
        [JsonProperty("ClusterNamespace")]
        public string ClusterNamespace{ get; set; }

        /// <summary>
        /// Ingress rule name
        /// </summary>
        [JsonProperty("IngressName")]
        public string IngressName{ get; set; }

        /// <summary>
        /// Source channel
        /// </summary>
        [JsonProperty("SourceChannel")]
        public long? SourceChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "ClusterNamespace", this.ClusterNamespace);
            this.SetParamSimple(map, prefix + "IngressName", this.IngressName);
            this.SetParamSimple(map, prefix + "SourceChannel", this.SourceChannel);
        }
    }
}

