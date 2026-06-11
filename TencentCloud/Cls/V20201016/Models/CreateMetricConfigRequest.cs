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

    public class CreateMetricConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Metric log topic id.
        /// - Obtain the log topic Id through [Get Log Topic List](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1). Note that BizType 0: log topic (default value), 1: metric topic.
        /// - Obtain the log topic Id through [Create Log Topic](https://www.tencentcloud.com/document/product/614/56456?from_cn_redirect=1). Note that BizType 0: log topic (default value), 1: metric topic.
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

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
        /// -0: Basic monitoring
        /// -Custom monitoring
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Collection configuration method. Supports `0`, `1`. Cannot be modified.
        /// -0: Ordinary setting method. The Type field is only for `1`.
        /// -YAML import method. Type can be `0` or `1`.
        /// </summary>
        [JsonProperty("Flag")]
        public ulong? Flag{ get; set; }

        /// <summary>
        /// Name: Length not exceeding 253 characters, check format `[a-z0-9]([-a-z0-9]*[a-z0-9])?(\.[a-z0-9]([-a-z0-9]*[a-z0-9])?)*`.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Collection object. This parameter is valid only when Flag is 0.
        /// </summary>
        [JsonProperty("Spec")]
        public MetricSpec Spec{ get; set; }

        /// <summary>
        /// Label processing. This parameter is valid only when Flag is 0.
        /// </summary>
        [JsonProperty("MetricRelabels")]
        public Relabeling[] MetricRelabels{ get; set; }

        /// <summary>
        /// Custom metadata. This parameter is valid only when Flag is 0.
        /// </summary>
        [JsonProperty("MetricLabel")]
        public MetricConfigLabel MetricLabel{ get; set; }

        /// <summary>
        /// Communication protocol. Valid values: HTTP and HTTPS. This parameter is valid only when Flag is 0.
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// Collection frequency. This parameter is valid only when Flag is 0.
        /// -Check format: `^(((\d+)y)?((\d+)w)?((\d+)d)?((\d+)h)?((\d+)m)?((\d+)s)?((\d+)ms)?|0)$`
        /// -Default: 60s
        /// </summary>
        [JsonProperty("ScrapeInterval")]
        public string ScrapeInterval{ get; set; }

        /// <summary>
        /// Collection timeout. This parameter is valid only when Flag is 0.
        /// -Check format: `^(((\d+)y)?((\d+)w)?((\d+)d)?((\d+)h)?((\d+)m)?((\d+)s)?((\d+)ms)?|0)$`
        /// -Default: 30s
        /// </summary>
        [JsonProperty("ScrapeTimeout")]
        public string ScrapeTimeout{ get; set; }

        /// <summary>
        /// How to handle tag conflicts. This parameter is valid only when Flag=0 and supports `true` and `false`.
        /// -`false`: Rename conflicting tags in configuration data
        /// -`true`: Ignore server-side tag conflicts
        /// </summary>
        [JsonProperty("HonorLabels")]
        public bool? HonorLabels{ get; set; }

        /// <summary>
        /// Collection configuration, which is a string in YAML format. It is required when Flag is 1.
        /// </summary>
        [JsonProperty("YamlSpec")]
        public MetricYamlSpec YamlSpec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
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
        }
    }
}

