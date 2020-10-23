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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeL4RulesErrHealthResponse : AbstractModel
    {
        
        /// <summary>
        /// Total number of exceptional rules
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// Exceptional rule list. Returned value description: `Key` is the rule ID, while `Value` is the exceptional IP. Multiple IPs are separated by ","
        /// </summary>
        [JsonProperty("ErrHealths")]
        public KeyValue[] ErrHealths{ get; set; }

        /// <summary>
        /// Exceptional rule list (which provides more error-related information). Returned value description:
        /// If `key` is `RuleId`, `Value` indicates the rule ID;
        /// If `key` is `Protocol`, `Value` indicates the forwarding protocol of a rule;
        /// If `key` is `VirtualPort`, `Value` indicates the forwarding port of a rule;
        /// If `Key` is `ErrMessage`, `Value` indicates the exception message for health check;
        /// Exception message for health check in the format of `"SourceIp:1.1.1.1|SourcePort:1234|AbnormalStatTime:1570689065|AbnormalReason:connection time out|Interval:20|CheckNum:6|FailNum:6"`. Multiple error messages for the source IP should be separated by `,`,
        /// SourceIp: real server IP, SourcePort: real server port, AbnormalStatTime: exception time, AbnormalReason: cause of exception, Interval: check frequency, CheckNum: number of checks, FailNum: number of failures;
        /// </summary>
        [JsonProperty("ExtErrHealths")]
        public KeyValueRecord[] ExtErrHealths{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "ErrHealths.", this.ErrHealths);
            this.SetParamArrayObj(map, prefix + "ExtErrHealths.", this.ExtErrHealths);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

