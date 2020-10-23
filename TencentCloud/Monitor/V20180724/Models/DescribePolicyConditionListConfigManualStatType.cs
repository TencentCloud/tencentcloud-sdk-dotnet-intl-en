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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyConditionListConfigManualStatType : AbstractModel
    {
        
        /// <summary>
        /// Data aggregation method in a period of 5 seconds.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("P5")]
        public string P5{ get; set; }

        /// <summary>
        /// Data aggregation method in a period of 10 seconds.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("P10")]
        public string P10{ get; set; }

        /// <summary>
        /// Data aggregation method in a period of 1 minute.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("P60")]
        public string P60{ get; set; }

        /// <summary>
        /// Data aggregation method in a period of 5 minutes.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("P300")]
        public string P300{ get; set; }

        /// <summary>
        /// Data aggregation method in a period of 10 minutes.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("P600")]
        public string P600{ get; set; }

        /// <summary>
        /// Data aggregation method in a period of 30 minutes.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("P1800")]
        public string P1800{ get; set; }

        /// <summary>
        /// Data aggregation method in a period of 1 hour.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("P3600")]
        public string P3600{ get; set; }

        /// <summary>
        /// Data aggregation method in a period of 1 day.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("P86400")]
        public string P86400{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "P5", this.P5);
            this.SetParamSimple(map, prefix + "P10", this.P10);
            this.SetParamSimple(map, prefix + "P60", this.P60);
            this.SetParamSimple(map, prefix + "P300", this.P300);
            this.SetParamSimple(map, prefix + "P600", this.P600);
            this.SetParamSimple(map, prefix + "P1800", this.P1800);
            this.SetParamSimple(map, prefix + "P3600", this.P3600);
            this.SetParamSimple(map, prefix + "P86400", this.P86400);
        }
    }
}

