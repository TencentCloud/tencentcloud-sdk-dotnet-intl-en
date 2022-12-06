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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScanResultListRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID, which is obtained when you create an application in the [GME console](https://console.cloud.tencent.com/gamegme).
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// List of IDs of the tasks to be queried. Up to 100 entries can be added in the ID list.
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// Number of task results to be returned. Default value: 10. Maximum value: 500. This parameter will be ignored for large file tasks where all results will be returned.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

