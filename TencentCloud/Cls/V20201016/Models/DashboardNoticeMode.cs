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

    public class DashboardNoticeMode : AbstractModel
    {
        
        /// <summary>
        /// Dashboard notification method.
        /// 
        /// -Uin: Tencent Cloud user
        /// -Group: Tencent Cloud user group
        /// -WeCom: wecom callback
        /// -Email: Custom email
        /// - DingTalk: DingTalk
        /// -Lark
        /// </summary>
        [JsonProperty("ReceiverType")]
        public string ReceiverType{ get; set; }

        /// <summary>
        /// Method corresponding value.
        /// -When ReceiverType is `WeCom`, `DingTalk`, or `Lark`, Values must be empty and the Url field is required.
        /// -When ReceiverType is `Uin`, `Group`, or `Email`, the Values field is required, and the Url field must be empty.
        /// -When ReceiverType is `Uin`, Values is the user id. Obtain the sub-user UID by pulling sub-users (https://www.tencentcloud.com/document/product/598/34587?from_cn_redirect=1).
        /// -When ReceiverType is `Group`, Values is the user Group id. Query the user Group list (https://www.tencentcloud.com/document/product/598/34589?from_cn_redirect=1) to obtain the user Group id.
        /// -When ReceiverType is `Email`, Values is the user email.
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// Dashboard notification channel.
        /// 
        /// -Support: ["Email","Sms","WeChat","Phone"].
        /// -   When ReceiverType is `Email` or `WeCom`, ReceiverChannels is unavailable.
        /// </summary>
        [JsonProperty("ReceiverChannels")]
        public string[] ReceiverChannels{ get; set; }

        /// <summary>
        /// Subscription method - Callback URL.
        /// -When ReceiverType is `WeCom`, `DingTalk`, or `Lark`, the Url field is required as the callback URL for each channel.
        /// -When it is `WeCom`, the Url is the enterprise wechat callback address.
        /// -For `DingTalk`, the Url is the chatbot Webhook address.
        /// -When it is `Lark`, the Url is the chatbot Webhook address.
        /// -When ReceiverType is `Uin`, `Group`, or `Email`, the Url field must be empty.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReceiverType", this.ReceiverType);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamArraySimple(map, prefix + "ReceiverChannels.", this.ReceiverChannels);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

