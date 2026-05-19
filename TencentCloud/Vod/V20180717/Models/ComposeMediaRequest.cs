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
        /// The input media track list includes multiple track information composed of materials such as video, audio, and images. Among them:<li>The input multiple tracks are aligned with the output media file timeline on the timeline.</li><li>Overlap materials on different tracks at the same time point on the timeline. Perform image overlay of videos or images in track order, with materials of higher track order overlaid on top. Mix audio materials.</li><li>Each type of track supports up to 10 video, audio, or image tracks.</li><li>The total number of media segments placed on all types of tracks supports up to 500.</li>
        /// </summary>
        [JsonProperty("Tracks")]
        public MediaTrack[] Tracks{ get; set; }

        /// <summary>
        /// Output media file information.
        /// </summary>
        [JsonProperty("Output")]
        public ComposeMediaOutput Output{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Canvas used when making video files.
        /// </summary>
        [JsonProperty("Canvas")]
        public Canvas Canvas{ get; set; }

        /// <summary>
        /// Identify source context. This is used to pass through user request information. The ComposeMediaComplete callback returns the value of this field. The maximum length is 1000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Identifier for task deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.
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

