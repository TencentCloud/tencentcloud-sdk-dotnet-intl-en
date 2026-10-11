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

    public class ModifyDynamicInstanceForm : AbstractModel
    {
        
        /// <summary>
        /// <p>Update scope:<br>1: Add a worker group (DynamicInstance level)<br>2: Update storage configuration (DynamicInstance level)<br>3: Update tag configuration (DynamicInstance level)<br>4: Update advanced configuration (DynamicInstance level)<br>5: Update PodCpu and PodMem (DynamicInstance-group level)<br>6: Update PodNum, MinPodNum, and MaxPodNum (DynamicInstance-group level)<br>7: Update storage configuration (DynamicInstance-group level)<br>8: Update tag configuration (DynamicInstance-group level)</p>
        /// </summary>
        [JsonProperty("ModifyScope")]
        public long? ModifyScope{ get; set; }

        /// <summary>
        /// <p>Added worker group information.</p>
        /// </summary>
        [JsonProperty("AddDynamicInstanceGroup")]
        public DynamicInstanceGroup AddDynamicInstanceGroup{ get; set; }

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
        /// <p>CFS storage volume list, excluding the CFS Turbo list.</p>
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
        /// <p>Whether to generate a new token for authentication.</p>
        /// </summary>
        [JsonProperty("SupportNewToken")]
        public bool? SupportNewToken{ get; set; }

        /// <summary>
        /// <p>Update information at the DynamicInstance-group level.</p>
        /// </summary>
        [JsonProperty("ModifyDynamicInstanceGroup")]
        public DynamicInstanceGroup ModifyDynamicInstanceGroup{ get; set; }

        /// <summary>
        /// <p>CFS Turbo mount list, excluding the standard edition.</p>
        /// </summary>
        [JsonProperty("CFSTurboVolumes")]
        public CFSTurboVolume[] CFSTurboVolumes{ get; set; }

        /// <summary>
        /// <p>Custom image.</p>
        /// </summary>
        [JsonProperty("CustomImage")]
        public CustomImage CustomImage{ get; set; }

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
        /// <p>Whether to enable log collection.</p>
        /// </summary>
        [JsonProperty("EnableHistoryServer")]
        public bool? EnableHistoryServer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModifyScope", this.ModifyScope);
            this.SetParamObj(map, prefix + "AddDynamicInstanceGroup.", this.AddDynamicInstanceGroup);
            this.SetParamSimple(map, prefix + "SupportPV", this.SupportPV);
            this.SetParamArrayObj(map, prefix + "CBSVolumes.", this.CBSVolumes);
            this.SetParamArrayObj(map, prefix + "CFSVolumes.", this.CFSVolumes);
            this.SetParamArrayObj(map, prefix + "COSVolumes.", this.COSVolumes);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "DependServices.", this.DependServices);
            this.SetParamSimple(map, prefix + "SupportNewToken", this.SupportNewToken);
            this.SetParamObj(map, prefix + "ModifyDynamicInstanceGroup.", this.ModifyDynamicInstanceGroup);
            this.SetParamArrayObj(map, prefix + "CFSTurboVolumes.", this.CFSTurboVolumes);
            this.SetParamObj(map, prefix + "CustomImage.", this.CustomImage);
            this.SetParamObj(map, prefix + "ImageInfoV2.", this.ImageInfoV2);
            this.SetParamArrayObj(map, prefix + "GooseFSVolumes.", this.GooseFSVolumes);
            this.SetParamSimple(map, prefix + "EnableHistoryServer", this.EnableHistoryServer);
        }
    }
}

