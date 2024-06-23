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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmInfo : AbstractModel
    {
        
        /// <summary>
        /// Associated Task ID
        /// </summary>
        [JsonProperty("TaskIds")]
        public string TaskIds{ get; set; }

        /// <summary>
        /// Alert Categories; 'failure' indicates failure alert; 'overtime' indicates timeout alert
        /// </summary>
        [JsonProperty("AlarmType")]
        public string AlarmType{ get; set; }

        /// <summary>
        /// Alert Method; 'SMS' indicates SMS; 'Email' indicates email; 'HTTP' indicates an interface method; 'Wechat' indicates WeChat method
        /// </summary>
        [JsonProperty("AlarmWay")]
        public string AlarmWay{ get; set; }

        /// <summary>
        /// Alert Recipient, multiple recipients separated by ;
        /// </summary>
        [JsonProperty("AlarmRecipient")]
        public string AlarmRecipient{ get; set; }

        /// <summary>
        /// Alert Recipient ID, multiple recipient IDs separated by ;
        /// </summary>
        [JsonProperty("AlarmRecipientId")]
        public string AlarmRecipientId{ get; set; }

        /// <summary>
        /// Estimated Running Hours, value range 0-23
        /// </summary>
        [JsonProperty("Hours")]
        public ulong? Hours{ get; set; }

        /// <summary>
        /// Estimated Running Minutes, value range 0-59
        /// </summary>
        [JsonProperty("Minutes")]
        public ulong? Minutes{ get; set; }

        /// <summary>
        /// Alert Trigger Moment; '1' means first run failure; '2' means failure after all retries;
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// Alert Information ID
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// Alert Status Setting; '1' indicates available; '0' indicates unavailable, default is available
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskIds", this.TaskIds);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "AlarmWay", this.AlarmWay);
            this.SetParamSimple(map, prefix + "AlarmRecipient", this.AlarmRecipient);
            this.SetParamSimple(map, prefix + "AlarmRecipientId", this.AlarmRecipientId);
            this.SetParamSimple(map, prefix + "Hours", this.Hours);
            this.SetParamSimple(map, prefix + "Minutes", this.Minutes);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

