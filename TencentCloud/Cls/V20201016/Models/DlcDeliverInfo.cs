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

    public class DlcDeliverInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Task id.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Account id.</p>
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// <p>Log topic id.</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Task name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Delivery Type, 0: real-time delivery, 1: history delivery</p>
        /// </summary>
        [JsonProperty("DeliverType")]
        public ulong? DeliverType{ get; set; }

        /// <summary>
        /// <p>Delivery file size, in MB.</p>
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// <p>Delivery interval in seconds</p>
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// <p>Start time of the delivery time range</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// <p>End time of the delivery time range</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// <p>dlc configuration message</p>
        /// </summary>
        [JsonProperty("DlcInfo")]
        public DlcInfo DlcInfo{ get; set; }

        /// <summary>
        /// <p>Whether to enable delivery service log. 1 Disabled, 2 Enabled</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// <p>Task status.</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>Task progress. Historic delivery tasks take effect.</p>
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// <p>Log topic type. 0: Standard topic, 1: Metric topic</p>
        /// </summary>
        [JsonProperty("BizType")]
        public ulong? BizType{ get; set; }

        /// <summary>
        /// <p>Task creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>Task last modified.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>Auto-create dlc field</p><p>Default value: false</p><p>When there are additional fields in your log, the system will automatically ship them to DLC.</p>
        /// </summary>
        [JsonProperty("AutoCreateField")]
        public bool? AutoCreateField{ get; set; }

        /// <summary>
        /// <p>Store logs with delivery failure in a DLC table</p>
        /// </summary>
        [JsonProperty("DlcFailHandle")]
        public DlcFailHandle DlcFailHandle{ get; set; }

        /// <summary>
        /// <p>Log pre-filtering - Perform pre-filtering process on the original data for data ingestion into Splunk.</p>
        /// </summary>
        [JsonProperty("DSLFilter")]
        public string DSLFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DeliverType", this.DeliverType);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamObj(map, prefix + "DlcInfo.", this.DlcInfo);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AutoCreateField", this.AutoCreateField);
            this.SetParamObj(map, prefix + "DlcFailHandle.", this.DlcFailHandle);
            this.SetParamSimple(map, prefix + "DSLFilter", this.DSLFilter);
        }
    }
}

