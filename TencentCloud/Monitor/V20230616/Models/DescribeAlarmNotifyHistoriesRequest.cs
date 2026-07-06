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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmNotifyHistoriesRequest : AbstractModel
    {
        
        /// <summary>
        /// Monitoring type
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }

        /// <summary>
        /// Start time, used as a Unix timestamp in seconds.
        /// </summary>
        [JsonProperty("QueryBaseTime")]
        public long? QueryBaseTime{ get; set; }

        /// <summary>
        /// Period to query before QueryBaseTime, in seconds.
        /// </summary>
        [JsonProperty("QueryBeforeSeconds")]
        public long? QueryBeforeSeconds{ get; set; }

        /// <summary>
        /// Pagination parameter.
        /// </summary>
        [JsonProperty("PageParams")]
        public PageByNoParams PageParams{ get; set; }

        /// <summary>
        /// Fill in when the monitoring type is MT_QCE. Namespace of the affiliation.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Fill in when the monitoring type is MT_QCE. Alarm policy type
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Query the notification history of a policy
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "QueryBaseTime", this.QueryBaseTime);
            this.SetParamSimple(map, prefix + "QueryBeforeSeconds", this.QueryBeforeSeconds);
            this.SetParamObj(map, prefix + "PageParams.", this.PageParams);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
        }
    }
}

