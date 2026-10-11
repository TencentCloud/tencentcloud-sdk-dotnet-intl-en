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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DynamicInstanceForm : AbstractModel
    {
        
        /// <summary>
        /// <p>DynamicInstance name. The length is limited to 1–64 characters and can only contain lowercase letters.</p>
        /// </summary>
        [JsonProperty("DynamicInstanceName")]
        public string DynamicInstanceName{ get; set; }

        /// <summary>
        /// <p>Namespace.</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>Whether high availability is supported.</p>
        /// </summary>
        [JsonProperty("SupportHA")]
        public bool? SupportHA{ get; set; }

        /// <summary>
        /// <p>Custom image information.</p>
        /// </summary>
        [JsonProperty("CustomImage")]
        public CustomImage CustomImage{ get; set; }

        /// <summary>
        /// <p>Resource group configuration.</p>
        /// </summary>
        [JsonProperty("DynamicInstanceGroups")]
        public DynamicInstanceGroup[] DynamicInstanceGroups{ get; set; }

        /// <summary>
        /// <p>Whether to support storage configuration.</p>
        /// </summary>
        [JsonProperty("SupportPV")]
        public bool? SupportPV{ get; set; }

        /// <summary>
        /// <p>CBS storage volume list.</p>
        /// </summary>
        [JsonProperty("CBSVolumes")]
        public CBSVolume[] CBSVolumes{ get; set; }

        /// <summary>
        /// <p>CFS storage volume list, including only CFS but not CFS Turbo.</p>
        /// </summary>
        [JsonProperty("CFSVolumes")]
        public CFSVolume[] CFSVolumes{ get; set; }

        /// <summary>
        /// <p>COS storage volume list.</p>
        /// </summary>
        [JsonProperty("COSVolumes")]
        public COSVolume[] COSVolumes{ get; set; }

        /// <summary>
        /// <p>Mount volume list.</p>
        /// </summary>
        [JsonProperty("VolumeMounts")]
        public VolumeMount[] VolumeMounts{ get; set; }

        /// <summary>
        /// <p>Pod label.</p>
        /// </summary>
        [JsonProperty("Labels")]
        public TkeLabel[] Labels{ get; set; }

        /// <summary>
        /// <p>Tolerations definition.</p>
        /// </summary>
        [JsonProperty("Tolerations")]
        public Toleration[] Tolerations{ get; set; }

        /// <summary>
        /// <p>Environment variable.</p>
        /// </summary>
        [JsonProperty("Envs")]
        public NameValue[] Envs{ get; set; }

        /// <summary>
        /// <p>Dependent external components.</p>
        /// </summary>
        [JsonProperty("DependServices")]
        public DependService[] DependServices{ get; set; }

        /// <summary>
        /// <p>Whether to enable token authentication.</p>
        /// </summary>
        [JsonProperty("SupportToken")]
        public bool? SupportToken{ get; set; }

        /// <summary>
        /// <p>CFS Turbo mount list, excluding the standard edition CFS.</p>
        /// </summary>
        [JsonProperty("CFSTurboVolumes")]
        public CFSTurboVolume[] CFSTurboVolumes{ get; set; }

        /// <summary>
        /// <p>Custom image.</p>
        /// </summary>
        [JsonProperty("ImageInfoV2")]
        public ImageInfoV2 ImageInfoV2{ get; set; }

        /// <summary>
        /// <p>GooseFS disk.</p>
        /// </summary>
        [JsonProperty("GooseFSVolumes")]
        public GooseFSVolume[] GooseFSVolumes{ get; set; }

        /// <summary>
        /// <p>Enable HistoryServer.</p>
        /// </summary>
        [JsonProperty("EnableHistoryServer")]
        public bool? EnableHistoryServer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DynamicInstanceName", this.DynamicInstanceName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamObj(map, prefix + "CustomImage.", this.CustomImage);
            this.SetParamArrayObj(map, prefix + "DynamicInstanceGroups.", this.DynamicInstanceGroups);
            this.SetParamSimple(map, prefix + "SupportPV", this.SupportPV);
            this.SetParamArrayObj(map, prefix + "CBSVolumes.", this.CBSVolumes);
            this.SetParamArrayObj(map, prefix + "CFSVolumes.", this.CFSVolumes);
            this.SetParamArrayObj(map, prefix + "COSVolumes.", this.COSVolumes);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "DependServices.", this.DependServices);
            this.SetParamSimple(map, prefix + "SupportToken", this.SupportToken);
            this.SetParamArrayObj(map, prefix + "CFSTurboVolumes.", this.CFSTurboVolumes);
            this.SetParamObj(map, prefix + "ImageInfoV2.", this.ImageInfoV2);
            this.SetParamArrayObj(map, prefix + "GooseFSVolumes.", this.GooseFSVolumes);
            this.SetParamSimple(map, prefix + "EnableHistoryServer", this.EnableHistoryServer);
        }
    }
}

