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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SliceParams : AbstractModel
    {
        
        /// <summary>
        /// Slicing task type.
        /// 1: audio slicing;
        /// 2: video frame extraction;
        /// 3: audio/video slicing + video frame extraction.
        /// Example value: 1.
        /// </summary>
        [JsonProperty("SliceType")]
        public ulong? SliceType{ get; set; }

        /// <summary>
        /// Recording is stopped automatically when there is no anchor in the room for more than MaxIdleTime. Unit: seconds. Default value: 30 seconds. This value needs to be greater than or equal to 5 seconds and less than or equal to 86,400 seconds (24 hours).
        /// Example value: 30.
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// Audio slicing duration. Default value: 15s. Example value: 15.
        /// </summary>
        [JsonProperty("SliceAudio")]
        public ulong? SliceAudio{ get; set; }

        /// <summary>
        /// Interval for video frame extraction. Default value: 5s. Example value: 5.
        /// </summary>
        [JsonProperty("SliceVideo")]
        public ulong? SliceVideo{ get; set; }

        /// <summary>
        /// Specifies the allowlist or blocklist for the subscription stream.
        /// </summary>
        [JsonProperty("SubscribeStreamUserIds")]
        public SubscribeStreamUserIds SubscribeStreamUserIds{ get; set; }

        /// <summary>
        /// Depreciated. The callback URL is configured in the console.
        /// </summary>
        [JsonProperty("SliceCallbackUrl")]
        public string SliceCallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SliceType", this.SliceType);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "SliceAudio", this.SliceAudio);
            this.SetParamSimple(map, prefix + "SliceVideo", this.SliceVideo);
            this.SetParamObj(map, prefix + "SubscribeStreamUserIds.", this.SubscribeStreamUserIds);
            this.SetParamSimple(map, prefix + "SliceCallbackUrl", this.SliceCallbackUrl);
        }
    }
}

