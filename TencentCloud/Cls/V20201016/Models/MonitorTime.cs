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

    public class MonitorTime : AbstractModel
    {
        
        /// <summary>
        /// <p>Execution cycle. Value range: <code>Period</code>, <code>Fixed</code>, <code>Cron</code>.</p><ul><li>Period: at a fixed frequency</li><li>Fixed: fixed time</li><li>Cron: cron expression</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Execution period or custom execution time point. Unit: minutes, value range: 1-1440.<br>When type is <code>Period</code> or <code>Fixed</code>, the time field takes effect.</p>
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// <p>The cron expression for the execution period. Example: <code>0/1 * * * *</code>. From left to right, each field represents Minutes field, Hours field, Day of month field, Month field, Day of week field. No support for second level. When the type is <code>Cron</code>, the CronExpression field takes effect.</p>
        /// </summary>
        [JsonProperty("CronExpression")]
        public string CronExpression{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "CronExpression", this.CronExpression);
        }
    }
}

