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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveStreamTaskNotifyConfig : AbstractModel
    {
        
        /// <summary>
        /// The notification type, `CMQ` by default. If this parameter is set to `URL`, HTTP callbacks are sent to the URL specified by `NotifyUrl`.
        /// 
        /// <font color="red">Note: If you do not pass this parameter or pass in an empty string, `CMQ` will be used. To use a different notification type, specify this parameter accordingly.</font>
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// CMQ model. There are two types: `Queue` and `Topic`. Currently, only `Queue` is supported.
        /// </summary>
        [JsonProperty("CmqModel")]
        public string CmqModel{ get; set; }

        /// <summary>
        /// CMQ region, such as `sh` and `bj`.
        /// </summary>
        [JsonProperty("CmqRegion")]
        public string CmqRegion{ get; set; }

        /// <summary>
        /// This parameter is valid when the model is `Queue`, indicating the name of the CMQ queue for receiving event notifications.
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// This parameter is valid when the model is `Topic`, indicating the name of the CMQ topic for receiving event notifications.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// HTTP callback URL, required if `NotifyType` is set to `URL`
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// Key used to generate a callback signature.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NotifyKey")]
        public string NotifyKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamSimple(map, prefix + "CmqModel", this.CmqModel);
            this.SetParamSimple(map, prefix + "CmqRegion", this.CmqRegion);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "NotifyKey", this.NotifyKey);
        }
    }
}

