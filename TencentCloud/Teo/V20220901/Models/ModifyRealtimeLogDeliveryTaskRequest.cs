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
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>ID of the real-time log delivery task.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Name of the real-time log delivery task. It can contain digits, letters, hyphens (-), and underscores (_), with a maximum of 200 characters. If left empty, the original configuration applies.</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Status of the real-time log delivery task. Valid values:</p><ul><li>`enabled`: enabled;</li><li>`disabled`: disabled.</li></ul>If left empty, the original configuration applies.
        /// </summary>
        [JsonProperty("DeliveryStatus")]
        public string DeliveryStatus{ get; set; }

        /// <summary>
        /// <p>List of entities that the real-time log delivery task applies to (Layer 7 domain names or Layer 4 proxy instances). Examples:</p><ul><li>Layer 7 domain name: `domain.example.com`;</li><li>Layer 4 proxy instance: `sid-2s69eb5wcms7`.</li></ul>If left empty, the original configuration applies. For valid values, see <a href="https://www.tencentcloud.com/document/product/1145/59024">DescribeL4Proxy</a>.
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// <p>List of preset fields to deliver. If left empty, the original configuration applies. For valid values, see `DescribeLogFields`.</p>
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// <p>List of custom fields to deliver. You can extract specified content from HTTP request headers, response headers, cookies, and request bodies.</p><p>Custom field names must be unique. Custom fields can be added only for Layer 7 access logs (`LogType` = `l7-access-logs` or `domain`).</p><p>The number of custom fields you can configure is subject to a quota. If the quota is insufficient, <a href="https://www.tencentcloud.com/contact-us">contact us</a>.</p>
        /// </summary>
        [JsonProperty("CustomFields")]
        public CustomField[] CustomFields{ get; set; }

        /// <summary>
        /// <p>List of custom expression fields to deliver. By defining the field name and value expression for log delivery, you can deliver personalized real-time log content. For details, see <a href="https://www.tencentcloud.com/document/product/1145/61302">Custom Log Field Expressions</a>.</p><p>Custom fields can be added only for Layer 7 access logs (`LogType` = `l7-access-logs` or `domain`).</p><p>The number of custom fields you can configure is subject to a quota. If the quota is insufficient, <a href="https://www.tencentcloud.com/contact-us">contact us</a>.</p><p><strong>Note</strong>: If a field in `CustomExpressionFields` has the same name as a field in `Fields` or `CustomFields`, the value in `CustomExpressionFields` takes precedence.</p>
        /// </summary>
        [JsonProperty("CustomExpressionFields")]
        public CustomExpressionField[] CustomExpressionFields{ get; set; }

        /// <summary>
        /// <p>Filter conditions for log delivery. If left empty, all logs are delivered.</p>
        /// </summary>
        [JsonProperty("DeliveryConditions")]
        public DeliveryCondition[] DeliveryConditions{ get; set; }

        /// <summary>
        /// <p>Sampling ratio, in per mille. Value range: 1-1000. For example, 605 means a sampling ratio of 60.5%. If left empty, the original configuration applies.</p>
        /// </summary>
        [JsonProperty("Sample")]
        public ulong? Sample{ get; set; }

        /// <summary>
        /// <p>Output format for log delivery. For usage details, see <a href="https://www.tencentcloud.com/document/product/1145/64485">Custom Log Output Format</a>. If left blank, the default format applies. The default format logic is as follows:</p><ul><li>When `TaskType` is `custom_endpoint`, the default format is an array of JSON objects, each JSON object represents a log entry;</li><li>When `TaskType` is `s3`, the default format is JSON Lines;</li></ul><p>Particularly, when `TaskType` is `cls` or `log_analysis`, the only allowed value for `LogFormat.FormatType` is `json`, and other parameters in `LogFormat` will be ignored. It is recommended not to transfer `LogFormat`.</p>
        /// </summary>
        [JsonProperty("LogFormat")]
        public LogFormat LogFormat{ get; set; }

        /// <summary>
        /// <p>Configuration of the custom HTTP service. If left empty, the original configuration applies.</p>
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// <p>Configuration of the S3-compatible (SigV4 authentication algorithm compatible) object storage. If left empty, the original configuration applies.</p>
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3{ get; set; }

        /// <summary>
        /// <p>Configuration of the AWS S3 object storage. If left empty, the original configuration applies.</p>
        /// </summary>
        [JsonProperty("AWSS3")]
        public AWSS3 AWSS3{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "CustomExpressionFields.", this.CustomExpressionFields);
            this.SetParamArrayObj(map, prefix + "DeliveryConditions.", this.DeliveryConditions);
            this.SetParamSimple(map, prefix + "Sample", this.Sample);
            this.SetParamObj(map, prefix + "LogFormat.", this.LogFormat);
            this.SetParamObj(map, prefix + "CustomEndpoint.", this.CustomEndpoint);
            this.SetParamObj(map, prefix + "S3.", this.S3);
            this.SetParamObj(map, prefix + "AWSS3.", this.AWSS3);
        }
    }
}

