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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDashboardSubscribeRequest : AbstractModel
    {
        
        /// <summary>
        /// Dashboard subscription name.
        /// Input limit:
        /// -Cannot be empty
        /// -Length cannot exceed 128 bytes
        /// -Cannot contain character '|'
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Dashboard Id.
        /// -Get the dashboard Id by [searching for the dashboard](https://www.tencentcloud.com/document/product/614/95636?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DashboardId")]
        public string DashboardId{ get; set; }

        /// <summary>
        /// Subscription time cron expression, in format {seconds} {minutes} {hours} {date} {month} {weekday}; (valid data: {minutes} {hours} {date} {month} {weekday})
        /// -{seconds} Value ranges from 0 to 59. 
        /// -{Minutes} Value ranges from 0 to 59. 
        /// -Hour. Value ranges from 0 to 23. 
        /// -{Date} value ranges from 1 to 31 AND (last day of month: L) 
        /// -{Month} value ranges from 1 to 12. 
        /// -Week value ranges from 0 to 6 [0:Sunday, 6:Saturday]
        /// </summary>
        [JsonProperty("Cron")]
        public string Cron{ get; set; }

        /// <summary>
        /// Dashboard subscription data.
        /// </summary>
        [JsonProperty("SubscribeData")]
        public DashboardSubscribeData SubscribeData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DashboardId", this.DashboardId);
            this.SetParamSimple(map, prefix + "Cron", this.Cron);
            this.SetParamObj(map, prefix + "SubscribeData.", this.SubscribeData);
        }
    }
}

