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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceServiceConfig : AbstractModel
    {
        
        /// <summary>
        /// Ports monitored by the model service.
        /// </summary>
        [JsonProperty("ListenPort")]
        public long? ListenPort{ get; set; }

        /// <summary>
        /// Request path list for inference service.
        /// </summary>
        [JsonProperty("RequestPaths")]
        public string[] RequestPaths{ get; set; }

        /// <summary>
        /// Container configuration of the inference service.
        /// </summary>
        [JsonProperty("Containers")]
        public InferenceContainerConfig[] Containers{ get; set; }

        /// <summary>
        /// Resource configuration of the inference service.
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public InferenceResourceConfig ResourceConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenPort", this.ListenPort);
            this.SetParamArraySimple(map, prefix + "RequestPaths.", this.RequestPaths);
            this.SetParamArrayObj(map, prefix + "Containers.", this.Containers);
            this.SetParamObj(map, prefix + "ResourceConfig.", this.ResourceConfig);
        }
    }
}

