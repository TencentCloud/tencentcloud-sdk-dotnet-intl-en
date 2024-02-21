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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TRTCDataResult : AbstractModel
    {
        
        /// <summary>
        /// StatementID value, fixed at 0 for Monitoring Dashboard.
        /// </summary>
        [JsonProperty("StatementID")]
        public long? StatementID{ get; set; }

        /// <summary>
        /// Query result data, returned in Columns-Values format.
        /// </summary>
        [JsonProperty("Series")]
        public SeriesInfos[] Series{ get; set; }

        /// <summary>
        /// Total value, fixed at 1 for Monitoring Dashboard.
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatementID", this.StatementID);
            this.SetParamArrayObj(map, prefix + "Series.", this.Series);
            this.SetParamSimple(map, prefix + "Total", this.Total);
        }
    }
}

