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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceDiscoveryItem : AbstractModel
    {
        
        /// <summary>
        /// Scrape configuration name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Namespace of the scrape configuration
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Scrape configuration type: ServiceMonitor/PodMonitor
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// Namespace selection method
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NamespaceSelector")]
        public string NamespaceSelector{ get; set; }

        /// <summary>
        /// Label selection method
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Selector")]
        public string Selector{ get; set; }

        /// <summary>
        /// `Endpoints` information (PodMonitor does not have this parameter)
        /// </summary>
        [JsonProperty("Endpoints")]
        public string Endpoints{ get; set; }

        /// <summary>
        /// Scrape configuration information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Yaml")]
        public string Yaml{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "NamespaceSelector", this.NamespaceSelector);
            this.SetParamSimple(map, prefix + "Selector", this.Selector);
            this.SetParamSimple(map, prefix + "Endpoints", this.Endpoints);
            this.SetParamSimple(map, prefix + "Yaml", this.Yaml);
        }
    }
}

