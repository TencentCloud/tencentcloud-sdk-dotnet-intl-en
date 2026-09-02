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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserAKInfo : AbstractModel
    {
        
        /// <summary>
        /// APPID
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Account nickname
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Number of AKs under the account
        /// </summary>
        [JsonProperty("AKNum")]
        public long? AKNum{ get; set; }

        /// <summary>
        /// Whether it is shared. 1: shared. 2: not shared.
        /// </summary>
        [JsonProperty("IsShared")]
        public long? IsShared{ get; set; }

        /// <summary>
        /// Whether to purchase separately. 1: separate purchase; 2: not purchased separately
        /// </summary>
        [JsonProperty("IsSelfBuy")]
        public long? IsSelfBuy{ get; set; }

        /// <summary>
        /// Source account of the quota
        /// </summary>
        [JsonProperty("ShareFromAppID")]
        public long? ShareFromAppID{ get; set; }

        /// <summary>
        /// Cloud vendor type
        /// 0: Tencent Cloud
        /// 1: Amazon Web Services
        /// 2: Microsoft Azure.
        /// 3: Google Cloud
        /// 4: Alibaba Cloud
        /// 5: Huawei Cloud
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "AKNum", this.AKNum);
            this.SetParamSimple(map, prefix + "IsShared", this.IsShared);
            this.SetParamSimple(map, prefix + "IsSelfBuy", this.IsSelfBuy);
            this.SetParamSimple(map, prefix + "ShareFromAppID", this.ShareFromAppID);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
        }
    }
}

