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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricCollectConfig : AbstractModel
    {
        
        /// <summary>
        /// Collection configuration ID.
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// Log topic ID.
        /// </summary>
        [JsonProperty("TopicIds")]
        public string[] TopicIds{ get; set; }

        /// <summary>
        /// Collection configuration source. Support: `0`, `1`.
        /// -0: Self-build k8s
        /// - 1:TKE
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// Machine group ID.
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// Monitoring type. Supported values: `0`, `1`. Cannot be modified.
        /// 
        /// -0: Basic monitoring
        /// -Custom monitoring
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Collection configuration method. Supports `0` and `1`. Cannot be modified.
        /// -0: Ordinary setting method. The Type field is only for: `1`
        /// -YAML import method, Type can be `0` or `1`.
        /// </summary>
        [JsonProperty("Flag")]
        public ulong? Flag{ get; set; }

        /// <summary>
        /// Name: Length not exceeding 253 characters, check format `[a-z0-9]([-a-z0-9]*[a-z0-9])?(\.[a-z0-9]([-a-z0-9]*[a-z0-9])?)*`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Collection object. This parameter is valid only when Flag is 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Spec")]
        public MetricSpec Spec{ get; set; }

        /// <summary>
        /// Label processing. This parameter is valid only when Flag is 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetricRelabels")]
        public Relabeling[] MetricRelabels{ get; set; }

        /// <summary>
        /// Custom metadata. This parameter is valid only when Flag is 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetricLabel")]
        public MetricConfigLabel MetricLabel{ get; set; }

        /// <summary>
        /// Communication protocol. Valid values: HTTP and HTTPS. This parameter is valid only when Flag is 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// Collection frequency. This parameter is valid only when Flag is 0.
        /// -Check format: `^(((\d+)y)?((\d+)w)?((\d+)d)?((\d+)h)?((\d+)m)?((\d+)s)?((\d+)ms)?|0)$`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScrapeInterval")]
        public string ScrapeInterval{ get; set; }

        /// <summary>
        /// Collection timeout. This parameter is valid only when Flag=0 && Type=1.
        /// - format:`^(((\d+)y)?((\d+)w)?((\d+)d)?((\d+)h)?((\d+)m)?((\d+)s)?((\d+)ms)?|0)$`
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScrapeTimeout")]
        public string ScrapeTimeout{ get; set; }

        /// <summary>
        /// How Prometheus handles tag conflicts. When Flag=0 takes effect, `true` and `false` are supported.
        /// 
        /// - `false`: Rename conflicting tags in configuration data
        /// -`true`: Ignore server-side tag conflicts
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HonorLabels")]
        public bool? HonorLabels{ get; set; }

        /// <summary>
        /// Collection configuration, which is a string in YAML format. It is required when Flag is 1.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("YamlSpec")]
        public MetricYamlSpec YamlSpec{ get; set; }

        /// <summary>
        /// Operation status. Valid values: 0: applied; 1: paused.
        /// </summary>
        [JsonProperty("Operate")]
        public ulong? Operate{ get; set; }

        /// <summary>
        /// Creation time (a second-level timestamp).
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Update timestamp (second-level).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamArraySimple(map, prefix + "TopicIds.", this.TopicIds);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Spec.", this.Spec);
            this.SetParamArrayObj(map, prefix + "MetricRelabels.", this.MetricRelabels);
            this.SetParamObj(map, prefix + "MetricLabel.", this.MetricLabel);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "ScrapeInterval", this.ScrapeInterval);
            this.SetParamSimple(map, prefix + "ScrapeTimeout", this.ScrapeTimeout);
            this.SetParamSimple(map, prefix + "HonorLabels", this.HonorLabels);
            this.SetParamObj(map, prefix + "YamlSpec.", this.YamlSpec);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

