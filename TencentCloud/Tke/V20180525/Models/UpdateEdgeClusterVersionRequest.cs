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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateEdgeClusterVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Target version
        /// </summary>
        [JsonProperty("EdgeVersion")]
        public string EdgeVersion{ get; set; }

        /// <summary>
        /// Prefix of the image repository of a custom edge component
        /// </summary>
        [JsonProperty("RegistryPrefix")]
        public string RegistryPrefix{ get; set; }

        /// <summary>
        /// Whether to skip precheck
        /// </summary>
        [JsonProperty("SkipPreCheck")]
        public bool? SkipPreCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "EdgeVersion", this.EdgeVersion);
            this.SetParamSimple(map, prefix + "RegistryPrefix", this.RegistryPrefix);
            this.SetParamSimple(map, prefix + "SkipPreCheck", this.SkipPreCheck);
        }
    }
}

