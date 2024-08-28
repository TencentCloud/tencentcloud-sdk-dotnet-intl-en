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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBuyBindTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Order Number
        /// </summary>
        [JsonProperty("DealName")]
        public string DealName{ get; set; }

        /// <summary>
        /// Optional parameters. 1: Pro Edition-monthly subscription; 2: Ultimate Edition-monthly subscription
        /// </summary>
        [JsonProperty("LicenseType")]
        public ulong? LicenseType{ get; set; }

        /// <summary>
        /// Machine list
        /// </summary>
        [JsonProperty("QuuidList")]
        public string[] QuuidList{ get; set; }

        /// <summary>
        /// Whether to select all machines
        /// </summary>
        [JsonProperty("IsAll")]
        public bool? IsAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealName", this.DealName);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamArraySimple(map, prefix + "QuuidList.", this.QuuidList);
            this.SetParamSimple(map, prefix + "IsAll", this.IsAll);
        }
    }
}

