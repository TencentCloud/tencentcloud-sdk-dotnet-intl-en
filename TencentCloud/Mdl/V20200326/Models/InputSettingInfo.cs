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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputSettingInfo : AbstractModel
    {
        
        /// <summary>
        /// Application name, which is valid if `Type` is `RTMP_PUSH` or `RTMPS_PUSH`, and can contain 1-32 letters and digits
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Stream name, which is valid if `Type` is `RTMP_PUSH` or `RTMPS_PUSH`, and can contain 1-32 letters and digits
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// Source URL, which is valid if `Type` is `RTMP_PULL`, `HLS_PULL`,  `MP4_PULL`, `RTSP_PULL` or `SRT_PULL`, and can contain 1-512 characters
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SourceUrl")]
        public string SourceUrl{ get; set; }

        /// <summary>
        /// RTP/UDP input address, which does not need to be entered for the input parameter.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InputAddress")]
        public string InputAddress{ get; set; }

        /// <summary>
        /// Source type for stream pulling and relaying. To pull content from private-read COS buckets under the current account, set this parameter to `TencentCOS`; otherwise, leave it empty.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// Delayed time (ms) for playback, which is valid if `Type` is `RTMP_PUSH` or `RTMPS_PUSH`.
        /// Value range: 0 (default) or 10000-600000.
        /// The value must be a multiple of 1,000.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DelayTime")]
        public long? DelayTime{ get; set; }

        /// <summary>
        /// The domain name of the SRT_PUSH push address. No need to fill in the input parameter.
        /// </summary>
        [JsonProperty("InputDomain")]
        public string InputDomain{ get; set; }

        /// <summary>
        /// The username, which is used for authentication.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// The password, which is used for authentication.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// This parameter is valid when the input source is HLS_PULL and MP4_PULL. It indicates the type of file the source is. The optional values are: LIVE, VOD. Please note that if you do not enter this parameter, the system will take the default input value VOD.
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "SourceUrl", this.SourceUrl);
            this.SetParamSimple(map, prefix + "InputAddress", this.InputAddress);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "InputDomain", this.InputDomain);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
        }
    }
}

