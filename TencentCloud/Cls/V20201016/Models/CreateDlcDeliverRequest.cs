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

    public class CreateDlcDeliverRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Log topic id.</p><ul><li>Obtain the log topic Id through <a href="https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1">Get Log Topic List</a>.</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Name: Length not exceeding 64 characters, starts with a letter, accepts 0-9, a-z, A-Z, _, -, Chinese character.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Delivery Type. 0: Batch delivery, 1: Real-time delivery</p>
        /// </summary>
        [JsonProperty("DeliverType")]
        public ulong? DeliverType{ get; set; }

        /// <summary>
        /// <p>Start time of the delivery time range</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// <p>dlc configuration message</p>
        /// </summary>
        [JsonProperty("DlcInfo")]
        public DlcInfo DlcInfo{ get; set; }

        /// <summary>
        /// <p>Delivery file size in MB. Required when DeliverType=0. Range: 5&lt;= MaxSize &lt;= 256.</p>
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// <p>Delivery interval in seconds. Required when DeliverType=0. Valid range: 300 &lt;= Interval &lt;= 900.</p>
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// <p>End time of the delivery time range. If empty, it means unlimited time. When EndTime is not empty, it must be greater than StartTime.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// <p>Whether to enable delivery service log. Valid values: 1: disable; 2: enable. Enabled by default.</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DeliverType", this.DeliverType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamObj(map, prefix + "DlcInfo.", this.DlcInfo);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
        }
    }
}

