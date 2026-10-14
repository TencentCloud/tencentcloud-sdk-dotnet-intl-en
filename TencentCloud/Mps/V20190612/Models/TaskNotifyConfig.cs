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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskNotifyConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Notification type. Valid values:</p><li>CMQ: Removed. We recommend that you switch to TDMQ-CMQ.</li><li>TDMQ-CMQ: TDMQ.</li><li>URL: If URL is specified, HTTP callbacks are pushed to the URL specified in NotifyUrl. The callback protocol is HTTP and JSON. The packet body is the same as the output parameter of the event parsing notification API.</li><li>SCF: This is not recommended. Additional configuration for SCF is required in the console.</li><li>AWS-SQS: AWS queue. This is only suitable for AWS tasks in the same region.</li><font color="red"> Note: The default value is TDMQ-CMQ if this is not specified or empty. To use another type, you need to specify the corresponding value. If TDMQ-CMQ is used, oversized task response may cause failure to write to the queue. </font>
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// <p>Workflow notification mode. Valid values are Finish and Change. If this is not specified, the default value is Finish.</p>
        /// </summary>
        [JsonProperty("NotifyMode")]
        public string NotifyMode{ get; set; }

        /// <summary>
        /// <p>HTTP callback URL. This is required if NotifyType is URL.</p>
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// <p>CMQ or TDMQ for CMQ model. Valid values are Queue and Topic.</p>
        /// </summary>
        [JsonProperty("CmqModel")]
        public string CmqModel{ get; set; }

        /// <summary>
        /// <p>CMQ or TDMQ for CMQ region, such as sh or bj.</p>
        /// </summary>
        [JsonProperty("CmqRegion")]
        public string CmqRegion{ get; set; }

        /// <summary>
        /// <p>This field takes effect if the model is Topic. It indicates the topic name of the CMQ or TDMQ for CMQ for receiving event notifications.</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>This field takes effect if the model is Queue. It indicates the queue name of the CMQ or TDMQ for CMQ for receiving event notifications.</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>AWS SQS callback. This is required if NotifyType is AWS-SQS.</p>
        /// </summary>
        [JsonProperty("AwsSQS")]
        public AwsSQS AwsSQS{ get; set; }

        /// <summary>
        /// <p>Key used to generate the callback signature.</p>
        /// </summary>
        [JsonProperty("NotifyKey")]
        public string NotifyKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamSimple(map, prefix + "NotifyMode", this.NotifyMode);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "CmqModel", this.CmqModel);
            this.SetParamSimple(map, prefix + "CmqRegion", this.CmqRegion);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamObj(map, prefix + "AwsSQS.", this.AwsSQS);
            this.SetParamSimple(map, prefix + "NotifyKey", this.NotifyKey);
        }
    }
}

