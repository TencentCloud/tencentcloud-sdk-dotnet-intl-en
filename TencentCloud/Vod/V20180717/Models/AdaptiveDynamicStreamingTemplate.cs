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

    public class AdaptiveDynamicStreamingTemplate : AbstractModel
    {
        
        /// <summary>
        /// <p>Adaptive bitrate streaming template unique ID.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <p>Template type. Valid values:</p><li>Preset: preset template.</li><li>Custom: custom template.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Adaptive bitrate streaming template name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Adaptive bitrate streaming template description.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Adaptive Transcoding Format. Value range:</p><li>HLS.</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// <p>DRM type. Value range: </p><li>SimpleAES</li><li>Widevine</li><li>FairPlay</li><li>Widevine+FairPlay</li>If the value is an empty string, it means no DRM protection is applied to the video.
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }

        /// <summary>
        /// <p>Key provider for DRM. Value range:</p><li>SDMC: SDMC;</li><li>VOD: VOD.</li>Default value: VOD.<p>The SDMC service will gradually phase out subsequently. Please use the VOD DRM encryption service.</p>
        /// </summary>
        [JsonProperty("DrmKeyProvider")]
        public string DrmKeyProvider{ get; set; }

        /// <summary>
        /// <p>Encryption type of DRM. Value range: {&quot;cbcs&quot;, &quot;cenc&quot;}</p>
        /// </summary>
        [JsonProperty("DrmEncryptType")]
        public string DrmEncryptType{ get; set; }

        /// <summary>
        /// <p>Adaptive Transcoding Input Stream Parameter Information, up to 10 streams.</p>
        /// </summary>
        [JsonProperty("StreamInfos")]
        public AdaptiveStreamTemplate[] StreamInfos{ get; set; }

        /// <summary>
        /// <p>Whether to prohibit video low bitrate to high bitrate conversion. Value range: </p><li>0: No, </li><li>1: Yes.</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoBitrate")]
        public ulong? DisableHigherVideoBitrate{ get; set; }

        /// <summary>
        /// <p>Whether to prohibit video resolution to high resolution conversion. Value range:</p><li>0: No,</li><li>1: Yes.</li>
        /// </summary>
        [JsonProperty("DisableHigherVideoResolution")]
        public ulong? DisableHigherVideoResolution{ get; set; }

        /// <summary>
        /// <p>Template creation time, in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Last template modification time, in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Segment type.</p><p>ts: HLS, internally mapped to ts-segment</p><p>fmp4: HLS/DASH, internally mapped to mp4-mp4-segment for HLS and mp4-mp4-byterange for DASH</p><p>ts-segment: HLS+TS segment</p><p>ts-byterange: HLS+TS byte range</p><p>mp4-segment: HLS+MP4 segment</p><p>mp4-byterange: HLS+MP4 byte range</p><p>ts-packed-audio: HLS+TS+Packed Audio segment</p><p>mp4-packed-audio: HLS+MP4+Packed Audio segment</p><p>ts-ts-segment: HLS+TS+TS segment</p><p>ts-ts-byterange: HLS+TS+TS byte range</p><p>mp4-mp4-segment: HLS+MP4+MP4 segment</p><p>mp4-mp4-byterange: HLS/DASH+MP4+MP4 byte range</p><p>ts-packed-audio-byterange: HLS+TS+Packed Audio byte range</p><p>mp4-packed-audio-byterange: HLS+MP4+Packed Audio byte range<br> Default value: ts-segment. Note: The shard format of adaptive bitrate is based on this field. For DASH, SegmentType can only be mp4-mp4-byterange.</p>
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }

        /// <summary>
        /// <p>Average segmentation duration</p><p>Unit: seconds</p><p>Default value: 6</p><p>Adaptive bitrate streaming uses SegmentDuration to set the segment duration instead of the HlsTime field.</p>
        /// </summary>
        [JsonProperty("SegmentDuration")]
        public long? SegmentDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
            this.SetParamSimple(map, prefix + "DrmKeyProvider", this.DrmKeyProvider);
            this.SetParamSimple(map, prefix + "DrmEncryptType", this.DrmEncryptType);
            this.SetParamArrayObj(map, prefix + "StreamInfos.", this.StreamInfos);
            this.SetParamSimple(map, prefix + "DisableHigherVideoBitrate", this.DisableHigherVideoBitrate);
            this.SetParamSimple(map, prefix + "DisableHigherVideoResolution", this.DisableHigherVideoResolution);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "SegmentDuration", this.SegmentDuration);
        }
    }
}

