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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateIVRSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID (required) can be found at https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Called.
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// Specified IVR Id. Currently, it supports inbound and automatic outbound types
        /// </summary>
        [JsonProperty("IVRId")]
        public long? IVRId{ get; set; }

        /// <summary>
        /// List of calling numbers.
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// Custom variable
        /// </summary>
        [JsonProperty("Variables")]
        public Variable[] Variables{ get; set; }

        /// <summary>
        /// User Data
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "IVRId", this.IVRId);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamArrayObj(map, prefix + "Variables.", this.Variables);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
        }
    }
}

