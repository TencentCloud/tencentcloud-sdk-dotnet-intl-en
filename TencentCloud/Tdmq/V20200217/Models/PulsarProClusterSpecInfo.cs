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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PulsarProClusterSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// Cluster specification name
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// Peak TPS
        /// </summary>
        [JsonProperty("MaxTps")]
        public ulong? MaxTps{ get; set; }

        /// <summary>
        /// Peak bandwidth in Mbps
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public ulong? MaxBandWidth{ get; set; }

        /// <summary>
        /// Maximum number of namespaces
        /// </summary>
        [JsonProperty("MaxNamespaces")]
        public ulong? MaxNamespaces{ get; set; }

        /// <summary>
        /// Maximum number of topics that can be created
        /// </summary>
        [JsonProperty("MaxTopics")]
        public ulong? MaxTopics{ get; set; }

        /// <summary>
        /// Elastic TPS beyond the specification
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScalableTps")]
        public ulong? ScalableTps{ get; set; }

        /// <summary>
        /// 32 or 128.
        /// Maximum number of partitions for topics in the current cluster.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxPartitions")]
        public ulong? MaxPartitions{ get; set; }

        /// <summary>
        /// Maximum delayed message count. 0 means no limit.	
        /// </summary>
        [JsonProperty("MaxDelayedMessages")]
        public long? MaxDelayedMessages{ get; set; }

        /// <summary>
        /// Maximum number of topic partitions that can be created
        /// </summary>
        [JsonProperty("MaxTopicsPartitioned")]
        public long? MaxTopicsPartitioned{ get; set; }

        /// <summary>
        /// Maximum number of connections per broker
        /// </summary>
        [JsonProperty("BrokerMaxConnections")]
        public long? BrokerMaxConnections{ get; set; }

        /// <summary>
        /// Maximum number of connections per IP
        /// </summary>
        [JsonProperty("BrokerMaxConnectionsPerIp")]
        public long? BrokerMaxConnectionsPerIp{ get; set; }

        /// <summary>
        /// Elastic storage cluster maximum storage specification; fixed storage is 0.
        /// </summary>
        [JsonProperty("MaximumElasticStorage")]
        public long? MaximumElasticStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "MaxTps", this.MaxTps);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
            this.SetParamSimple(map, prefix + "MaxNamespaces", this.MaxNamespaces);
            this.SetParamSimple(map, prefix + "MaxTopics", this.MaxTopics);
            this.SetParamSimple(map, prefix + "ScalableTps", this.ScalableTps);
            this.SetParamSimple(map, prefix + "MaxPartitions", this.MaxPartitions);
            this.SetParamSimple(map, prefix + "MaxDelayedMessages", this.MaxDelayedMessages);
            this.SetParamSimple(map, prefix + "MaxTopicsPartitioned", this.MaxTopicsPartitioned);
            this.SetParamSimple(map, prefix + "BrokerMaxConnections", this.BrokerMaxConnections);
            this.SetParamSimple(map, prefix + "BrokerMaxConnectionsPerIp", this.BrokerMaxConnectionsPerIp);
            this.SetParamSimple(map, prefix + "MaximumElasticStorage", this.MaximumElasticStorage);
        }
    }
}

