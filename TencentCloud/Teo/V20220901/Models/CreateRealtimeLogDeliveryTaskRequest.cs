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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRealtimeLogDeliveryTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Name of a real-time log delivery task, which can contain up to 200 characters, including digits, English letters, hyphens (-) and underscores (_).
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Type of a real-time log delivery task. Valid values:
        /// <li>cls: push to Tencent Cloud CLS;</li>
        /// <li>custom_endpoint: push to a custom HTTP(S) address;</li>
        /// <li>s3: push to an AWS S3-compatible bucket address.</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// List of entities (L7 domain names or L4 proxy instances) corresponding to a real-time log delivery task. Valid value examples:
        /// <li>L7 domain name: domain.example.com;</li>
        /// <li>L4 proxy instance: sid-2s69eb5wcms7.</li>
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// Dataset type. Valid values:
        /// <li>domain: site acceleration logs;</li>
        /// <li>application: L4 proxy logs;</li>
        /// <li>web-rateLiming: rate limit and CC attack defense logs;</li>
        /// <li>web-attack: managed rule logs;</li>
        /// <li>web-rule: custom rule logs;</li>
        /// <li>web-bot: Bot management logs.</li>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Data area. Valid values:
        /// <li>mainland: within the Chinese mainland;</li>
        /// <li>overseas: global (excluding the Chinese mainland).</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// List of predefined fields for delivery.
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// The list of custom fields for log delivery, which supports extracting specified content from HTTP request headers, response headers, cookies, and request bodies. Custom field names must be unique. The number of custom fields cannot exceed a maximum of 200. A single real-time log delivery task can configure up to 5 custom fields of the request body type. Currently, only site acceleration logs (LogType=domain) support custom fields.
        /// </summary>
        [JsonProperty("CustomFields")]
        public CustomField[] CustomFields{ get; set; }

        /// <summary>
        /// Filter criteria of log delivery. If this parameter is not specified, all logs will be shipped.
        /// </summary>
        [JsonProperty("DeliveryConditions")]
        public DeliveryCondition[] DeliveryConditions{ get; set; }

        /// <summary>
        /// Sampling ratio in permille. Value range: 1-1000. For example, 605 indicates a sampling ratio of 60.5%. If this parameter is not specified, the sampling ratio is 100%.
        /// </summary>
        [JsonProperty("Sample")]
        public ulong? Sample{ get; set; }

        /// <summary>
        /// Output format for log delivery. If this field is not specified, the default format is used, which works as follows:
        /// <li>When TaskType is 'custom_endpoint', the default format is an array of JSON objects, with each JSON object representing a log entry;</li>
        /// <li>When TaskType is 's3', the default format is JSON Lines;</li>Specifically, when TaskType is 'cls', the only allowed value for LogFormat.FormatType is 'json', and other parameters in LogFormat will be ignored. It is recommended not to transfer LogFormat.
        /// </summary>
        [JsonProperty("LogFormat")]
        public LogFormat LogFormat{ get; set; }

        /// <summary>
        /// Configuration information of CLS. This parameter is required when TaskType is cls.
        /// </summary>
        [JsonProperty("CLS")]
        public CLSTopic CLS{ get; set; }

        /// <summary>
        /// Configuration information of the custom HTTP service. This parameter is required when TaskType is custom_endpoint.
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// Configuration information of the AWS S3-compatible bucket. This parameter is required when TaskType is s3.
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "EntityList.", this.EntityList);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArrayObj(map, prefix + "DeliveryConditions.", this.DeliveryConditions);
            this.SetParamSimple(map, prefix + "Sample", this.Sample);
            this.SetParamObj(map, prefix + "LogFormat.", this.LogFormat);
            this.SetParamObj(map, prefix + "CLS.", this.CLS);
            this.SetParamObj(map, prefix + "CustomEndpoint.", this.CustomEndpoint);
            this.SetParamObj(map, prefix + "S3.", this.S3);
        }
    }
}

