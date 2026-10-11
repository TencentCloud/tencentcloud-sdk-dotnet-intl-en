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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileOutputConf : AbstractModel
    {
        
        /// <summary>
        /// Cell ID
        /// </summary>
        [JsonProperty("CellId")]
        public string CellId{ get; set; }

        /// <summary>
        /// Dashboard chart configuration, JSON string
        /// </summary>
        [JsonProperty("DashboardConf")]
        public string DashboardConf{ get; set; }

        /// <summary>
        /// Pre-signed download URL of the execution result file
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CellId", this.CellId);
            this.SetParamSimple(map, prefix + "DashboardConf", this.DashboardConf);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
        }
    }
}

