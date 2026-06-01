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

    public class AddTimeWindowRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Maintenance window on Monday. The format should be 10:00-12:00. You can set multiple time windows on a day. Each time window lasts from half an hour to three hours, and must start and end on the hour or half hour. At least one time window is required in a week. The same rule applies to the following parameters.
        /// </summary>
        [JsonProperty("Monday")]
        public string[] Monday{ get; set; }

        /// <summary>
        /// Maintenance window on Tuesday. At least one time window is required in a week.
        /// </summary>
        [JsonProperty("Tuesday")]
        public string[] Tuesday{ get; set; }

        /// <summary>
        /// Maintenance window on Wednesday. At least one time window is required in a week.
        /// </summary>
        [JsonProperty("Wednesday")]
        public string[] Wednesday{ get; set; }

        /// <summary>
        /// Maintenance window on Thursday. At least one time window is required in a week.
        /// </summary>
        [JsonProperty("Thursday")]
        public string[] Thursday{ get; set; }

        /// <summary>
        /// Maintenance window on Friday. At least one time window is required in a week.
        /// </summary>
        [JsonProperty("Friday")]
        public string[] Friday{ get; set; }

        /// <summary>
        /// Maintenance window on Saturday. At least one time window is required in a week.
        /// </summary>
        [JsonProperty("Saturday")]
        public string[] Saturday{ get; set; }

        /// <summary>
        /// Maintenance window on Sunday. At least one time window is required in a week.
        /// </summary>
        [JsonProperty("Sunday")]
        public string[] Sunday{ get; set; }

        /// <summary>
        /// Maximum delay threshold (seconds), only applicable to primary instance and disaster recovery instance. Default value: 10. Value ranges from 1 to 10 integers.
        /// </summary>
        [JsonProperty("MaxDelayTime")]
        public ulong? MaxDelayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "Monday.", this.Monday);
            this.SetParamArraySimple(map, prefix + "Tuesday.", this.Tuesday);
            this.SetParamArraySimple(map, prefix + "Wednesday.", this.Wednesday);
            this.SetParamArraySimple(map, prefix + "Thursday.", this.Thursday);
            this.SetParamArraySimple(map, prefix + "Friday.", this.Friday);
            this.SetParamArraySimple(map, prefix + "Saturday.", this.Saturday);
            this.SetParamArraySimple(map, prefix + "Sunday.", this.Sunday);
            this.SetParamSimple(map, prefix + "MaxDelayTime", this.MaxDelayTime);
        }
    }
}

