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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTIWDailyUsageRequest : AbstractModel
    {
        
        /// <summary>
        /// SdkAppId of the whiteboard application.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Subproduct usage to be queried. The following parameters are supported:
        /// - sp_tiw_board: The duration of use of whiteboards, in minutes.
        /// - sp_tiw_dt: The number of pages dynamically transcoded.
        /// - sp_tiw_st: The number of pages statically transcoded.
        /// - sp_tiw_ric: The duration of real-time recording, in minutes.
        /// 
        /// Note: Dynamic transcoding multiplies the number of pages of a document by eight times. Static transcoding does not change the number of pages of a document.
        /// </summary>
        [JsonProperty("SubProduct")]
        public string SubProduct{ get; set; }

        /// <summary>
        /// Start date in the format of YYYY-MM-DD. The start date is included in the query period.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End date in the format of YYYY-MM-DD. The end date is included in the query period. The period queried per request cannot be longer than 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "SubProduct", this.SubProduct);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

