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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAdaptiveDynamicStreamingTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of an adaptive bitrate streaming template.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Adaptive bitrate streaming format. Valid values:
        /// <li>HLS,</li>
        /// <li>MPEG-DASH.</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Whether to prohibit transcoding from low bitrate to high bitrate. Valid values:
        /// <li>0: no,</li>
        /// <li>1: yes.</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoBitrate")]
        public ulong? DisableHigherVideoBitrate{ get; set; }

        /// <summary>
        /// Whether to prohibit transcoding from low resolution to high resolution. Valid values:
        /// <li>0: no,</li>
        /// <li>1: yes.</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoResolution")]
        public ulong? DisableHigherVideoResolution{ get; set; }

        /// <summary>
        /// Parameter information of input streams for transcoding to adaptive bitrate streaming. Up to 10 streams can be input.
        /// 
        /// Note:
        /// 
        /// 1. The frame rate of each stream must be consistent; otherwise, the frame rate of the first stream is used as the output frame rate.
        /// 2. When modifying substream information, all field values must be fully modified and added; otherwise, fields not filled in will use default values.
        /// </summary>
        [JsonProperty("StreamInfos")]
        public AdaptiveStreamTemplate[] StreamInfos{ get; set; }

        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Indicates whether it is audio-only. 0 means video template, 1 means audio-only template.
        /// When the value is 1.
        /// 1. StreamInfos.N.RemoveVideo=1
        /// 2. StreamInfos.N.RemoveAudio=0
        /// 3. StreamInfos.N.Video.Codec=copy
        /// When the value is 0.
        /// 1. StreamInfos.N.Video.Codec cannot be copy.
        /// 2. StreamInfos.N.Video.Fps cannot be null.
        /// 
        /// Note:
        /// 
        /// This value only distinguishes template types. The task uses the values of RemoveAudio and RemoveVideo.
        /// </summary>
        [JsonProperty("PureAudio")]
        public ulong? PureAudio{ get; set; }

        /// <summary>
        /// Segment type. Valid values: <li>ts-segment: HLS+TS segment</li>; <li>ts-byterange: HLS+TS byte range</li>; <li>mp4-segment: HLS+MP4 segment</li>; <li>mp4-byterange: HLS/DASH+MP4 byte range</li>; <li>ts-packed-audio: HLS+TS+Packed Audio segment</li>; <li>mp4-packed-audio: HLS+MP4+Packed Audio segment</li>; <li>ts-ts-segment: HLS+TS+TS segment</li>; <li>ts-ts-byterange: HLS+TS+TS byte range</li>; <li>mp4-mp4-segment: HLS+MP4+MP4 segment</li>; <li>mp4-mp4-byterange: HLS/DASH+MP4+MP4 byte range</li>; <li>ts-packed-audio-byterange: HLS+TS+Packed Audio byte range</li>; <li>mp4-packed-audio-byterange: HLS+MP4+Packed Audio byte range</li>. Default value: ts-segment. Note: The segment format for adaptive bitrate streaming is determined by this field. For DASH format, SegmentType can only be mp4-byterange or mp4-mp4-byterange.
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "DisableHigherVideoBitrate", this.DisableHigherVideoBitrate);
            this.SetParamSimple(map, prefix + "DisableHigherVideoResolution", this.DisableHigherVideoResolution);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "PureAudio", this.PureAudio);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
        }
    }
}

