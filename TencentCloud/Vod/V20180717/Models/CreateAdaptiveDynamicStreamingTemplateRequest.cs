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

    public class CreateAdaptiveDynamicStreamingTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Adaptive Transcoding Format. Value range:</p><li>HLS;</li><li>MPEG-DASH.</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// <p>Adaptive transcoding output substream parameter information. Up to 10 substreams can be output.<br>Note: The frame rate of each substream must remain consistent. If inconsistent, the frame rate of the first substream is used as the output frame rate.</p>
        /// </summary>
        [JsonProperty("StreamInfos")]
        public AdaptiveStreamTemplate[] StreamInfos{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="/document/product/266/14574">application</a> ID. For customers who activate on-demand services from December 25, 2023, if they access resources in on-demand applications (whether the default application or a newly created application), this field must be filled with the application ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Template name. Length limit: 64 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>DRM solution type. Value range:</p><li>SimpleAES</li><li>Widevine</li><li>FairPlay</li><li>Widevine+FairPlay</li>The default value is an empty string. If the value is an empty string, it means no DRM protection is applied to the video.
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }

        /// <summary>
        /// <p>Key provider for DRM. Valid values:</p><li>SDMC: SDMC;</li><li>VOD: VOD.</li>Default value: VOD.<p>The SDMC service will be gradually phased out. Please use VOD DRM encryption service.</p>
        /// </summary>
        [JsonProperty("DrmKeyProvider")]
        public string DrmKeyProvider{ get; set; }

        /// <summary>
        /// <p>Encryption method. Available values:<br>cbcs: supported by Widevine, FairPlay, and WideVine+FairPlay;<br>cenc: supported by Widevine;   </p><p>If left blank<br>FairPlay: cbcs by default;<br>Widevine: cenc by default;<br>WideVine+FairPlay: cbcs by default;</p>
        /// </summary>
        [JsonProperty("DrmEncryptType")]
        public string DrmEncryptType{ get; set; }

        /// <summary>
        /// <p>Whether to prohibit video low bitrate to high bitrate conversion. Value range:</p><li>0: No,</li><li>1: Yes.</li>Default: No.
        /// </summary>
        [JsonProperty("DisableHigherVideoBitrate")]
        public ulong? DisableHigherVideoBitrate{ get; set; }

        /// <summary>
        /// <p>Whether to prohibit video resolution to high resolution conversion. Value range:</p><li>0: No,</li><li>1: Yes.</li>No by default.
        /// </summary>
        [JsonProperty("DisableHigherVideoResolution")]
        public ulong? DisableHigherVideoResolution{ get; set; }

        /// <summary>
        /// <p>Transcoding template description. Length limit: 256 characters.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Segment type. Valid values:<br>ts: HLS, internally mapped to ts-segment</p><p>mp4: HLS/DASH, internally mapped to mp4-mp4-segment for HLS and mp4-mp4-byterange for DASH</p><p>ts-segment: HLS+TS segment</p><p>ts-byterange: HLS+TS byte range</p><p>mp4-segment: HLS+MP4 segment</p><p>mp4-byterange: HLS+MP4 byte range</p><p>ts-packed-audio: HLS+TS+Packed Audio segment</p><p>mp4-packed-audio: HLS+MP4+Packed Audio segment</p><p>ts-ts-segment: HLS+TS+TS segment</p><p>ts-ts-byterange: HLS+TS+TS byte range</p><p>mp4-mp4-segment: HLS+MP4+MP4 segment</p><p>mp4-mp4-byterange: HLS/DASH+MP4+MP4 byte range</p><p>ts-packed-audio-byterange: HLS+TS+Packed Audio byte range</p><p>mp4-packed-audio-byterange: HLS+MP4+Packed Audio byte range<br> Default value: ts-segment. Note: The segment format for adaptive bitrate streams is based on this field. For DASH, SegmentType can only be mp4-mp4-byterange.</p><p>FairPlay: can only be used for HLS, and the segment format can only be mp4 or mp4-mp4-segment. Widevine: can be used for HLS and DASH. For HLS, the segment format can only be mp4 or mp4-mp4-segment. For DASH, the segment format can only be mp4 or mp4-mp4-byterange.<br>Widevine+FairPlay: can only be used for HLS, and the segment format can only be mp4 or mp4-mp4-segment</p>
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }

        /// <summary>
        /// <p>Segment duration.</p><p>Value range: [1, 10]</p><p>Unit: seconds</p><p>Default value: 6</p>
        /// </summary>
        [JsonProperty("SegmentDuration")]
        public long? SegmentDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
            this.SetParamSimple(map, prefix + "DrmKeyProvider", this.DrmKeyProvider);
            this.SetParamSimple(map, prefix + "DrmEncryptType", this.DrmEncryptType);
            this.SetParamSimple(map, prefix + "DisableHigherVideoBitrate", this.DisableHigherVideoBitrate);
            this.SetParamSimple(map, prefix + "DisableHigherVideoResolution", this.DisableHigherVideoResolution);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "SegmentDuration", this.SegmentDuration);
        }
    }
}

