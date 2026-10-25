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
        /// <p>Data delivery area. Valid values:</p><ul><li>`mainland`: Chinese mainland;</li><li>`overseas`: Global (excluding the Chinese mainland).</li></ul>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>Data delivery type. Valid values:</p><ul><li>`l7-access-logs`: Layer 7 access logs;</li><li>`application`: Layer 4 proxy logs;</li><li>`function`: Edge Function execution logs;</li><li>`web-attack`: managed rule logs.</li></ul><p>The following log types have been merged into `l7-access-logs`, and no new tasks can be added for them:</p><ul><li>`domain`: site acceleration logs;</li><li>`web-rateLiming`: rate limiting and CC attack defense logs;</li><li>`web-rule`: custom rule logs;</li><li>`web-bot`: Bot management logs.</li></ul>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>Name of a real-time log delivery task, which can contain up to 200 characters, including digits, English letters, hyphens (-) and underscores (_).</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Type of the real-time log delivery task. Valid values:</p><ul><li>`cls`: deliver to Tencent Cloud CLS;</li><li>`custom_endpoint`: deliver to a custom HTTP(S) endpoint;</li><li>`s3`: deliver to an S3-compatible (SigV4 authentication algorithm compatible) object storage endpoint. This task type is not supported when `LogType` = `web-attack`;</li><li>`aws_s3`: deliver to an AWS S3 bucket. It uses IAM role authorization, requires no long-term key, and applies only to AWS native S3;</li><li>`log_analysis`: deliver to EdgeOne Log Analysis. This is supported only when `LogType` = `l7-access-logs` or `web-attack`.</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>List of entities that the real-time log delivery task applies to. Examples:</p><ul><li>Layer 7 domain name: `domain.example.com`</li><li>Layer 4 proxy instance: `sid-2s69eb5wcms7`</li><li>Edge Function instance: `test-zone-2mxigizoh9l9-1257626257`</li></ul>For valid values, see <a href="https://www.tencentcloud.com/document/product/1145/59024">DescribeL4Proxy</a>.
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// <p>List of preset fields to deliver. For valid values, see:</p><ul><li><a href="https://www.tencentcloud.com/document/product/1145/61300">Layer 7 access logs (site acceleration logs)</a></li><li><a href="https://www.tencentcloud.com/document/product/1145/61301">Layer 4 proxy logs</a></li><li><a href="https://www.tencentcloud.com/document/product/1145/67840">Edge Function execution logs</a></li></ul>For valid values, see also `DescribeLogFields`.
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
        /// <p>Sampling ratio, in per mille. Value range: 1-1000. For example, 605 means a sampling ratio of 60.5%. If left empty, the sampling ratio is 100%.</p>
        /// </summary>
        [JsonProperty("Sample")]
        public ulong? Sample{ get; set; }

        /// <summary>
        /// <p>Output format for log delivery. For usage details, see <a href="https://www.tencentcloud.com/document/product/1145/64485">Custom Log Output Format</a>. If left blank, the default format applies. The default format logic is as follows:</p><ul><li>When `TaskType` is `custom_endpoint`, the default format is an array of JSON objects, each JSON object represents a log entry;</li><li>When `TaskType` is `s3` or `aws_s3`, the default format is JSON Lines;</li></ul><p>Particularly, when `TaskType` is `cls` or `log_analysis`, the only allowed value for `LogFormat.FormatType` is `json`, and other parameters in `LogFormat` will be ignored. It is recommended not to transfer `LogFormat`.</p>
        /// </summary>
        [JsonProperty("LogFormat")]
        public LogFormat LogFormat{ get; set; }

        /// <summary>
        /// <p>CLS configuration. This parameter is required when `TaskType` is `cls`.</p>
        /// </summary>
        [JsonProperty("CLS")]
        public CLSTopic CLS{ get; set; }

        /// <summary>
        /// <p>Configuration of the custom HTTP service. This parameter is required when `TaskType` is `custom_endpoint`.</p>
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// <p>Configuration of the S3-compatible (SigV4 authentication algorithm compatible) object storage. This parameter is required when `TaskType` is `s3`.</p>
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3{ get; set; }

        /// <summary>
        /// <p>Configuration of the AWS S3 object storage. It uses IAM role authorization, requires no long-term key, and applies only to AWS native S3. This parameter is required when `TaskType` is `aws_s3`.</p>
        /// </summary>
        [JsonProperty("AWSS3")]
        public AWSS3 AWSS3{ get; set; }


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
            this.SetParamObj(map, prefix + "AWSS3.", this.AWSS3);
        }
    }
}

