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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartMCUMixTranscodeByStrRoomIdRequest : AbstractModel
    {
        
        /// <summary>
        /// `SDKAppId` of TRTC
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Room ID in string type
        /// </summary>
        [JsonProperty("StrRoomId")]
        public string StrRoomId{ get; set; }

        /// <summary>
        /// On-Cloud MixTranscoding output parameters
        /// </summary>
        [JsonProperty("OutputParams")]
        public OutputParams OutputParams{ get; set; }

        /// <summary>
        /// On-Cloud MixTranscoding output encoding parameters
        /// </summary>
        [JsonProperty("EncodeParams")]
        public EncodeParams EncodeParams{ get; set; }

        /// <summary>
        /// On-Cloud MixTranscoding output layout parameters
        /// </summary>
        [JsonProperty("LayoutParams")]
        public LayoutParams LayoutParams{ get; set; }

        /// <summary>
        /// Relayed push parameters of a non-Tencent Cloud CDN
        /// </summary>
        [JsonProperty("PublishCdnParams")]
        public PublishCdnParams PublishCdnParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "StrRoomId", this.StrRoomId);
            this.SetParamObj(map, prefix + "OutputParams.", this.OutputParams);
            this.SetParamObj(map, prefix + "EncodeParams.", this.EncodeParams);
            this.SetParamObj(map, prefix + "LayoutParams.", this.LayoutParams);
            this.SetParamObj(map, prefix + "PublishCdnParams.", this.PublishCdnParams);
        }
    }
}

