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

    public class DescribeImportMachineInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Array of the server's private IP (default) / server name / server ID (maximum: 1000 entries)
        /// </summary>
        [JsonProperty("MachineList")]
        public string[] MachineList{ get; set; }

        /// <summary>
        /// Data type of batch import. Select one from Ip, Name, and Id.
        /// </summary>
        [JsonProperty("ImportType")]
        public string ImportType{ get; set; }

        /// <summary>
        /// This parameter is discarded.
        /// </summary>
        [JsonProperty("IsQueryProMachine")]
        public bool? IsQueryProMachine{ get; set; }

        /// <summary>
        /// Filter criteria. <li>Version - String - Required: no - Current protection edition. Valid values: PRO_VERSION (professional edition), BASIC_VERSION (basic edition), Flagship (flagship edition), ProtectedMachines (professional edition + flagship edition), BASIC_PROPOST_GENERAL_DISCOUNT (lightweight edition + professional edition in pay-as-you-go mode + basic edition), and UnFlagship (professional edition in prepaid mode + professional edition in postpaid mode + basic edition + lightweight edition).</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MachineList.", this.MachineList);
            this.SetParamSimple(map, prefix + "ImportType", this.ImportType);
            this.SetParamSimple(map, prefix + "IsQueryProMachine", this.IsQueryProMachine);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

