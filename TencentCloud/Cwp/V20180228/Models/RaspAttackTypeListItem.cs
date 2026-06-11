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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RaspAttackTypeListItem : AbstractModel
    {
        
        /// <summary>
        /// Attack Type Name
        /// </summary>
        [JsonProperty("AttackTypeName")]
        public string AttackTypeName{ get; set; }

        /// <summary>
        /// Attack Type ID
        /// </summary>
        [JsonProperty("AttackTypeID")]
        public long? AttackTypeID{ get; set; }

        /// <summary>
        /// Feature type of the vulnerability, rasp: vulnerability defense, memshell_inject: memory shell injection
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttackTypeName", this.AttackTypeName);
            this.SetParamSimple(map, prefix + "AttackTypeID", this.AttackTypeID);
            this.SetParamSimple(map, prefix + "Source", this.Source);
        }
    }
}

