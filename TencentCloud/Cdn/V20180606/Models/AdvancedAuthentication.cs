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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedAuthentication : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable hot linking protection. Values:
        /// `on`: Enable
        /// `off`: Disable
        /// Only one advanced configuration can be enabled. Set the rests to `null`.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection advanced configuration mode A
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TypeA")]
        public AdvancedAuthenticationTypeA TypeA{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection advanced configuration mode B
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TypeB")]
        public AdvancedAuthenticationTypeB TypeB{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection advanced configuration mode C
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TypeC")]
        public AdvancedAuthenticationTypeC TypeC{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection advanced configuration mode D
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TypeD")]
        public AdvancedAuthenticationTypeD TypeD{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection advanced configuration mode E
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TypeE")]
        public AdvancedAuthenticationTypeE TypeE{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection advanced configuration mode F
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TypeF")]
        public AdvancedAuthenticationTypeF TypeF{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "TypeA.", this.TypeA);
            this.SetParamObj(map, prefix + "TypeB.", this.TypeB);
            this.SetParamObj(map, prefix + "TypeC.", this.TypeC);
            this.SetParamObj(map, prefix + "TypeD.", this.TypeD);
            this.SetParamObj(map, prefix + "TypeE.", this.TypeE);
            this.SetParamObj(map, prefix + "TypeF.", this.TypeF);
        }
    }
}

