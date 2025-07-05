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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRealtimeLogDeliveryTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The ID of the real-time log delivery task.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// The name of the real-time log delivery task, which is a combination of numbers, English letters, - and _, containing up to 200 characters. If this field is not filled in, the original configuration will be retained.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// The status of the real-time log delivery task. Valid values:
        /// <li>enabled: Enabled;</li>
        /// <li>disabled: Disabled.</li>If this field is not filled in, the original configuration will be retained.
        /// </summary>
        [JsonProperty("DeliveryStatus")]
        public string DeliveryStatus{ get; set; }

        /// <summary>
        /// The list of entities (Layer 7 domains or Layer 4 proxy instances) corresponding to the real-time log delivery task. Valid value examples:
        /// <li>Layer 7 domain: domain.example.com;</li>
        /// <li>Layer 4 proxy instance: sid-2s69eb5wcms7.</li>If this field is not filled in, the original configuration will be retained.
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// The list of predefined fields for delivery. If this field is not filled in, the original configuration will be retained.
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// The list of custom fields for shipping, which supports extracting specified content from HTTP request headers, response headers, cookies, and request bodies. If this parameter is not filled in, the original configuration will be retained. The name of each custom field should be unique and the maximum number of fields is 200. Up to 5 custom fields of the request body type can be added for a single real-time log push task. Currently, adding custom fields is supported only for site acceleration logs (LogType=domain).
        /// </summary>
        [JsonProperty("CustomFields")]
        public CustomField[] CustomFields{ get; set; }

        /// <summary>
        /// Log delivery filter conditions. If this field is not filled in, all logs will be delivered.
        /// </summary>
        [JsonProperty("DeliveryConditions")]
        public DeliveryCondition[] DeliveryConditions{ get; set; }

        /// <summary>
        /// The sampling ratio in permille. Value range: 1 to 1000. For example, 605 represents a sampling ratio of 60.5%. If this field is not filled in, the original configuration will be retained.
        /// </summary>
        [JsonProperty("Sample")]
        public ulong? Sample{ get; set; }

        /// <summary>
        /// Output format for log delivery. If this field is not specified, the original configuration will be retained. Specifically, when TaskType is cls, the value of LogFormat.FormatType can only be json, and other parameters in LogFormat will be ignored. It is recommended not to input LogFormat.
        /// </summary>
        [JsonProperty("LogFormat")]
        public LogFormat LogFormat{ get; set; }

        /// <summary>
        /// The configuration information of the custom HTTP service. If this field is not filled in, the original configuration will be retained.
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// The configuration information of the AWS S3-compatible bucket. If this field is not filled in, the original configuration will be retained.
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "DeliveryStatus", this.DeliveryStatus);
            this.SetParamArraySimple(map, prefix + "EntityList.", this.EntityList);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArrayObj(map, prefix + "DeliveryConditions.", this.DeliveryConditions);
            this.SetParamSimple(map, prefix + "Sample", this.Sample);
            this.SetParamObj(map, prefix + "LogFormat.", this.LogFormat);
            this.SetParamObj(map, prefix + "CustomEndpoint.", this.CustomEndpoint);
            this.SetParamObj(map, prefix + "S3.", this.S3);
        }
    }
}

