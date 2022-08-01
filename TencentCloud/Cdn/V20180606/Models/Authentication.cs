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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Authentication : AbstractModel
    {
        
        /// <summary>
        /// Hotlink protection configuration switch
        /// `on`: Enable
        /// `off`: Disable
        /// When this is enabled, one mode needs to be configured. Other modes need to be set to null.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection mode A configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TypeA")]
        public AuthenticationTypeA TypeA{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection mode B configuration (mode B is being upgraded and is currently not supported)
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TypeB")]
        public AuthenticationTypeB TypeB{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection mode C configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TypeC")]
        public AuthenticationTypeC TypeC{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection mode D configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TypeD")]
        public AuthenticationTypeD TypeD{ get; set; }


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
        }
    }
}

