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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTranscodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Container format. Valid values: mp4, flv, hls, mp3, flac, ogg, m4a, and wav. Among them, mp3, flac, ogg, m4a, and wav are for audio-only files.</p>
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate VOD services from December 25, 2023, if they access resources in VOD applications (whether default or newly created), this field must be filled in as the app ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Transcoding template name. Length limit: 64 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Transcoding template description. Length limit: 256 characters.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Indicates whether to remove video data. Valid values:</p><li>0: Data is reserved.</li><li>1: Data is removed.</li>Default value: 0.
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// <p>Indicates whether to remove audio data. Valid values:</p><li>0: Data is reserved.</li><li>1: Data is removed.</li>Default value: 0.
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }

        /// <summary>
        /// <p>Video stream configuration parameters. This field is required when RemoveVideo is 0.</p>
        /// </summary>
        [JsonProperty("VideoTemplate")]
        public VideoTemplateInfo VideoTemplate{ get; set; }

        /// <summary>
        /// <p>Audio stream configuration parameters. This field is required when RemoveAudio is 0.</p>
        /// </summary>
        [JsonProperty("AudioTemplate")]
        public AudioTemplateInfo AudioTemplate{ get; set; }

        /// <summary>
        /// <p>Top Speed Codec transcoding parameters.</p>
        /// </summary>
        [JsonProperty("TEHDConfig")]
        public TEHDConfig TEHDConfig{ get; set; }

        /// <summary>
        /// <p>Audio/video enhancement configurations.</p>
        /// </summary>
        [JsonProperty("EnhanceConfig")]
        public EnhanceConfig EnhanceConfig{ get; set; }

        /// <summary>
        /// <p>Segment type. Valid when Container is hls. Available values:</p><li>ts: ts slicing;</li><li>fmp4: fmp4 slicing.</li>Default value: ts.
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }

        /// <summary>
        /// <p>Extended parameter.</p>
        /// </summary>
        [JsonProperty("StdExtInfo")]
        public string StdExtInfo{ get; set; }


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
            this.SetParamObj(map, prefix + "EnhanceConfig.", this.EnhanceConfig);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "StdExtInfo", this.StdExtInfo);
        }
    }
}

