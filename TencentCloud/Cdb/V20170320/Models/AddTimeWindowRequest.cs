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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddTimeWindowRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the TencentDB Console page.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Time period available for maintenance on Monday in the format of 10:00-12:00. Each period lasts from half an hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. The same rule applies below.
        /// </summary>
        [JsonProperty("Monday")]
        public string[] Monday{ get; set; }

        /// <summary>
        /// Maintenance time window on Tuesday
        /// </summary>
        [JsonProperty("Tuesday")]
        public string[] Tuesday{ get; set; }

        /// <summary>
        /// Maintenance time window on Wednesday
        /// </summary>
        [JsonProperty("Wednesday")]
        public string[] Wednesday{ get; set; }

        /// <summary>
        /// Maintenance time window on Thursday
        /// </summary>
        [JsonProperty("Thursday")]
        public string[] Thursday{ get; set; }

        /// <summary>
        /// Maintenance time window on Friday
        /// </summary>
        [JsonProperty("Friday")]
        public string[] Friday{ get; set; }

        /// <summary>
        /// Maintenance time window on Saturday
        /// </summary>
        [JsonProperty("Saturday")]
        public string[] Saturday{ get; set; }

        /// <summary>
        /// Maintenance time window on Sunday
        /// </summary>
        [JsonProperty("Sunday")]
        public string[] Sunday{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "Monday.", this.Monday);
            this.SetParamArraySimple(map, prefix + "Tuesday.", this.Tuesday);
            this.SetParamArraySimple(map, prefix + "Wednesday.", this.Wednesday);
            this.SetParamArraySimple(map, prefix + "Thursday.", this.Thursday);
            this.SetParamArraySimple(map, prefix + "Friday.", this.Friday);
            this.SetParamArraySimple(map, prefix + "Saturday.", this.Saturday);
            this.SetParamArraySimple(map, prefix + "Sunday.", this.Sunday);
        }
    }
}

