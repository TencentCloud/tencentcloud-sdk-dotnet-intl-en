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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceConfs : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable database inspection. Valid values: Yes/No.
        /// </summary>
        [JsonProperty("DailyInspection")]
        public string DailyInspection{ get; set; }

        /// <summary>
        /// Whether to enable instance overview. Valid values: Yes/No.
        /// </summary>
        [JsonProperty("OverviewDisplay")]
        public string OverviewDisplay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DailyInspection", this.DailyInspection);
            this.SetParamSimple(map, prefix + "OverviewDisplay", this.OverviewDisplay);
        }
    }
}

