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

    public class ModifyInferenceServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Zone ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Inference service ID.</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>Ports that the model service needs to monitor. Only integers between 1 and 65535 are supported.</p>
        /// </summary>
        [JsonProperty("ListenPort")]
        public long? ListenPort{ get; set; }

        /// <summary>
        /// <p>Request path list for the inference service. Supports up to 20 paths.</p>
        /// </summary>
        [JsonProperty("RequestPaths")]
        public string[] RequestPaths{ get; set; }

        /// <summary>
        /// <p>Container configuration for the inference service. Currently only support setting 1 container.</p>
        /// </summary>
        [JsonProperty("Containers")]
        public InferenceContainerConfigForModify[] Containers{ get; set; }

        /// <summary>
        /// <p>Resource configuration of the inference service.</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public InferenceResourceConfigForModify ResourceConfig{ get; set; }

        /// <summary>
        /// <p>Inference service affinity configuration</p>
        /// </summary>
        [JsonProperty("AffinityConfig")]
        public InferenceAffinityConfig AffinityConfig{ get; set; }

        /// <summary>
        /// <p>Description. Length limit: no more than 60 characters.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ListenPort", this.ListenPort);
            this.SetParamArraySimple(map, prefix + "RequestPaths.", this.RequestPaths);
            this.SetParamArrayObj(map, prefix + "Containers.", this.Containers);
            this.SetParamObj(map, prefix + "ResourceConfig.", this.ResourceConfig);
            this.SetParamObj(map, prefix + "AffinityConfig.", this.AffinityConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

