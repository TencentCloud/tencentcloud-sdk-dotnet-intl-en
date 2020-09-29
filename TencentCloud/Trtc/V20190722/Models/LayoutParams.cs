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

    public class LayoutParams : AbstractModel
    {
        
        /// <summary>
        /// On-cloud stream mix layout template ID. 0: floating template (default value); 1: grid template; 2: screen sharing template; 3: picture-in-picture template.
        /// </summary>
        [JsonProperty("Template")]
        public ulong? Template{ get; set; }

        /// <summary>
        /// ID of the user in the big image, which takes effect in a screen sharing, floating, or picture-in-picture template.
        /// </summary>
        [JsonProperty("MainVideoUserId")]
        public string MainVideoUserId{ get; set; }

        /// <summary>
        /// Stream type of the big image, which takes effect in a screen sharing, floating, or picture-in-picture template. 0: camera; 1: screen sharing. If a web user's stream is displayed in the big image on the left, enter 0 for this parameter.
        /// </summary>
        [JsonProperty("MainVideoStreamType")]
        public ulong? MainVideoStreamType{ get; set; }

        /// <summary>
        /// Layout parameter of the small image, which takes effect in a picture-in-picture template.
        /// </summary>
        [JsonProperty("SmallVideoLayoutParams")]
        public SmallVideoLayoutParams SmallVideoLayoutParams{ get; set; }

        /// <summary>
        /// You can set the layout parameter as 1 or 0 in the screen sharing template. 1: big image on the right and small images on the left, 0: big image on the left and small images on the right. The default value is 0. 
        /// </summary>
        [JsonProperty("MainVideoRightAlign")]
        public ulong? MainVideoRightAlign{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MixVideoUids")]
        public string[] MixVideoUids{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Template", this.Template);
            this.SetParamSimple(map, prefix + "MainVideoUserId", this.MainVideoUserId);
            this.SetParamSimple(map, prefix + "MainVideoStreamType", this.MainVideoStreamType);
            this.SetParamObj(map, prefix + "SmallVideoLayoutParams.", this.SmallVideoLayoutParams);
            this.SetParamSimple(map, prefix + "MainVideoRightAlign", this.MainVideoRightAlign);
            this.SetParamArraySimple(map, prefix + "MixVideoUids.", this.MixVideoUids);
        }
    }
}

