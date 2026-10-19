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

    public class CosAccessInfo : AbstractModel
    {
        
        /// <summary>
        /// Access account uin
        /// </summary>
        [JsonProperty("AccessUin")]
        public string AccessUin{ get; set; }

        /// <summary>
        /// Accessible account uid
        /// </summary>
        [JsonProperty("AccessUid")]
        public string AccessUid{ get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Identifier 
        /// 1 Root account
        /// 2 Sub-account
        /// </summary>
        [JsonProperty("Identity")]
        public long? Identity{ get; set; }

        /// <summary>
        /// Root Account Name
        /// </summary>
        [JsonProperty("MainNickName")]
        public string MainNickName{ get; set; }

        /// <summary>
        /// List of accessible AKs
        /// </summary>
        [JsonProperty("AkList")]
        public string[] AkList{ get; set; }

        /// <summary>
        /// Number of accessible permissions
        /// </summary>
        [JsonProperty("CamPolicyCount")]
        public long? CamPolicyCount{ get; set; }

        /// <summary>
        /// Last modified Unix timestamp in milliseconds
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessUin", this.AccessUin);
            this.SetParamSimple(map, prefix + "AccessUid", this.AccessUid);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Identity", this.Identity);
            this.SetParamSimple(map, prefix + "MainNickName", this.MainNickName);
            this.SetParamArraySimple(map, prefix + "AkList.", this.AkList);
            this.SetParamSimple(map, prefix + "CamPolicyCount", this.CamPolicyCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

