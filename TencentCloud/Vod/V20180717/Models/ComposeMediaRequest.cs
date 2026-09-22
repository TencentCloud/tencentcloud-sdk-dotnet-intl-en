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

    public class ComposeMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// Input media track list, including multiple track information composed of materials such as video, audio, and image, where: <li>Multiple input tracks are aligned with the output media file timeline on the timeline;</li><li>Materials on different tracks at the same time point on the timeline are overlaid. Image overlay of videos or images is performed in track order, materials with higher track order are overlaid on top, and audio materials are mixed;</li><li>Each type of track supports up to 10 video, audio, and image tracks.</li><li>The total number of media segments placed on all types of tracks supports up to 500.</li>
        /// </summary>
        [JsonProperty("Tracks")]
        public MediaTrack[] Tracks{ get; set; }

        /// <summary>
        /// Output media file information.
        /// </summary>
        [JsonProperty("Output")]
        public ComposeMediaOutput Output{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Canvas used when making video files.
        /// </summary>
        [JsonProperty("Canvas")]
        public Canvas Canvas{ get; set; }

        /// <summary>
        /// Identify source context, used to pass through user request information. The value of this field will be returned in the ComposeMediaComplete callback. Maximum length: 1000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Identification Code for Task Deduplication. If there has been a request with the same identification code within the past 3 days, an error will be returned for the current request. The maximum length is 50 characters. Leaving it blank or using a null string indicates no deduplication is required.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Tracks.", this.Tracks);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "Canvas.", this.Canvas);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

