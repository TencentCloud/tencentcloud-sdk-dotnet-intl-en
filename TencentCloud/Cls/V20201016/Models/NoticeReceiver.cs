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

    public class NoticeReceiver : AbstractModel
    {
        
        /// <summary>
        /// Recipient type. Available values:
        /// -Uin - User ID
        /// -Group - User group ID
        /// Other recipient types are not currently supported.
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// Recipient.
        /// When ReceiverType is Uin, the value of ReceiverIds is the user uid. [Sub-user information query](https://www.tencentcloud.com/document/api/598/53486?from_cn_redirect=1)
        /// When ReceiverType is Group, ReceiverIds is the user Group id. [CAM User Group](https://www.tencentcloud.com/document/product/598/34589?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("ReceiverIds")]
        public long?[] ReceiverIds{ get; set; }

        /// <summary>
        /// Notification receiving channel
        /// -Mail
        /// -Sms
        /// -WeChat
        /// -Phone - phone
        /// </summary>
        [JsonProperty("ReceiverChannels")]
        public string[] ReceiverChannels{ get; set; }

        /// <summary>
        /// Notification content template ID. Use Default-zh to refer to the Default template (Chinese). Use Default-en to refer to DefaultTemplate (English). Get the notification content template ID by searching the notification content template (https://www.tencentcloud.com/document/product/614/111714?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("NoticeContentId")]
        public string NoticeContentId{ get; set; }

        /// <summary>
        /// Start time to allow receipt of information. Format: `15:04:05`. Required.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Allow receipt of information end time. Format: `15:04:05`. Required
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Bit order.
        /// 
        /// -Invalid when passed as an input parameter.
        /// -Valid at that time.
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamArraySimple(map, prefix + "ReceiverIds.", this.ReceiverIds);
            this.SetParamArraySimple(map, prefix + "ReceiverChannels.", this.ReceiverChannels);
            this.SetParamSimple(map, prefix + "NoticeContentId", this.NoticeContentId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Index", this.Index);
        }
    }
}

