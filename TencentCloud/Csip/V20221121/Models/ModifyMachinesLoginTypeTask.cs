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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMachinesLoginTypeTask : AbstractModel
    {
        
        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>1-In progress, 2 completed</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>Successfully executed count.</p>
        /// </summary>
        [JsonProperty("SuccessCount")]
        public ulong? SuccessCount{ get; set; }

        /// <summary>
        /// <p>Host list of failed execution</p>
        /// </summary>
        [JsonProperty("FailList")]
        public ModifyLoginTypeFailInfo[] FailList{ get; set; }

        /// <summary>
        /// <p>List of instance IDs with successful modification.</p>
        /// </summary>
        [JsonProperty("SuccessInstances")]
        public string[] SuccessInstances{ get; set; }

        /// <summary>
        /// <p>List of instance IDs being modified</p>
        /// </summary>
        [JsonProperty("ProgressingInstances")]
        public string[] ProgressingInstances{ get; set; }

        /// <summary>
        /// <p>Number of failed hosts</p>
        /// </summary>
        [JsonProperty("FailedHostCount")]
        public ulong? FailedHostCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamArrayObj(map, prefix + "FailList.", this.FailList);
            this.SetParamArraySimple(map, prefix + "SuccessInstances.", this.SuccessInstances);
            this.SetParamArraySimple(map, prefix + "ProgressingInstances.", this.ProgressingInstances);
            this.SetParamSimple(map, prefix + "FailedHostCount", this.FailedHostCount);
        }
    }
}

