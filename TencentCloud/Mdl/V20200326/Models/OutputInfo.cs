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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputInfo : AbstractModel
    {
        
        /// <summary>
        /// Output name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Audio transcoding template name array.
        /// RTMP limit [0, 1], other limits [0, 20].
        /// </summary>
        [JsonProperty("AudioTemplateNames")]
        public string[] AudioTemplateNames{ get; set; }

        /// <summary>
        /// Video transcoding template name array, with the maximum number of [0, 1].
        /// </summary>
        [JsonProperty("VideoTemplateNames")]
        public string[] VideoTemplateNames{ get; set; }

        /// <summary>
        /// Scte-35 information configuration.
        /// </summary>
        [JsonProperty("Scte35Settings")]
        public Scte35SettingsInfo Scte35Settings{ get; set; }

        /// <summary>
        /// Audio/video transcoding template name array, with the maximum number of 1.
        /// </summary>
        [JsonProperty("AVTemplateNames")]
        public string[] AVTemplateNames{ get; set; }

        /// <summary>
        /// The used subtitle template is only valid for merge template.
        /// </summary>
        [JsonProperty("CaptionTemplateNames")]
        public string[] CaptionTemplateNames{ get; set; }

        /// <summary>
        /// Meta-information control configuration.
        /// </summary>
        [JsonProperty("TimedMetadataSettings")]
        public TimedMetadataSettingInfo TimedMetadataSettings{ get; set; }

        /// <summary>
        /// Screenshot transcode template name array. Limit: 1.
        /// </summary>
        [JsonProperty("FrameCaptureTemplateNames")]
        public string[] FrameCaptureTemplateNames{ get; set; }

        /// <summary>
        /// Modify the name of the sub-m3u8.
        /// </summary>
        [JsonProperty("NameModifier")]
        public string NameModifier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "AudioTemplateNames.", this.AudioTemplateNames);
            this.SetParamArraySimple(map, prefix + "VideoTemplateNames.", this.VideoTemplateNames);
            this.SetParamObj(map, prefix + "Scte35Settings.", this.Scte35Settings);
            this.SetParamArraySimple(map, prefix + "AVTemplateNames.", this.AVTemplateNames);
            this.SetParamArraySimple(map, prefix + "CaptionTemplateNames.", this.CaptionTemplateNames);
            this.SetParamObj(map, prefix + "TimedMetadataSettings.", this.TimedMetadataSettings);
            this.SetParamArraySimple(map, prefix + "FrameCaptureTemplateNames.", this.FrameCaptureTemplateNames);
            this.SetParamSimple(map, prefix + "NameModifier", this.NameModifier);
        }
    }
}

