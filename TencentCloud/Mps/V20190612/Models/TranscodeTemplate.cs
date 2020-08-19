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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranscodeTemplate : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of a transcoding template.
        /// </summary>
        [JsonProperty("Definition")]
        public string Definition{ get; set; }

        /// <summary>
        /// Container format. Valid values: mp4, flv, hls, mp3, flac, ogg.
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// Name of a transcoding template.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Template type. Valid values:
        /// <li>Preset: Preset template;</li>
        /// <li>Custom: Custom template.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Whether to remove video data. Valid values:
        /// <li>0: Retain;</li>
        /// <li>1: Remove.</li>
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// Whether to remove audio data. Valid values:
        /// <li>0: Retain;</li>
        /// <li>1: Remove.</li>
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }

        /// <summary>
        /// Video stream configuration parameter. This field is valid only when `RemoveVideo` is 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VideoTemplate")]
        public VideoTemplateInfo VideoTemplate{ get; set; }

        /// <summary>
        /// Audio stream configuration parameter. This field is valid only when `RemoveAudio` is 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AudioTemplate")]
        public AudioTemplateInfo AudioTemplate{ get; set; }

        /// <summary>
        /// TESHD transcoding parameter. To enable it, please contact your Tencent Cloud sales rep.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TEHDConfig")]
        public TEHDConfig TEHDConfig{ get; set; }

        /// <summary>
        /// Container format filter. Valid values:
        /// <li>Video: Video container format that can contain both video stream and audio stream;</li>
        /// <li>PureAudio: Audio container format that can contain only audio stream.</li>
        /// </summary>
        [JsonProperty("ContainerType")]
        public string ContainerType{ get; set; }

        /// <summary>
        /// Creation time of a template in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modified time of a template in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
            this.SetParamObj(map, prefix + "VideoTemplate.", this.VideoTemplate);
            this.SetParamObj(map, prefix + "AudioTemplate.", this.AudioTemplate);
            this.SetParamObj(map, prefix + "TEHDConfig.", this.TEHDConfig);
            this.SetParamSimple(map, prefix + "ContainerType", this.ContainerType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

