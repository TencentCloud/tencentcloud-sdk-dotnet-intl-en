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
        /// The name of the real-time log delivery task, which is a combination of numbers, English letters, - and _, containing up to 200 characters.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// The type of the real-time log delivery task. Valid values:
        /// <li>cls: Push to Tencent Cloud CLS;</li>
        /// <li>custom_endpoint: Push to a user-defined HTTP(S) address;</li>
        /// <li>s3: Push to an AWS S3-compatible bucket address.</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// The list of entities (Layer 7 domains or Layer 4 proxy instances) corresponding to the real-time log delivery task. Valid value examples:
        /// <li>Layer 7 domain: domain.example.com;</li>
        /// <li>Layer 4 proxy instance: sid-2s69eb5wcms7.</li>
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// The type of data delivery. Valid values:
        /// <li>domain: Site acceleration log;</li>
        /// <li>application: Layer 4 proxy log;</li>
        /// <li>web-rateLiming: Rate limit and CC attack defense log;</li>
        /// <li>web-attack: Managed rule log;</li>
        /// <li>web-rule: Custom rule log;</li>
        /// <li>web-bot: Bot management log.</li>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// The data delivery area. Valid values:
        /// <li>mainland: Within the Chinese mainland;</li>
        /// <li>overseas: Global (excluding the Chinese mainland).</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// The list of predefined fields for delivery.
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// The list of custom fields for delivery, supporting extracting specified field values from HTTP request headers, response headers, and cookies. Each custom field name must be unique and the maximum number of fields is 200.
        /// </summary>
        [JsonProperty("CustomFields")]
        public CustomField[] CustomFields{ get; set; }

        /// <summary>
        /// Log delivery filter conditions. If this field is not filled in, all logs will be delivered.
        /// </summary>
        [JsonProperty("DeliveryConditions")]
        public DeliveryCondition[] DeliveryConditions{ get; set; }

        /// <summary>
        /// The sampling ratio in permille. Value range: 1 to 1000. For example, 605 represents a sampling ratio of 60.5%. If this field is not filled in, the sampling ratio is 100%.
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
        /// The configuration information of CLS. This parameter is required when TaskType is cls.
        /// </summary>
        [JsonProperty("CLS")]
        public CLSTopic CLS{ get; set; }

        /// <summary>
        /// The configuration information of the custom HTTP service. This parameter is required when TaskType is custom_endpoint.
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// The configuration information of the AWS S3-compatible bucket. This parameter is required when TaskType is s3.
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

