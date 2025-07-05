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

    public class SdkAppIdBuyInfo : AbstractModel
    {
        
        /// <summary>
        /// Application id.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Application name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Agent purchase count (still within the validity period).
        /// </summary>
        [JsonProperty("StaffBuyNum")]
        public long? StaffBuyNum{ get; set; }

        /// <summary>
        /// Agent purchase list (still within the validity period).
        /// </summary>
        [JsonProperty("StaffBuyList")]
        public StaffBuyInfo[] StaffBuyList{ get; set; }

        /// <summary>
        /// List of numbers purchased.
        /// </summary>
        [JsonProperty("PhoneNumBuyList")]
        public PhoneNumBuyInfo[] PhoneNumBuyList{ get; set; }

        /// <summary>
        /// Number of office telephones purchased (still within the validity period).
        /// </summary>
        [JsonProperty("SipBuyNum")]
        public long? SipBuyNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StaffBuyNum", this.StaffBuyNum);
            this.SetParamArrayObj(map, prefix + "StaffBuyList.", this.StaffBuyList);
            this.SetParamArrayObj(map, prefix + "PhoneNumBuyList.", this.PhoneNumBuyList);
            this.SetParamSimple(map, prefix + "SipBuyNum", this.SipBuyNum);
        }
    }
}

