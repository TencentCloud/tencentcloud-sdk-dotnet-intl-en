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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTimeWindowRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The modified maintenance time slot. Among them, each time period is in the format of 10:00-12:00. The start and end time is aligned by half hour. The shortest is half hour and the longest is three hours. Up to two time periods can be set. The start and end time ranges from [00:00, 24:00].
        /// Description: The following is an example of setting two time periods in json.
        /// [
        ///     "01:00-01:30",
        ///     "02:00-02:30"
        ///   ]
        /// </summary>
        [JsonProperty("TimeRanges")]
        public string[] TimeRanges{ get; set; }

        /// <summary>
        /// Specify which day to modify the maintenance time slot. Possible values are: monday, tuesday, wednesday, thursday, friday, saturday, sunday. If not specified or empty, modify all seven days of the week by default.
        /// Description: The json example for modifying more than one day is as follows.
        /// [
        ///     "monday",
        ///     "tuesday"
        ///   ]
        /// </summary>
        [JsonProperty("Weekdays")]
        public string[] Weekdays{ get; set; }

        /// <summary>
        /// Data latency threshold (seconds), only applicable to primary instance and disaster recovery instance. No modification by default to keep the original threshold. Value ranges from 1 to 10 integers.
        /// </summary>
        [JsonProperty("MaxDelayTime")]
        public ulong? MaxDelayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "TimeRanges.", this.TimeRanges);
            this.SetParamArraySimple(map, prefix + "Weekdays.", this.Weekdays);
            this.SetParamSimple(map, prefix + "MaxDelayTime", this.MaxDelayTime);
        }
    }
}

