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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CurrentOriginACL : AbstractModel
    {
        
        /// <summary>
        /// IP range details.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("EntireAddresses")]
        public Addresses EntireAddresses{ get; set; }

        /// <summary>
        /// Version number.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Version effective time in UTC+8, following the date and time format of the ISO 8601 standard.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ActiveTime")]
        public string ActiveTime{ get; set; }

        /// <summary>
        /// This parameter is used to record whether "I've upgraded to the lastest verison" is completed before the origin ACLs version is effective. valid values:.
        /// - true: specifies that the version is effective and the update to the latest version is confirmed.
        /// - false: when the version takes effect, the confirmation of updating to the latest origin ACLs are not completed. The IP range is forcibly updated to the latest version in the backend. When this parameter returns false, please confirm in time whether your origin server firewall configuration has been updated to the latest version to avoid origin-pull failure.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("IsPlaned")]
        public string IsPlaned{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "EntireAddresses.", this.EntireAddresses);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamSimple(map, prefix + "IsPlaned", this.IsPlaned);
        }
    }
}

