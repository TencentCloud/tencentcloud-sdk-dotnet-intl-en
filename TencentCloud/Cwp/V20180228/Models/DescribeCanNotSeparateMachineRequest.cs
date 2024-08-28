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

    public class DescribeCanNotSeparateMachineRequest : AbstractModel
    {
        
        /// <summary>
        /// An array of event IDs that need to be modified, and batch operation is supported.
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// Whether to update all, i.e. whether to operate on all events; this parameter is invalid when IDs are not left blank.
        /// </summary>
        [JsonProperty("UpdateAll")]
        public bool? UpdateAll{ get; set; }

        /// <summary>
        /// Excluded event ID: When operating on all events, this ID needs to be excluded.
        /// </summary>
        [JsonProperty("ExcludeId")]
        public ulong?[] ExcludeId{ get; set; }

        /// <summary>
        /// <li>IpOrAlias - String - required: no - filter by host IP or alias</li>
        /// <li>FilePath - String - required: no - filter by path</li>
        /// <li>VirusName - String - required: no - filter by description</li>
        /// <li>CreateBeginTime - String - required: no - filter by creation time - start time</li>
        /// <li>CreateEndTime - String - required: no - filter by creation time - end time</li>
        /// <li>Status - String - required: no - status for filtering: 4: pending; 5: trusted; 6: isolated; 10: isolating; 11: canceling isolation</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamSimple(map, prefix + "UpdateAll", this.UpdateAll);
            this.SetParamArraySimple(map, prefix + "ExcludeId.", this.ExcludeId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

