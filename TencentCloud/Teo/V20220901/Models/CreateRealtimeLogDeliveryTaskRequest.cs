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

    public class CreateRealtimeLogDeliveryTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Data shipping area. Available values:<ul><li>mainland: within the Chinese mainland;</li><li>overseas: global (excluding the Chinese mainland).</li></ul></p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>Data delivery type. Available values:</p><ul><li>l7-access-logs: Layer 7 Access Logs;</li><li>application: Layer 4 Proxy Logs;</li><li>function: Function Logs;</li><li>web-attack: Managed Rule Logs.</li></ul><p>The following types of logs are merged into l7-access-logs and no longer support adding:</p><ul><li>domain: Site Acceleration Logs;</li><li>web-rateLiming: Rate Limit and CC Attack Defense Logs;</li><li>web-rule: Custom Rule Logs;</li><li>web-bot: Bot Management Logs.</li></ul>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>Name of a real-time log delivery task, which can contain up to 200 characters, including digits, English letters, hyphens (-) and underscores (_).</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Type of a real-time log shipping task. Valid values:<ul><li>cls: push to Tencent Cloud CLS;</li><li>custom_endpoint: push to a custom HTTP(S) address;</li><li>s3: push to an AWS S3-compatible bucket address;</li><li>log_analysis: push to EdgeOne log analytics. This is supported only when LogType = l7-access-logs or web-attack.</li></ul></p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>List of entities corresponding to real-time log delivery tasks. Example values:</p><ul><li>Layer 7 domain: domain.example.com</li><li>Layer 4 proxy instance: sid-2s69eb5wcms7</li><li>Edge function instance: test-zone-2mxigizoh9l9-1257626257</li></ul><p>For reference: <a href="https://www.tencentcloud.com/document/api/1552/103413?from_cn_redirect=1">DescribeL4Proxy</a></p>
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// <p>Predefined fields for delivery. For reference: <ul><li><a href="https://www.tencentcloud.com/document/product/1552/105791?from_cn_redirect=1">Layer 7 Access Logs (site acceleration log)</a></li><li><a href="https://www.tencentcloud.com/document/product/1552/105792?from_cn_redirect=1">four-layer proxy logs</a></li><li><a href="https://www.tencentcloud.com/document/product/1552/115585?from_cn_redirect=1">edge function logs</a></li></ul></p><p>For reference: DescribeLogFields</p>
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// <p>Custom fields for delivery support extracting specified content from HTTP request headers, response headers, cookies, and request bodies.<br>Custom field name must be unique. Only Layer 7 access logs (LogType= l7-access-logs or domain) support adding custom fields.<br>The count of custom fields allowed to be configured has a quota limit. If the quota is insufficient, please contact us (https://www.tencentcloud.com/contact-us).</p>
        /// </summary>
        [JsonProperty("CustomFields")]
        public CustomField[] CustomFields{ get; set; }

        /// <summary>
        /// <p>The list of custom expression fields for submission can be used to implement personalized real-time log content push through custom log push field names and value expressions. For usage details, refer to [Custom Log Field Expressions]().<br>Only Layer 7 Access Logs (LogType= l7-access-logs or domain) support  adding custom fields.<br>There is a quota limit on the count of custom fields that can be configured. If the quota is insufficient, please [contact us](https://www.tencentcloud.com/contact-us).<br>**Note**: If a field named in CustomExpressionFields has the same name as a field in Fields and CustomFields, the value in CustomExpressionFields takes precedence.</p>
        /// </summary>
        [JsonProperty("CustomExpressionFields")]
        public CustomExpressionField[] CustomExpressionFields{ get; set; }

        /// <summary>
        /// <p>Filter criteria of log shipping. If this parameter is not input, all logs will be shipped.</p>
        /// </summary>
        [JsonProperty("DeliveryConditions")]
        public DeliveryCondition[] DeliveryConditions{ get; set; }

        /// <summary>
        /// <p>Sampling ratio in permille. Value range: 1-1000. For example, 605 indicates a sampling ratio of 60.5%. If this parameter is not input, the sampling ratio is 100%.</p>
        /// </summary>
        [JsonProperty("Sample")]
        public ulong? Sample{ get; set; }

        /// <summary>
        /// <p>Output format for log delivery. For usage details, see <a href="https://www.tencentcloud.com/document/product/1552/110448?from_cn_redirect=1">Custom Log Output Format</a>. If left blank, the default format applies. The default format logic is as follows:<ul><li>When TaskType is 'custom_endpoint', the default format is an array of JSON objects, each JSON object represents a log entry;</li><li>When TaskType is 's3', the default format is JSON Lines;</li></ul>Particularly, when TaskType is 'cls' or 'log_analysis', the only allowed value for LogFormat.FormatType is 'json', and other parameters in LogFormat will be ignored. It is recommended not to transfer LogFormat.</p>
        /// </summary>
        [JsonProperty("LogFormat")]
        public LogFormat LogFormat{ get; set; }

        /// <summary>
        /// <p>Configuration information of CLS. This parameter is required when TaskType is cls.</p>
        /// </summary>
        [JsonProperty("CLS")]
        public CLSTopic CLS{ get; set; }

        /// <summary>
        /// <p>Configuration information of the custom HTTP service. This parameter is required when TaskType is custom_endpoint.</p>
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// <p>Configuration information of the AWS S3-compatible bucket. This parameter is required when TaskType is s3.</p>
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "EntityList.", this.EntityList);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArrayObj(map, prefix + "CustomExpressionFields.", this.CustomExpressionFields);
            this.SetParamArrayObj(map, prefix + "DeliveryConditions.", this.DeliveryConditions);
            this.SetParamSimple(map, prefix + "Sample", this.Sample);
            this.SetParamObj(map, prefix + "LogFormat.", this.LogFormat);
            this.SetParamObj(map, prefix + "CLS.", this.CLS);
            this.SetParamObj(map, prefix + "CustomEndpoint.", this.CustomEndpoint);
            this.SetParamObj(map, prefix + "S3.", this.S3);
        }
    }
}

