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

    public class CreateSuperPlayerConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Player configuration name, length limited to 64 characters. Only [0-9a-zA-Z] and _- are allowed (for example, test_ABC-123). The name is unique for the same user.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Played audio and video type. Available values:
        /// <li>AdaptiveDynamicStream: adaptive bitrate stream output;</li>
        /// <li>Transcode: transcode;</li>
        /// <li>Original: original audio/video.</li>
        /// AdaptiveDynamicStream by default.
        /// </summary>
        [JsonProperty("AudioVideoType")]
        public string AudioVideoType{ get; set; }

        /// <summary>
        /// Switch for playing DRM-protected adaptive bitstream:
        /// <li>ON: enabled, indicates only playback of DRM protected adaptive bitrate output;</li>
        /// <li>OFF: Disable, indicates playback of unencrypted adaptive bitstream output.</li>
        /// Default value: OFF.
        /// This parameter is valid when `AudioVideoType` is `AdaptiveDynamicStream`.
        /// </summary>
        [JsonProperty("DrmSwitch")]
        public string DrmSwitch{ get; set; }

        /// <summary>
        /// Allowed output of unencrypted adaptive bitstream template ID.
        /// 
        /// Required when `AudioVideoType` is `AdaptiveDynamicStream` and `DrmSwitch` is `OFF`.
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingDefinition")]
        public ulong? AdaptiveDynamicStreamingDefinition{ get; set; }

        /// <summary>
        /// Allowed output of DRM adaptive bitstream template content.
        /// 
        /// Required when `AudioVideoType` is `AdaptiveDynamicStream` and `DrmSwitch` is `ON`.
        /// </summary>
        [JsonProperty("DrmStreamingsInfo")]
        public DrmStreamingsInfo DrmStreamingsInfo{ get; set; }

        /// <summary>
        /// Allowed output transcoding template ID.
        /// 
        /// Required if `AudioVideoType` is `Transcode`.
        /// </summary>
        [JsonProperty("TranscodeDefinition")]
        public ulong? TranscodeDefinition{ get; set; }

        /// <summary>
        /// Allowed output sprite template ID.
        /// </summary>
        [JsonProperty("ImageSpriteDefinition")]
        public ulong? ImageSpriteDefinition{ get; set; }

        /// <summary>
        /// Player's display name for substreams of different resolutions. Use default configuration if not filled or empty array:
        /// <li>MinEdgeLength: 240, Name: smooth;</li>
        /// <li>MinEdgeLength: 480, Name: SD;</li>
        /// <li>MinEdgeLength: 720, Name: high-definition;</li>
        /// <li>MinEdgeLength: 1080, Name: full HD;</li>
        /// <li>MinEdgeLength:1440,Name:2K;</li>
        /// <li>MinEdgeLength:2160,Name:4K;</li>
        /// <li>MinEdgeLength:4320,Name:8K.</li>
        /// </summary>
        [JsonProperty("ResolutionNames")]
        public ResolutionNameInfo[] ResolutionNames{ get; set; }

        /// <summary>
        /// Domain name used during playback. If left empty or set to Default, it indicates usage of the domain name in the [default distribution configuration](https://www.tencentcloud.com/document/product/266/33373?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Scheme used during playback. If left empty or set to Default, it indicates usage of the scheme in the [default distribution configuration](https://www.tencentcloud.com/document/product/266/33373?from_cn_redirect=1). Other optional values:
        /// <li>HTTP;</li>
        /// <li>HTTPS.</li>
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// Template description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "AudioVideoType", this.AudioVideoType);
            this.SetParamSimple(map, prefix + "DrmSwitch", this.DrmSwitch);
            this.SetParamSimple(map, prefix + "AdaptiveDynamicStreamingDefinition", this.AdaptiveDynamicStreamingDefinition);
            this.SetParamObj(map, prefix + "DrmStreamingsInfo.", this.DrmStreamingsInfo);
            this.SetParamSimple(map, prefix + "TranscodeDefinition", this.TranscodeDefinition);
            this.SetParamSimple(map, prefix + "ImageSpriteDefinition", this.ImageSpriteDefinition);
            this.SetParamArrayObj(map, prefix + "ResolutionNames.", this.ResolutionNames);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

