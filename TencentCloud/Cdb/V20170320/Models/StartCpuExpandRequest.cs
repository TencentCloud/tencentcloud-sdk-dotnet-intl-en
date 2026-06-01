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

    public class StartCpuExpandRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Scale-out type supports auto-scaling and custom scaling.
        /// Description: 1. auto means automatic scaling. 2. manual means custom scaling with immediate effect. 3. timeInterval means custom scaling by time. 4. period means custom scaling by cycle.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Number of CPU cores for scale-out during customization.
        /// Description: 1. This parameter is required when Type is set to manual, timeInterval, or period. 2. The maximum number of CPU cores to increase is the current instance's CPU core number. For example, an 8-core 16GB instance can scale out up to 8 CPU cores, with a range of 1 - 8.
        /// </summary>
        [JsonProperty("ExpandCpu")]
        public long? ExpandCpu{ get; set; }

        /// <summary>
        /// Automatic scale-out policy. This parameter is required when Type is set to auto.
        /// </summary>
        [JsonProperty("AutoStrategy")]
        public AutoStrategy AutoStrategy{ get; set; }

        /// <summary>
        /// Scaling policy by time period.
        /// Description: When Type is timeInterval, TimeIntervalStrategy is required.
        /// </summary>
        [JsonProperty("TimeIntervalStrategy")]
        public TimeIntervalStrategy TimeIntervalStrategy{ get; set; }

        /// <summary>
        /// Scale by cycle.
        /// Description: When Type is period, PeriodStrategy is required.
        /// </summary>
        [JsonProperty("PeriodStrategy")]
        public PeriodStrategy PeriodStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ExpandCpu", this.ExpandCpu);
            this.SetParamObj(map, prefix + "AutoStrategy.", this.AutoStrategy);
            this.SetParamObj(map, prefix + "TimeIntervalStrategy.", this.TimeIntervalStrategy);
            this.SetParamObj(map, prefix + "PeriodStrategy.", this.PeriodStrategy);
        }
    }
}

