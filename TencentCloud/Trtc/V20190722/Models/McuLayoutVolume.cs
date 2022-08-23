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

    public class McuLayoutVolume : AbstractModel
    {
        
        /// <summary>
        /// The application data, which will be embedded in the `app_data` field of the custom SEI. It must be shorter than 4,096 characters.
        /// </summary>
        [JsonProperty("AppData")]
        public string AppData{ get; set; }

        /// <summary>
        /// The payload type of the SEI message. The default is 100. Value range: 100-254 (244 is used internally by Tencent Cloud for timestamps).
        /// </summary>
        [JsonProperty("PayloadType")]
        public ulong? PayloadType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppData", this.AppData);
            this.SetParamSimple(map, prefix + "PayloadType", this.PayloadType);
        }
    }
}

