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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DBSwitchInfo : AbstractModel
    {
        
        /// <summary>
        /// Switch time in the format of yyyy-MM-dd HH:mm:ss, such as 2017-09-03 01:34:31
        /// </summary>
        [JsonProperty("SwitchTime")]
        public string SwitchTime{ get; set; }

        /// <summary>
        /// Switch type. Value range: TRANSFER (data migration), MASTER2SLAVE (primary/secondary switch), RECOVERY (primary/secondary recovery)
        /// </summary>
        [JsonProperty("SwitchType")]
        public string SwitchType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SwitchTime", this.SwitchTime);
            this.SetParamSimple(map, prefix + "SwitchType", this.SwitchType);
        }
    }
}

