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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UebaCustomRule : AbstractModel
    {
        
        /// <summary>
        /// Policy name.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 1: Cloud account
        /// 2: Custom user
        /// </summary>
        [JsonProperty("UserType")]
        public long? UserType{ get; set; }

        /// <summary>
        /// Occurrence time
        /// 10 minutes
        /// 2:1 hour
        /// 3: One day
        /// 4: A week
        /// 5: One month
        /// </summary>
        [JsonProperty("TimeInterval")]
        public long? TimeInterval{ get; set; }

        /// <summary>
        /// Event
        /// </summary>
        [JsonProperty("EventContent")]
        public UebaEventContent EventContent{ get; set; }

        /// <summary>
        /// Alarm name
        /// </summary>
        [JsonProperty("AlertName")]
        public string AlertName{ get; set; }

        /// <summary>
        /// Alarm type
        /// Prompt.
        /// 1: low
        /// 2: Medium risk
        /// 3: High risk
        /// 4: Critical
        /// </summary>
        [JsonProperty("AlterLevel")]
        public long? AlterLevel{ get; set; }

        /// <summary>
        /// Operator.
        /// </summary>
        [JsonProperty("Operator")]
        public string[] Operator{ get; set; }

        /// <summary>
        /// Operation object.
        /// </summary>
        [JsonProperty("OperateObject")]
        public string[] OperateObject{ get; set; }

        /// <summary>
        /// Operation method
        /// </summary>
        [JsonProperty("OperateMethod")]
        public string[] OperateMethod{ get; set; }

        /// <summary>
        /// Log type
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Chinese name in logs
        /// </summary>
        [JsonProperty("LogTypeStr")]
        public string LogTypeStr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "TimeInterval", this.TimeInterval);
            this.SetParamObj(map, prefix + "EventContent.", this.EventContent);
            this.SetParamSimple(map, prefix + "AlertName", this.AlertName);
            this.SetParamSimple(map, prefix + "AlterLevel", this.AlterLevel);
            this.SetParamArraySimple(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "OperateObject.", this.OperateObject);
            this.SetParamArraySimple(map, prefix + "OperateMethod.", this.OperateMethod);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "LogTypeStr", this.LogTypeStr);
        }
    }
}

