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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrometheusClusterAgentBasic : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Cluster type
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Whether to enable public network CLB
        /// </summary>
        [JsonProperty("EnableExternal")]
        public bool? EnableExternal{ get; set; }

        /// <summary>
        /// Pod configurations of components deployed in the cluster
        /// </summary>
        [JsonProperty("InClusterPodConfig")]
        public PrometheusClusterAgentPodConfig InClusterPodConfig{ get; set; }

        /// <summary>
        /// External labels, which will be attached to all metrics collected by this cluster
        /// </summary>
        [JsonProperty("ExternalLabels")]
        public Label[] ExternalLabels{ get; set; }

        /// <summary>
        /// Whether to install the default collection configuration.
        /// </summary>
        [JsonProperty("NotInstallBasicScrape")]
        public bool? NotInstallBasicScrape{ get; set; }

        /// <summary>
        /// Whether to collect metrics (`true`: Drop all metrics; `false`: Collect default metrics)
        /// </summary>
        [JsonProperty("NotScrape")]
        public bool? NotScrape{ get; set; }

        /// <summary>
        /// Whether to enable the default recording rule
        /// </summary>
        [JsonProperty("OpenDefaultRecord")]
        public bool? OpenDefaultRecord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "EnableExternal", this.EnableExternal);
            this.SetParamObj(map, prefix + "InClusterPodConfig.", this.InClusterPodConfig);
            this.SetParamArrayObj(map, prefix + "ExternalLabels.", this.ExternalLabels);
            this.SetParamSimple(map, prefix + "NotInstallBasicScrape", this.NotInstallBasicScrape);
            this.SetParamSimple(map, prefix + "NotScrape", this.NotScrape);
            this.SetParamSimple(map, prefix + "OpenDefaultRecord", this.OpenDefaultRecord);
        }
    }
}

