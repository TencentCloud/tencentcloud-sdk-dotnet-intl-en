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

    public class DesignVoiceAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Voice description.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>VOD application ID. For customers who activated on-demand services after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications, whether it is the default application or a newly created application.</p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// <p>Voice settings</p>
        /// </summary>
        [JsonProperty("VoiceSettings")]
        public VoiceSettings VoiceSettings{ get; set; }

        /// <summary>
        /// <p>Audition synthesis text. Maximum 500 characters.</p>
        /// </summary>
        [JsonProperty("PreviewText")]
        public string PreviewText{ get; set; }

        /// <summary>
        /// <p>Extended parameters in the format of a JSON string.</p>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }

        /// <summary>
        /// <p>Identifies the source context. This is used to pass through user request information. The callback and task flow status change callback return the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Identification Code for Task Deduplication. If a request with the same identification code has been made within the past 3 days, an error will be returned for the current request. The maximum length is 50 characters. Not specifying it or specifying an empty string means no deduplication.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "VoiceSettings.", this.VoiceSettings);
            this.SetParamSimple(map, prefix + "PreviewText", this.PreviewText);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

