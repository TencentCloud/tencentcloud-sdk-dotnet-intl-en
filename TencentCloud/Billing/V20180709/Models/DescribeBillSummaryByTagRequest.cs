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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillSummaryByTagRequest : AbstractModel
    {
        
        /// <summary>
        /// Payer UIN
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// Currently the period to be queried must start from a time point in the current month, and the starting time and the end time must be in the same month. Example: 2018-09-01 00:00:00.
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// Currently the period to be queried must end at a time point in the current month, and the starting time and the end time must be in the same month. Example: 2018-09-30 23:59:59.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Cost allocation tag key
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
        }
    }
}

