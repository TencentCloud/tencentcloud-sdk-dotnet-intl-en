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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOwnNumberApplyRequest : AbstractModel
    {
        
        /// <summary>
        /// Application id (required) can be found at https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// SIP connection id.
        /// </summary>
        [JsonProperty("SipTrunkId")]
        public long? SipTrunkId{ get; set; }

        /// <summary>
        /// Circuit-Related parameters.
        /// </summary>
        [JsonProperty("DetailList")]
        public OwnNumberApplyDetailItem[] DetailList{ get; set; }

        /// <summary>
        /// Prefix for sending numbers.
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "SipTrunkId", this.SipTrunkId);
            this.SetParamArrayObj(map, prefix + "DetailList.", this.DetailList);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
        }
    }
}

