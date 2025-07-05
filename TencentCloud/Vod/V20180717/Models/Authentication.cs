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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Authentication : AbstractModel
    {
        
        /// <summary>
        /// Anti-hotlink configuration switch, value: <li>on: on; </li> <li>off: off. </li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection mode A configuration
        /// </summary>
        [JsonProperty("TypeA")]
        public AuthenticationTypeA TypeA{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection mode B configuration
        /// </summary>
        [JsonProperty("TypeB")]
        public AuthenticationTypeB TypeB{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection mode C configuration
        /// </summary>
        [JsonProperty("TypeC")]
        public AuthenticationTypeC TypeC{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection mode D configuration
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

