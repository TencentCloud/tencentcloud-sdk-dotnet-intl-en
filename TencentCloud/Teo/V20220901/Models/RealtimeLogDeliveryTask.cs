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

    public class RealtimeLogDeliveryTask : AbstractModel
    {
        
        /// <summary>
        /// <p>Real-time log delivery task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Name of the real-time log delivery task.</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Status of a real-time log shipping task. Valid values: <li>enabled: enabled;</li><li>disabled: disabled;</li><li>deleted: deleted abnormally. Check whether the destination log set/log topic of Tencent Cloud CLS has been deleted.</li></p>
        /// </summary>
        [JsonProperty("DeliveryStatus")]
        public string DeliveryStatus{ get; set; }

        /// <summary>
        /// <p>Type of a real-time log shipping task. Valid values: <ul><li>cls: push to Tencent Cloud CLS;</li> <li>custom_endpoint: push to a custom HTTP(S) address;</li> <li>s3: push to an S3-compatible (compatible with the SigV4 authentication algorithm) object storage address;</li><li>aws_s3: push to an AWS S3 bucket address;</li><li>log_analysis: push to EdgeOne log analytics.</li></ul></p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>List of entities corresponding to the real-time log delivery task (Layer 7 domain or L4 proxy instance). Example values: <li>Layer 7 domain: domain.example.com;</li> <li>L4 proxy instance: sid-2s69eb5wcms7.</li></p>
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// <p>Data delivery type. Valid values: <li>l7-access-logs: L7 access log</li><li>application: four-layer proxy logs</li> <li>function: edge function logs</li> <li>web-attack: managed rule log</li> <li>domain: site acceleration log</li> <li>web-rateLiming: rate limit and CC attack defense log</li><li>web-rule: custom rule log</li> <li>web-bot: Bot Management Log.</li></p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>Data shipping area. Valid values:<li>mainland: within the Chinese mainland;</li><li>overseas: global (excluding the Chinese mainland).</li></p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>List of predefined fields for delivery.</p>
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// <p>Custom fields for delivery.</p>
        /// </summary>
        [JsonProperty("CustomFields")]
        public CustomField[] CustomFields{ get; set; }

        /// <summary>
        /// <p>List of custom expression fields for shipping.</p>
        /// </summary>
        [JsonProperty("CustomExpressionFields")]
        public CustomExpressionField[] CustomExpressionFields{ get; set; }

        /// <summary>
        /// <p>Filter criteria of log shipping.</p>
        /// </summary>
        [JsonProperty("DeliveryConditions")]
        public DeliveryCondition[] DeliveryConditions{ get; set; }

        /// <summary>
        /// <p>Sampling ratio in permille. Value range: 1-1000. For example, 605 indicates a sampling ratio of 60.5%.</p>
        /// </summary>
        [JsonProperty("Sample")]
        public ulong? Sample{ get; set; }

        /// <summary>
        /// <p>Output format for log delivery. When the output parameter is null, the default format is used, which works as follows:</p><li>When TaskType is custom_endpoint, the default format is an array of JSON objects, where each JSON object represents a log entry;</li><li>When TaskType is s3, the default format is JSON Lines.</li>
        /// </summary>
        [JsonProperty("LogFormat")]
        public LogFormat LogFormat{ get; set; }

        /// <summary>
        /// <p>Configuration information of the CLS.</p>
        /// </summary>
        [JsonProperty("CLS")]
        public CLSTopic CLS{ get; set; }

        /// <summary>
        /// <p>Configuration information of the custom HTTP service.</p>
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// <p>Configuration message of S3-compatible (compatible with SigV4 authentication algorithm) object storage.</p>
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3{ get; set; }

        /// <summary>
        /// <p>Configuration information of the AWS S3 object storage. It uses IAM role authorization, eliminating the need for persistent keys, and is applicable only to AWS native S3.</p>
        /// </summary>
        [JsonProperty("AWSS3")]
        public AWSS3 AWSS3{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "DeliveryStatus", this.DeliveryStatus);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "EntityList.", this.EntityList);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
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
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

