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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTranscodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// The container format. Valid values: `mp4`, `flv`, `hls`, `mp3`, `flac`, `ogg`, `m4a`, `wav` ( `mp3`, `flac`, `ogg`, `m4a`, and `wav` are audio file formats).
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// <b>The VOD [subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID. If you need to access a resource in a subapplication, set this parameter to the subapplication ID; otherwise, leave it empty.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Transcoding template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Whether to remove video data. Valid values:
        /// <li>0: retain</li>
        /// <li>1: remove</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// Whether to remove audio data. Valid values:
        /// <li>0: retain</li>
        /// <li>1: remove</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }

        /// <summary>
        /// Video stream configuration parameter. This field is required when `RemoveVideo` is 0.
        /// </summary>
        [JsonProperty("VideoTemplate")]
        public VideoTemplateInfo VideoTemplate{ get; set; }

        /// <summary>
        /// Audio stream configuration parameter. This field is required when `RemoveAudio` is 0.
        /// </summary>
        [JsonProperty("AudioTemplate")]
        public AudioTemplateInfo AudioTemplate{ get; set; }

        /// <summary>
        /// TESHD transcoding parameter.
        /// </summary>
        [JsonProperty("TEHDConfig")]
        public TEHDConfig TEHDConfig{ get; set; }

        /// <summary>
        /// The segment type. This parameter is valid only if `Container` is `hls`. Valid values:
        /// <li>ts: TS segment</li>
        /// <li>fmp4: fMP4 segment</li>
        /// Default: ts
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
            this.SetParamObj(map, prefix + "VideoTemplate.", this.VideoTemplate);
            this.SetParamObj(map, prefix + "AudioTemplate.", this.AudioTemplate);
            this.SetParamObj(map, prefix + "TEHDConfig.", this.TEHDConfig);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
        }
    }
}

